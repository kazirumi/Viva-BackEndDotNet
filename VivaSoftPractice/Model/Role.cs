using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VivaSoftPractice.Model
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<UserRole> UserRoles { get; set; }
    }
}
