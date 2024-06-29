using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.ServiceDtos;

namespace AutoShowroom_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto serviceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto serviceDto);

        Task<GetByIdServiceDto> GetService(int id);
    }
}
