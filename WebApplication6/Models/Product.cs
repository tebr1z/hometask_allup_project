using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication6.Models
{
    public class Product : BaseEntity

    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsFeatured { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal DisCountPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal ExTax { get; set; }
        public int DisCountRate { get; set; }
        
        public int Count { get; set; }
      
        public int Seria { get; set; }
      
        public string Code { get; set; }
    }
}
