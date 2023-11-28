using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Repository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")] // must key in API beforehand
    [ApiController]
    public class ColoursController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ColoursController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Colours
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Colour>>> GetColours()
        public async Task<IActionResult> GetColours()
        {
            /*
          if (_context.Colours == null)
          {
              return NotFound();
          }
            return await _context.Colours.ToListAsync();*/
            var colours = await _unitOfWork.Colours.GetAll();
            return Ok(colours);
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Colour>> GetColour(int id)
        public async Task<IActionResult> GetColour(int id)
        {
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            if (colour == null) return NotFound();
            return Ok(colour);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {
            if (id != colour.Id)
            {
                return BadRequest();
            }

            //_context.Entry(colour).State = EntityState.Modified;
            _unitOfWork.Colours.Update(colour);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColourExists(id))
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

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour colour)
        {
            /*if (_context.Colours == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Colours'  is null.");
            }
              _context.Colours.Add(colour);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Colours.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            /*if (_context.Colours == null)
            {
                return NotFound();
            }
            var colour = await _context.Colours.FindAsync(id);
            if (colour == null)
            {
                return NotFound();
            }

            _context.Colours.Remove(colour);
            await _context.SaveChangesAsync();*/
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            if (colour == null) return NotFound();
            await _unitOfWork.Colours.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColourExists(int id)
        {
            //return (_context.Colours?.Any(e => e.Id == id)).GetValueOrDefault();
            var colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            return colour != null;
        }
    }
}
