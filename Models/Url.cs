using System;
using System.ComponentModel.DataAnnotations;

namespace UrlShortenerApi.Models
{
    public class Url
    {
        public int Id { get; set; }

        [Required]
        public string OriginalUrl { get; set; } = string.Empty;

        [Required]
        public string ShortCode { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int Clicks { get; set; } = 0;
    }
}