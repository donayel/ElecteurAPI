using Microsoft.AspNetCore.Mvc;
using ElecteurAPI.Data;
using ElecteurAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ElecteurAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElecteursController : ControllerBase
    {
        private readonly ElecteurContext _context;

        public ElecteursController(ElecteurContext context)
        {
            _context = context;
        }

        // GET: api/Electeurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Electeur>>> GetElecteurs()
        {
            return await _context.Electeurs.ToListAsync();
        }

        // GET: api/Electeurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Electeur>> GetElecteur(int id)
        {
            var electeur = await _context.Electeurs.FindAsync(id);

            if (electeur == null)
            {
                return NotFound();
            }

            return electeur;
        }

        // POST: api/Electeurs
        [HttpPost]
        public async Task<ActionResult<Electeur>> PostElecteur(Electeur electeur)
        {
            _context.Electeurs.Add(electeur);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetElecteur), new { id = electeur.Id }, electeur);
        }

        // PUT: api/Electeurs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElecteur(int id, Electeur electeur)
        {
            if (id != electeur.Id)
            {
                return BadRequest();
            }

            _context.Entry(electeur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElecteurExists(id))
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

        // DELETE: api/Electeurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElecteur(int id)
        {
            var electeur = await _context.Electeurs.FindAsync(id);
            if (electeur == null)
            {
                return NotFound();
            }

            _context.Electeurs.Remove(electeur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElecteurExists(int id)
        {
            return _context.Electeurs.Any(e => e.Id == id);
        }
    }
}
