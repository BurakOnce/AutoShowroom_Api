using AutoShowroom_Api.Dtos.ToDoListDtos;
using AutoShowroom_Api.Models.DapperContext;
using Dapper;

namespace AutoShowroom_Api.Repositories.ToDoListRepositories
{
    public class ToDoListRepository:IToDoListRepository
    {
        private readonly Context _context;
        public ToDoListRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultToDoListDto>> GetAllToDoList()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }
        }
    }
}
