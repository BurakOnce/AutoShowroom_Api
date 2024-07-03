using AutoShowroom_Api.Dtos.ProductDtos;

namespace AutoShowroom_Api.Repositories.ProductRepository

{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultLast5ProductWithCategory>> GetLast5ProductAsync();
    }
}
