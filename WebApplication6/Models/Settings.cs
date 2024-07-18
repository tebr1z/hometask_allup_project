using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Settings:BaseEntity

    {

        public string ? Key { get; set; }
        [Required]
        [MaxLength(255)]
        public string Value { get; set; }
    }
}
