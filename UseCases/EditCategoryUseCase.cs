using Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.DataStorePluginInterfaces
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }
    }
}
