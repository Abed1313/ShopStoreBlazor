using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models.DTO
{
    public class CartItemDTO
    {
        public int CartItemId { get; set; }
        public int Quantity { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
    }
}
