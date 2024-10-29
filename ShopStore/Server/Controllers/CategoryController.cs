using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ShpoSDbContext _context;

        public CategoryController(ShpoSDbContext context)
        {
            _context = context;
        }

        // GET: api/category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/category/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return category;
        }

        // POST: api/category
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(CategoryDTO categoryDTO)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'ShopDbContext.Categories' is null.");
            }

            var category = new Category
            {
                Name = categoryDTO.Name,
                Description = categoryDTO.Description
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { id = category.CategoryId }, category);
        }

        // PUT: api/category/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, CategoryDTO categoryDTO)
        {
            if (id != categoryDTO.CategoryId)
            {
                return BadRequest("Category ID mismatch.");
            }
                                                          // updated 
            var category = await _context.Categories.Where(s => s.CategoryId == id).FirstOrDefaultAsync();
            if (category == null)
            {
                return NotFound();
            }

            category.Name = categoryDTO.Name;
            category.Description = categoryDTO.Description;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/category/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
