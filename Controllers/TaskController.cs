using Blogging_Platform_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogging_Platform_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private static List<TaskIteam> tasks = new List<TaskIteam>();

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult Create(TaskIteam task)
        {
            tasks.Add(task);
            return Ok(tasks);
        }
    }
}
