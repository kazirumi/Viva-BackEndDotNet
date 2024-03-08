using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VivaSoftPractice.Data;
using VivaSoftPractice.Model;

namespace VivaSoftPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesMainsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SalesMainsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/SalesMains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesMain>>> GetSalesMains()
        {
          if (_context.SalesMains == null)
          {
              return NotFound();
          }
            return await _context.SalesMains.ToListAsync();
        }

        // GET: api/SalesMains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesMain>> GetSalesMain(Guid id)
        {
          if (_context.SalesMains == null)
          {
              return NotFound();
          }
            var salesMain = await _context.SalesMains.FindAsync(id);

            if (salesMain == null)
            {
                return NotFound();
            }

            return salesMain;
        }

        // PUT: api/SalesMains/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesMain(Guid id, SalesMain salesMain)
        {
            if (id != salesMain.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesMainExists(id))
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

        // POST: api/SalesMains
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SalesMainDTO>> PostSalesMain(SalesMainDTO salesMain)
        {
          if (_context.SalesMains == null)
          {
              return Problem("Entity set 'ApplicationDBContext.SalesMains'  is null.");
          }
            var SalesMainEntity = salesMain.Adapt<SalesMain>();
            _context.SalesMains.Add(SalesMainEntity);
            await _context.SaveChangesAsync();

            return Ok(SalesMainEntity.Adapt<SalesMainDTO>());
        }

        // DELETE: api/SalesMains/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesMain(Guid id)
        {
            if (_context.SalesMains == null)
            {
                return NotFound();
            }
            var salesMain = await _context.SalesMains.FindAsync(id);
            if (salesMain == null)
            {
                return NotFound();
            }

            _context.SalesMains.Remove(salesMain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesMainExists(Guid id)
        {
            return (_context.SalesMains?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
