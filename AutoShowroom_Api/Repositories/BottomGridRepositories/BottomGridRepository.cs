using Dapper;
using AutoShowroom_Api.Dtos.BottomGridDtos;
using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Models.DapperContext;
using AutoShowroom_Api.Repositories.BottomGridRepositories;

namespace AutoShowroom_Api.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;
        public BottomGridRepository(Context context) { _context = context; }
        public void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
