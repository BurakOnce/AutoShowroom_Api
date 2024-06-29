using Microsoft.AspNetCore.Mvc;
using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.WhoWeAreDetailDtos;
using AutoShowroom_Api.Repositories.WhoWeAreRepository;

namespace AutoShowroom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;

        public WhoWeAreDetailController(IWhoWeAreRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDto);
            return Ok("Who We Are Detail başarılı bir şekilde eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAreDetail(id);
            return Ok("Who We Are Detail başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _whoWeAreRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDto);
            return Ok("Who We Are Detail Başarılı Şekilde Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }
    }
}
