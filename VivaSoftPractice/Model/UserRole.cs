using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VivaSoftPractice.Model
{
   
    public class UserRole
    {

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }

    }
}
