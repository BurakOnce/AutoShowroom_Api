using Dapper;
using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.ServiceDtos;
using AutoShowroom_Api.Models.DapperContext;

namespace AutoShowroom_Api.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;
        public ServiceRepository(Context context) { _context = context; }

        public async void CreateService(CreateServiceDto serviceDto)
        {
            string query = "insert into Services (ServiceName,ServiceStatus) values (@serviceName, @serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", serviceDto.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteService(int id)
        {
            string query = "DELETE FROM Services WHERE ServiceId =@serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Services";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdServiceDto> GetService(int id)
        {
            string query = "SELECT * From Services WHERE ServiceId=@serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdServiceDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDto serviceDto)
        {
            string query = "UPDATE Services SET ServiceName = @serviceName, ServiceStatus = @serviceStatus WHERE ServiceId = @serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", serviceDto.ServiceId);
            parameters.Add("@serviceName", serviceDto.ServiceName);
            parameters.Add("@serviceStatus", serviceDto.ServiceStatus);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
