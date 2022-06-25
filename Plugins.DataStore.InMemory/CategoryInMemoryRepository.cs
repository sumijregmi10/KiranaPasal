using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            //Here Add some categories
            categories = new List<Category>()
            {
                new Category { CategoryID = 1, Name = "Bakery", Description = "Bakery"},
                new Category { CategoryID = 2, Name = "Beverage", Description = "Beverage"},
                new Category { CategoryID = 3, Name = "Meat", Description = "Meat"},
            };
        }

        public void AddCategory(Category category)
       {
            if(categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryID);
                category.CategoryID = maxId + 1;
            }
            else
            {
                category.CategoryID = 1;
            }

            categories.Add(category);

       }
        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryID);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryID)
        {
          return categories?.FirstOrDefault(x => x.CategoryID == categoryID);
        }

        public void DeleteCategory(int CategoryID)
        {
            categories?.Remove(GetCategoryById(CategoryID));
        }
    }

}
