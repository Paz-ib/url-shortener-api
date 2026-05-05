using Microsoft.AspNetCore.Mvc;

namespace UrlShortenerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API funcionando");
        }
    }
}