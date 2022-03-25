using Microsoft.AspNetCore.Mvc;

namespace MyMovieCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Stub for my movies");
        }
    }
}
