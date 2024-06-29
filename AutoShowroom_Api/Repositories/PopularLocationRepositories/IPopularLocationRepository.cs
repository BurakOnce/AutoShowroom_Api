using AutoShowroom_Api.Dtos.PopularLocationDtos;

namespace AutoShowroom_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
         Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();

    }
}
