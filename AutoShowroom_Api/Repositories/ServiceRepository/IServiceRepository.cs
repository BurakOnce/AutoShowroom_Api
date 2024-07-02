using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.ServiceDtos;

namespace AutoShowroom_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllService();
        Task CreateService(CreateServiceDto createServiceDto);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
