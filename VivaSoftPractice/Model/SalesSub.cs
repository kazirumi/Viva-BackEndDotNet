using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivaSoftPractice.Model
{
    public class SalesSub
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [ForeignKey("SalesMain")]
        public Guid SalesMainId { get; set; }
        public virtual SalesMain SalesMain { get; set; }

        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        public virtual Item Item { get; set; }

        [Required, MinLength(1)]
        public int Quantity { get; set; }

        [Required]
        public double TotalSubPrice { get; set; }
    }
}
