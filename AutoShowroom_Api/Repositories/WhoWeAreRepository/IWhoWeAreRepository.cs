using AutoShowroom_Api.Dtos.CategoryDtos;
using AutoShowroom_Api.Dtos.WhoWeAreDetailDtos;
using AutoShowroom_Api.Dtos.WhoWeAreDtos;

namespace AutoShowroom_Api.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);

        Task<GetByIdWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
