﻿using System.Collections.Generic;
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
    public class OrdersController : ControllerBase
    {
        private readonly ShpoSDbContext _context;

        public OrdersController(ShpoSDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            if (_context.Orders == null)
            {
                return NotFound();
            }
            return await _context.Orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, OrderDTO orderDto)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            order.OrderDate = orderDto.OrderDate;
            order.TotalAmount = orderDto.TotalAmount;
            order.OrderStatus = orderDto.OrderStatus;
            order.CustomerId = orderDto.CustomerId;
            order.OrderItems = _context.OrderItems
                .Where(oi => orderDto.OrderItemIds.Contains(oi.OrderItemId))
                .ToList();

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderDTO orderDto)
        {
            var order = new Order
            {
                OrderDate = orderDto.OrderDate,
                TotalAmount = orderDto.TotalAmount,
                OrderStatus = orderDto.OrderStatus,
                CustomerId = orderDto.CustomerId,
                OrderItems = _context.OrderItems
                    .Where(oi => orderDto.OrderItemIds.Contains(oi.OrderItemId))
                    .ToList()
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
