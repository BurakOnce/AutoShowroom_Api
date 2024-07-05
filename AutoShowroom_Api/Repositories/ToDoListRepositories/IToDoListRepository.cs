using AutoShowroom_Api.Dtos.ToDoListDtos;

namespace AutoShowroom_Api.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoList();

    }
}
