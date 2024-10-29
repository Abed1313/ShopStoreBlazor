using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopStore.Server;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;

namespace ShopStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController : ControllerBase
    {
        private readonly ShpoSDbContext _context;

        public ShoppingCartsController(ShpoSDbContext context)
        {
            _context = context;
        }

        // GET: api/ShoppingCarts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoppingCart>>> GetShoppingCarts()
        {
            if (_context.ShoppingCarts == null)
            {
                return NotFound();
            }
            return await _context.ShoppingCarts.ToListAsync();
        }

        // GET: api/ShoppingCarts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingCart>> GetShoppingCart(int id)
        {
            if (_context.ShoppingCarts == null)
            {
                return NotFound();
            }
            var shoppingCart = await _context.ShoppingCarts
                .Include(sc => sc.CartItems)
                .FirstOrDefaultAsync(sc => sc.ShoppingCartId == id);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            return shoppingCart;
        }

        // PUT: api/ShoppingCarts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoppingCart(int id, ShoppingCartDTO shoppingCartDTO)
        {
            if (id != shoppingCartDTO.ShoppingCartId)
            {
                return BadRequest();
            }

            var shoppingCart = new ShoppingCart
            {
                ShoppingCartId = shoppingCartDTO.ShoppingCartId,
                CreatedDate = shoppingCartDTO.CreatedDate,
                CustomerId = shoppingCartDTO.CustomerId,
                CartItems = shoppingCartDTO.CartItems.Select(ci => new CartItem
                {
                    CartItemId = ci.CartItemId,
                    Quantity = ci.Quantity,
                    ProductId = ci.ProductId
                }).ToList()
            };

            _context.Entry(shoppingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartExists(id))
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

        // POST: api/ShoppingCarts
        [HttpPost]
        public async Task<ActionResult<ShoppingCart>> PostShoppingCart(ShoppingCartDTO shoppingCartDTO)
        {
            if (_context.ShoppingCarts == null)
            {
                return Problem("Entity set 'ShpoSDbContext.ShoppingCarts' is null.");
            }

            var shoppingCart = new ShoppingCart
            {
                CreatedDate = shoppingCartDTO.CreatedDate,
                CustomerId = shoppingCartDTO.CustomerId,
                CartItems = shoppingCartDTO.CartItems.Select(ci => new CartItem
                {
                    Quantity = ci.Quantity,
                    ProductId = ci.ProductId
                }).ToList()
            };

            _context.ShoppingCarts.Add(shoppingCart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoppingCart", new { id = shoppingCart.ShoppingCartId }, shoppingCart);
        }

        // DELETE: api/ShoppingCarts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoppingCart(int id)
        {
            if (_context.ShoppingCarts == null)
            {
                return NotFound();
            }
            var shoppingCart = await _context.ShoppingCarts.FindAsync(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }

            _context.ShoppingCarts.Remove(shoppingCart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShoppingCartExists(int id)
        {
            return (_context.ShoppingCarts?.Any(e => e.ShoppingCartId == id)).GetValueOrDefault();
        }
    }
}
