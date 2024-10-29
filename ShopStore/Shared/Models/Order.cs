using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatusEnum OrderStatus { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Navigation property for the items in the order
        public List<OrderItem> OrderItems { get; set; }

        public enum OrderStatusEnum
        {
            Pending,
            Shipped,
            Delivered,
            Canceled
        }
    }
}
