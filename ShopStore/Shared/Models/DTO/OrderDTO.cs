using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models.DTO
{
    public class OrderDTO
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public List<int> OrderItemIds { get; set; } // Assume order items are represented by IDs
        public Order.OrderStatusEnum OrderStatus { get; set; }
    }
}
