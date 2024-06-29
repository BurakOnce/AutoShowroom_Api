using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoShowroom_Api.Repositories.CategoryRepository;
using AutoShowroom_Api.Repositories.PopularLocationRepositories;

namespace AutoShowroom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
    }
}
