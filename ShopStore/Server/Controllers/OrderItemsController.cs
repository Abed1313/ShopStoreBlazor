using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopStore.Server;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;

namespace ShopStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly ShpoSDbContext _context;

        public OrderItemsController(ShpoSDbContext context)
        {
            _context = context;
        }

        // GET: api/OrderItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems()
        {
            if (_context.OrderItems == null)
            {
                return NotFound();
            }
            return await _context.OrderItems.ToListAsync();
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderItem>> GetOrderItem(int id)
        {
            if (_context.OrderItems == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems
                .Include(oi => oi.Order) // Include related entities if necessary
                .Include(oi => oi.Product) // Include related entities if necessary
                .FirstOrDefaultAsync(oi => oi.OrderItemId == id);

            if (orderItem == null)
            {
                return NotFound();
            }

            return orderItem;
        }

        // PUT: api/OrderItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItemDTO orderItemDto)
        {
            if (id != orderItemDto.OrderItemId)
            {
                return BadRequest();
            }

            var orderItem = await _context.OrderItems.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            orderItem.Quantity = orderItemDto.Quantity;
            orderItem.UnitPrice = orderItemDto.UnitPrice;
            orderItem.OrderId = orderItemDto.OrderId;
            orderItem.ProductId = orderItemDto.ProductId;

            _context.Entry(orderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // POST: api/OrderItems
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItemDTO orderItemDto)
        {
            if (_context.OrderItems == null)
            {
                return Problem("Entity set 'ShpoSDbContext.OrderItems' is null.");
            }

            var orderItem = new OrderItem
            {
                Quantity = orderItemDto.Quantity,
                UnitPrice = orderItemDto.UnitPrice,
                OrderId = orderItemDto.OrderId,
                ProductId = orderItemDto.ProductId
            };

            _context.OrderItems.Add(orderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderItem), new { id = orderItem.OrderItemId }, orderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            if (_context.OrderItems == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderItemExists(int id)
        {
            return _context.OrderItems?.Any(e => e.OrderItemId == id) ?? false;
        }
    }
}
