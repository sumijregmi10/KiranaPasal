using System;
using System.Collections.Generic;
using System.Text;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;

      

        public DeleteCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Delete(int CategoryID)
        {
          categoryRepository.DeleteCategory(CategoryID);
        }
    }
}
