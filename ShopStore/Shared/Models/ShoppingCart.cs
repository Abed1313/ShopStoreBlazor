using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public DateTime CreatedDate { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Navigation property for cart items
        public List<CartItem> CartItems { get; set; }
    }
}
