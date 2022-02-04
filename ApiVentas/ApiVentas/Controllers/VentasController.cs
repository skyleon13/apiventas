using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiVentas.Data;
using ApiVentas.Models;

namespace ApiVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly ApiVentasContext _context;

        public VentasController(ApiVentasContext context)
        {
            _context = context;
        }

        // GET: api/Ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ventas>>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        // GET: api/Ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ventas>> GetVentas(int id)
        {
            var ventas = await _context.Ventas.FindAsync(id);

            if (ventas == null)
            {
                return NotFound();
            }

            return ventas;
        }

        // PUT: api/Ventas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVentas(int id, Ventas ventas)
        {
            if (id != ventas.IdVenta)
            {
                return BadRequest();
            }

            _context.Entry(ventas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentasExists(id))
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

        // POST: api/Ventas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVentas(Ventas ventas)
        {
            _context.Ventas.Add(ventas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVentas", new { id = ventas.IdVenta }, ventas);
        }

        // DELETE: api/Ventas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ventas>> DeleteVentas(int id)
        {
            var ventas = await _context.Ventas.FindAsync(id);
            if (ventas == null)
            {
                return NotFound();
            }

            _context.Ventas.Remove(ventas);
            await _context.SaveChangesAsync();

            return ventas;
        }

        private bool VentasExists(int id)
        {
            return _context.Ventas.Any(e => e.IdVenta == id);
        }
    }
}
