using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models.DTO
{
    public class ReviewDTO
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
