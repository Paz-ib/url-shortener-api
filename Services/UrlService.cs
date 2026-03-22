using UrlShortenerApi.Data;
using UrlShortenerApi.Models;

namespace UrlShortenerApi.Services
{
    public class UrlService
    {
        private readonly AppDbContext _context;

        public UrlService(AppDbContext context)
        {
            _context = context;
        }

        public ShortUrl CreateShortUrl(string originalUrl)
        {
            var shortCode = GenerateShortCode();

            var shortUrl = new ShortUrl
            {
                OriginalUrl = originalUrl,
                ShortCode = shortCode
            };

            _context.ShortUrls.Add(shortUrl);
            _context.SaveChanges();

            return shortUrl;
        }

        public ShortUrl? GetByCode(string code)
        {
            return _context.ShortUrls.FirstOrDefault(x => x.ShortCode == code);
        }

        private string GenerateShortCode()
        {
            return Guid.NewGuid().ToString().Substring(0, 6);
        }
    }
}