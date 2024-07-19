using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Brand:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
