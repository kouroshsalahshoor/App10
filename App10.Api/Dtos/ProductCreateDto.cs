using System.ComponentModel.DataAnnotations;

namespace App10.Api.Dtos
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        [Range(0.01, 10000.00)]
        public double Price { get; set; }
        public string? Tag { get; set; }
        public string? Description { get; set; }
        public IFormFile? File { get; set; }
    }
}
