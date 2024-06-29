using Microsoft.AspNetCore.Mvc;
using AutoShowroom_Api.Dtos.ServiceDtos;
using AutoShowroom_Api.Repositories.ServiceRepository;

namespace AutoShowroom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _serviceRepository.CreateService(createServiceDto);
            return Ok("Service başarılı bir şekilde eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("Service başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateService(updateServiceDto);
            return Ok("Service Başarılı Şekilde Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRepository.GetService(id);
            return Ok(value);
        }
    }
}
