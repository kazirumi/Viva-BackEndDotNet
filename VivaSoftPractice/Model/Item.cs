using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VivaSoftPractice.Model
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Name",TypeName ="varchar(50)")]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
