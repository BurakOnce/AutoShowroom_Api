using AutoShowroom_Api.Dtos.EmployeeDtos;

namespace AutoShowroom_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployee();
        Task CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
