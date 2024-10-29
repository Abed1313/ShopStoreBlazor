using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models.DTO
{
    public class ShoppingCartDTO
    {
        public int ShoppingCartId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public List<CartItemDTO> CartItems { get; set; }
    }
}
