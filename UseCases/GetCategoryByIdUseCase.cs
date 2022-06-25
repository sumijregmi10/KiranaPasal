using Business;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class GetCategoryByIdUseCase: IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
            
        }
        public Category Execute(int categoryID)
        {
            return categoryRepository.GetCategoryById(categoryID);
        }
    }
}
