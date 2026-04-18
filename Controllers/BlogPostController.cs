using Blogging_Platform_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogging_Platform_API.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        List<BlogPost> blogs = new List<BlogPost>();

        [HttpGet("GET")]
        public IActionResult Index()
        {
            return Ok(blogs);
        }
        [HttpPost("POST")]
        public IActionResult Create(BlogPost blog)
        {
            blogs.Add(blog);
            return Ok(blogs);
        }

    }
}
