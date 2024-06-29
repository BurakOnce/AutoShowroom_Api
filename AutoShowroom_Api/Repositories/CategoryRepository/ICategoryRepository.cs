using AutoShowroom_Api.Dtos.CategoryDtos;

namespace AutoShowroom_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);

        Task<GetByIdCategoryDto> GetCategory(int id);
    }
}
