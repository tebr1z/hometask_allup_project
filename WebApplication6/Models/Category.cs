using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name{ get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public bool IsMain{ get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }

    }
}
