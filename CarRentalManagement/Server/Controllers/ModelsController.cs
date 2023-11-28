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
    public class ModelsController : ControllerBase
    {
        //refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            //refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Models
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Model>>> GetModels()
        public async Task<IActionResult> GetModels()
        {
            /*
          if (_context.Models == null)
          {
              return NotFound();
          }
            return await _context.Models.ToListAsync();*/
            var models = await _unitOfWork.Models.GetAll();
            return Ok(models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Model>> GetModel(int id)
        public async Task<IActionResult> GetModel(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null) return NotFound();
            return Ok(model);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            //_context.Entry(model).State = EntityState.Modified;
            _unitOfWork.Models.Update(model);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
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

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model model)
        {
            /*if (_context.Models == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Models'  is null.");
            }
              _context.Models.Add(model);
              await _context.SaveChangesAsync();*/
            await _unitOfWork.Models.Insert(model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModel", new { id = model.Id }, model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            /*if (_context.Models == null)
            {
                return NotFound();
            }
            var model = await _context.Models.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            _context.Models.Remove(model);
            await _context.SaveChangesAsync();*/
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null) return NotFound();
            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ModelExists(int id)
        {
            //return (_context.Models?.Any(e => e.Id == id)).GetValueOrDefault();
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            return model != null;
        }
    }
}
