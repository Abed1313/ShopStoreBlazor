using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Shared.Models
{
    public class Customer
    {
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PasswordHash { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }

            // Navigation property for customer orders
            public List<Order> Orders { get; set; }
        public List<Review> reviews { get; set; }


    }
}
