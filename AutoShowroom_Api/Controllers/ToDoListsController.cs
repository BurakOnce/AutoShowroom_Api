using AutoShowroom_Api.Repositories.ToDoListRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _ToDoListRepository;
        public ToDoListsController(IToDoListRepository ToDoListRepository)
        {
            _ToDoListRepository = ToDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _ToDoListRepository.GetAllToDoList();
            return Ok(values);
        }
    }
}
