using AutoShowroom_Api.Dtos.ProductDtos;

namespace AutoShowroom_Api.Repositories.ProductRepository

{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
    }
}
