using Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategoryById(int categoryID);
        void DeleteCategory(int CategoryID);
    }
}
