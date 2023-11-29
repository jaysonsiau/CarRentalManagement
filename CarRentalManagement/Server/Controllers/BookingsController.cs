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
    public class BookingsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bookings
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        public async Task<IActionResult> GetBookings()
        {
            /*
          if (_context.Bookings == null)
          {
              return NotFound();
          }
            return await _context.Bookings.ToListAsync();*/
            // The Include function is similar to how we refer to FKs in SQL
            var bookings = await _unitOfWork.Bookings.GetAll(includes: q => q.Include(x => x.Vehicle).Include(x => x.Customer));
            return Ok(bookings);
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Booking>> GetBooking(int id)
        public async Task<IActionResult> GetBooking(int id)
        {
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (booking == null) return NotFound();
            return Ok(booking);
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            //_context.Entry(booking).State = EntityState.Modified;
            _unitOfWork.Bookings.Update(booking);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
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

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            /*if (_context.Bookings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Bookings'  is null.");
            }
              _context.Bookings.Add(booking);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Bookings.Insert(booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            /*if (_context.Bookings == null)
            {
                return NotFound();
            }
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();*/
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (booking == null) return NotFound();
            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            //return (_context.Bookings?.Any(e => e.Id == id)).GetValueOrDefault();
            var booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return booking != null;
        }
    }
}
