using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models.DTO
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public Payment.PaymentMethodEnum PaymentMethod { get; set; }
        public int OrderId { get; set; } // Foreign key reference
    }
}
