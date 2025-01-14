﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }

        // Foreign Key
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public enum PaymentMethodEnum
        {
            CreditCard,
            PayPal,
            BankTransfer
        }
    }
}
