using Dapper;
using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.WhoWeAreDetailDtos;
using AutoShowroom_Api.Dtos.WhoWeAreDtos;
using AutoShowroom_Api.Models.DapperContext;

namespace AutoShowroom_Api.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;
        public WhoWeAreRepository(Context context) { _context = context; }
        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title, Subtitle, Description1,Description2) values (@title, @subtitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", createWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "DELETE FROM WhoWeAreDetail WHERE WhoWeAreDetailId =@whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            string query = "UPDATE WhoWeAreDetail SET Title=@title, Subtitle=@subtitle, Description1=@description1, Description2=@description2  WHERE WhoWeAreDetailId = @whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", updateWhoWeAreDetailDto.WhoWeAreDetailId);
            parameters.Add("@title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", updateWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDto.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters); 
            }
        }



        public async Task<GetByIdWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
        {
            string query = "SELECT * From WhoWeAreDetail WHERE WhoWeAreDetailId=@whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }


    }
}
