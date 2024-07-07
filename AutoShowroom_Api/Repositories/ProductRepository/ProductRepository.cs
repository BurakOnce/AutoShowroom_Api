using Dapper;
using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.ProductDtos;
using AutoShowroom_Api.Models.DapperContext;

namespace AutoShowroom_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context) { _context = context; }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync()
        {
            string query = "Select ProductId,Title,Price,City,District,CategoryName,CoverImage,Type,Address, DealOfTheDay From Product inner join Category on Product.ProductCategory=Category.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductWithCategory>> GetLast5ProductAsync()
        {
            string query = "Select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,Type,AdvertisementDate From Product Inner Join Category On Product.ProductCategory=Category.CategoryID Order By ProductID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategory>(query);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async void ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsync(int id)
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address,DealOfTheday From Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
