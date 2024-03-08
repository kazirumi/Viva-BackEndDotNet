using System.ComponentModel.DataAnnotations;

namespace VivaSoftPractice.Model
{
    public class SalesMainDTO
    {
        [Key]
        public Guid? Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime SalesDate { get; set; }

        [Required]
        public double TotalAmount { get; set; }

        public virtual List<SalesSubDTO> SalesSubs { get; set; }
    }
}
