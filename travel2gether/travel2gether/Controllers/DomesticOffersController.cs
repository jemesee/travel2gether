using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travel2gether.Data;
using travel2gether.Models;

namespace travel2gether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomesticOffersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DomesticOffersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DomesticOffers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DomesticOffer>>> GetDomesticOffers()
        {
            return await _context.DomesticOffers.ToListAsync();
        }

        // GET: api/DomesticOffers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DomesticOffer>> GetDomesticOffer(int id)
        {
            var domesticOffer = await _context.DomesticOffers.FindAsync(id);

            if (domesticOffer == null)
            {
                return NotFound();
            }

            return domesticOffer;
        }

        // PUT: api/DomesticOffers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomesticOffer(int id, DomesticOffer domesticOffer)
        {
            if (id != domesticOffer.Id)
            {
                return BadRequest();
            }

            _context.Entry(domesticOffer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomesticOfferExists(id))
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

        // POST: api/DomesticOffers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DomesticOffer>> PostDomesticOffer(DomesticOffer domesticOffer)
        {
            _context.DomesticOffers.Add(domesticOffer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDomesticOffer", new { id = domesticOffer.Id }, domesticOffer);
        }

        // DELETE: api/DomesticOffers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DomesticOffer>> DeleteDomesticOffer(int id)
        {
            var domesticOffer = await _context.DomesticOffers.FindAsync(id);
            if (domesticOffer == null)
            {
                return NotFound();
            }

            _context.DomesticOffers.Remove(domesticOffer);
            await _context.SaveChangesAsync();

            return domesticOffer;
        }

        private bool DomesticOfferExists(int id)
        {
            return _context.DomesticOffers.Any(e => e.Id == id);
        }
    }
}
