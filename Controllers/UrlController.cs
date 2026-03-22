using Microsoft.AspNetCore.Mvc;
using UrlShortenerApi.Services;

namespace UrlShortenerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly UrlService _urlService;

        public UrlController(UrlService urlService)
        {
            _urlService = urlService;
        }

        [HttpPost]
        public IActionResult Create(string originalUrl)
        {
            var result = _urlService.CreateShortUrl(originalUrl);
            return Ok(result);
        }

        [HttpGet("{code}")]
        public IActionResult Get(string code)
        {
            var url = _urlService.GetByCode(code);

            if (url == null)
                return NotFound();

            return Ok(url);
        }
    }
}