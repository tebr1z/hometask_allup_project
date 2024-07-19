namespace WebApplication6.Models
{
    public class Category:BaseEntity
    {
        public string Name{ get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }

    }
}
