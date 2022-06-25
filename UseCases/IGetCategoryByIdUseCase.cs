using Business;

namespace UseCases
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryID);
    }
}