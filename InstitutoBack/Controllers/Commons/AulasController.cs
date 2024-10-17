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
    public class AulasController : ControllerBase
    {
        private readonly InstitutoContext _context;

        public AulasController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: api/Aulas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aula>>> GetAula()
        {
            return await _context.Aula.ToListAsync();
        }

        // GET: api/Aulas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aula>> GetAula(int id)
        {
            var aula = await _context.Aula.FindAsync(id);

            if (aula == null)
            {
                return NotFound();
            }

            return aula;
        }

        // PUT: api/Aulas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAula(int id, Aula aula)
        {
            if (id != aula.Id)
            {
                return BadRequest();
            }

            _context.Entry(aula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AulaExists(id))
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

        // POST: api/Aulas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aula>> PostAula(Aula aula)
        {
            _context.Aula.Add(aula);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAula", new { id = aula.Id }, aula);
        }

        // DELETE: api/Aulas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAula(int id)
        {
            var aula = await _context.Aula.FindAsync(id);
            if (aula == null)
            {
                return NotFound();
            }

            _context.Aula.Remove(aula);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AulaExists(int id)
        {
            return _context.Aula.Any(e => e.Id == id);
        }
    }
}
