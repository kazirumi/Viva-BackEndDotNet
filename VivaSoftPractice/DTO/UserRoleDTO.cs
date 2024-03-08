using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VivaSoftPractice.Model
{
   
    public class UserRoleDTO
    {

        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }


    }
}
