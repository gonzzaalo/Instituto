using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InstitutoBack.DataContext;
using InstitutoServices.Models.Commons;

namespace InstitutoBack.Controllers.Commons
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiJefesSeccionesController : ControllerBase
    {
        private readonly InstitutoContext _context;

        public ApiJefesSeccionesController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: api/ApiJefesSecciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JefeSeccion>>> Getjefessecciones()
        {
            return await _context.jefessecciones.ToListAsync();
        }

        // GET: api/ApiJefesSecciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JefeSeccion>> GetJefeSeccion(int id)
        {
            var jefeSeccion = await _context.jefessecciones.FindAsync(id);

            if (jefeSeccion == null)
            {
                return NotFound();
            }

            return jefeSeccion;
        }

        // PUT: api/ApiJefesSecciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJefeSeccion(int id, JefeSeccion jefeSeccion)
        {
            if (id != jefeSeccion.Id)
            {
                return BadRequest();
            }

            _context.Entry(jefeSeccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JefeSeccionExists(id))
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

        // POST: api/ApiJefesSecciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JefeSeccion>> PostJefeSeccion(JefeSeccion jefeSeccion)
        {
            _context.jefessecciones.Add(jefeSeccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJefeSeccion", new { id = jefeSeccion.Id }, jefeSeccion);
        }

        // DELETE: api/ApiJefesSecciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJefeSeccion(int id)
        {
            var jefeSeccion = await _context.jefessecciones.FindAsync(id);
            if (jefeSeccion == null)
            {
                return NotFound();
            }
            jefeSeccion.Eliminado = true;
            _context.jefessecciones.Update(jefeSeccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JefeSeccionExists(int id)
        {
            return _context.jefessecciones.Any(e => e.Id == id);
        }
    }
}
