using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Models.DapperContext;
using Dapper;
namespace AutoShowroom_Api.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context) { _context = context; }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName, CategoryStatus) values (@categoryName, @categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            { 
                var values =await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
        public async void DeleteCategory(int id)
        {
            string query = "DELETE FROM Category WHERE CategoryId =@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "UPDATE Category SET CategoryName = @categoryName, CategoryStatus = @categoryStatus WHERE CategoryId = @categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", categoryDto.CategoryId);
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "SELECT * From Category WHERE CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query,parameters);
                return values;
            }
        }
    }
}
        