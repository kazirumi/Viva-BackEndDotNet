using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivaSoftPractice.Model
{
    public class SalesSubDTO
    {
        [Key]
        public Guid? Id { get; set; }
        
        [ForeignKey("SalesMain")]
        public Guid? SalesMainId { get; set; }
        //public virtual SalesMain SalesMain { get; set; }

        [ForeignKey("Item")]
        public Guid? ItemId { get; set; }
        //public virtual Item Item { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double TotalSubPrice { get; set; }
    }
}
