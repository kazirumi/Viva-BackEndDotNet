using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VivaSoftPractice.Data;
using VivaSoftPractice.Model;

namespace VivaSoftPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UserRolesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/UserRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRole>>> GetuserRoles()
        {
          if (_context.userRoles == null)
          {
              return NotFound();
          }
            return await _context.userRoles.ToListAsync();
        }

        // GET: api/UserRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserRole>> GetUserRole(Guid id)
        {
          if (_context.userRoles == null)
          {
              return NotFound();
          }
            var userRole = await _context.userRoles.FindAsync(id);

            if (userRole == null)
            {
                return NotFound();
            }

            return userRole;
        }

        // PUT: api/UserRoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRole(Guid id, UserRole userRole)
        {
            if (id != userRole.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRoleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserRoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserRole>> PostUserRole(UserRoleDTO userRoleDTO)
        {
          if (_context.userRoles == null)
          {
              return Problem("Entity set 'ApplicationDBContext.userRoles'  is null.");
          }

          UserRole userRole= new UserRole() { RoleId= userRoleDTO.RoleId, UserId= userRoleDTO.UserId };
            _context.userRoles.Add(userRole);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserRoleExists(userRole.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserRole", new { id = userRole.UserId }, userRole);
        }

        // DELETE: api/UserRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRole(Guid id)
        {
            if (_context.userRoles == null)
            {
                return NotFound();
            }
            var userRole = await _context.userRoles.FindAsync(id);
            if (userRole == null)
            {
                return NotFound();
            }

            _context.userRoles.Remove(userRole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserRoleExists(Guid id)
        {
            return (_context.userRoles?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
