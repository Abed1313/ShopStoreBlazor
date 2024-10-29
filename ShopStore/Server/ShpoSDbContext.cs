using Microsoft.EntityFrameworkCore;
using ShopStore.Shared.Models;

namespace ShopStore.Server
{
    public class ShpoSDbContext : DbContext
    {
      public ShpoSDbContext(DbContextOptions<ShpoSDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring Product and Category relationship (Many-to-One)
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring Order and Customer relationship (Many-to-One)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring OrderItem and Order relationship (Many-to-One)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring OrderItem and Product relationship (Many-to-One)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuring ShoppingCart and Customer relationship (One-to-One)
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.Customer)
                .WithMany()
                .HasForeignKey(sc => sc.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring CartItem and ShoppingCart relationship (Many-to-One)
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.ShoppingCart)
                .WithMany(sc => sc.CartItems)
                .HasForeignKey(ci => ci.ShoppingCartId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring CartItem and Product relationship (Many-to-One)
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);



            // Configuring Review and Customer relationship (Many-to-One)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.reviews)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuring Review and Product relationship (Many-to-One)
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany()
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Add additional configurations as necessary

            // Optional: Configure table names, field lengths, or indexes
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderStatus)
                .IsRequired();

            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentMethod)
                .IsRequired();

            modelBuilder.Entity<Category>().HasData(
               new Category { CategoryId = 1, Name = "Electronics", Description = "Gadgets and electronic devices." },
               new Category { CategoryId = 7, Name = "Clothing", Description = "Men's and women's fashion clothing." },
               new Category { CategoryId = 3, Name = "Groceries", Description = "Daily essentials and grocery items." },
               new Category { CategoryId = 8, Name = "Home Appliances", Description = "Appliances for home use." },
               new Category { CategoryId = 5, Name = "Books", Description = "A wide selection of books and literature." },
               new Category { CategoryId = 6, Name = "Sports & Outdoors", Description = "Sporting goods and outdoor equipment." }
           );

            modelBuilder.Entity<Product>().HasData(
              // Electronics
              new Product
              {
                  ProductId = 13,
                  Name = "Smartphone",
                  Description = "Latest model with advanced features.",
                  Price = 999.99M,
                  StockQuantity = 50,
                  ImageUrl = "https://cdn.thewirecutter.com/wp-content/media/2024/05/smartphone-2048px-1013.jpg?auto=webp&quality=75&width=1024",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 1
              },
              new Product
              {
                  ProductId = 2,
                  Name = "Laptop",
                  Description = "High-performance laptop for work and gaming.",
                  Price = 1299.99M,
                  StockQuantity = 30,
                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtx2RG7uu8ZNC3OjKHz0-crGiazI5WakIPkw&s",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 1
              },

              // Clothing
              new Product
              {
                  ProductId = 3,
                  Name = "Jeans",
                  Description = "Stylish blue denim jeans.",
                  Price = 49.99M,
                  StockQuantity = 100,
                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrbTx7GNrW-VEYs2e0NJeeLnTy1Tp1X5jAYw&s",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 2
              },
              new Product
              {
                  ProductId = 4,
                  Name = "T-Shirt",
                  Description = "Casual cotton t-shirt in various colors.",
                  Price = 19.99M,
                  StockQuantity = 200,
                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTeNJ8472BMvKR7qF6MR_VebosgHbJ4PeFDA&s",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 2
              },

              // Groceries
              new Product
              {
                  ProductId = 5,
                  Name = "Organic Apples",
                  Description = "Fresh organic apples (1kg).",
                  Price = 3.99M,
                  StockQuantity = 200,
                  ImageUrl = "https://freshindiaorganics.com/cdn/shop/products/Apples.jpg?v=1686739530",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 3
              },
              new Product
              {
                  ProductId = 6,
                  Name = "Almond Milk",
                  Description = "Dairy-free almond milk (1L).",
                  Price = 2.99M,
                  StockQuantity = 150,
                  ImageUrl = "https://i0.wp.com/stephanieleenutrition.com/wp-content/uploads/2022/06/Untitled-design-8-e1654793763569.png?fit=600%2C401&ssl=1",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 3
              },

              // Home Appliances
              new Product
              {
                  ProductId = 7,
                  Name = "Microwave Oven",
                  Description = "Compact microwave oven for quick meals.",
                  Price = 79.99M,
                  StockQuantity = 50,
                  ImageUrl = "https://www.ikea.com/sa/en/images/products/vaermd-microwave-oven-ikea-300-black__1337364_pe947844_s5.jpg?f=s",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 4
              },
              new Product
              {
                  ProductId = 8,
                  Name = "Vacuum Cleaner",
                  Description = "Powerful vacuum cleaner with HEPA filter.",
                  Price = 199.99M,
                  StockQuantity = 40,
                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyAdTTxEvokOw5nJ1f1yKpIDmyF-KEK6cOA&s",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 4
              },

              // Books
              new Product
              {
                  ProductId = 9,
                  Name = "The Great Gatsby",
                  Description = "Classic novel by F. Scott Fitzgerald.",
                  Price = 10.99M,
                  StockQuantity = 100,
                  ImageUrl = "https://images.penguinrandomhouse.com/cover/9780593311844",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 5
              },
              new Product
              {
                  ProductId = 10,
                  Name = "1984",
                  Description = "Dystopian novel by George Orwell.",
                  Price = 9.99M,
                  StockQuantity = 120,
                  ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1657781256i/61439040.jpg",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 5
              },

              // Sports & Outdoors
              new Product
              {
                  ProductId = 11,
                  Name = "Tennis Racket",
                  Description = "Professional-grade tennis racket.",
                  Price = 99.99M,
                  StockQuantity = 30,
                  ImageUrl = "https://example.com/images/tennisracket.jpg",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 6
              },
              new Product
              {
                  ProductId = 12,
                  Name = "Camping Tent",
                  Description = "Waterproof 2-person camping tent.",
                  Price = 149.99M,
                  StockQuantity = 20,
                  ImageUrl = "https://m.media-amazon.com/images/I/71Nao63gy7S.jpg",
                  CreatedDate = DateTime.UtcNow,
                  CategoryId = 6
              }
          );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@example.com",
                    PasswordHash = "hashedpassword123", // Replace with real hash for security
                    Address = "123 Elm Street, Springfield",
                    PhoneNumber = "555-1234"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "janesmith@example.com",
                    PasswordHash = "hashedpassword456", // Replace with real hash for security
                    Address = "456 Oak Avenue, Metropolis",
                    PhoneNumber = "555-5678"
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alicejohnson@example.com",
                    PasswordHash = "hashedpassword789", // Replace with real hash for security
                    Address = "789 Pine Lane, Gotham",
                    PhoneNumber = "555-9012"
                }
            );

            modelBuilder.Entity<Order>().HasData(
  new Order
  {
      OrderId = 1,
      OrderDate = DateTime.Now.AddDays(-7),
      TotalAmount = 699.99M,
      OrderStatus = Order.OrderStatusEnum.Shipped,
      CustomerId = 1
  },
  new Order
  {
      OrderId = 2,
      OrderDate = DateTime.Now.AddDays(-5),
      TotalAmount = 1299.99M,
      OrderStatus = Order.OrderStatusEnum.Pending,
      CustomerId = 2
  },
   new Order
   {
       OrderId = 3,
       OrderDate = DateTime.Now.AddDays(-5),
       TotalAmount = 138.99M,
       OrderStatus = Order.OrderStatusEnum.Pending,
       CustomerId = 3
   }
);

            modelBuilder.Entity<Review>().HasData(
                  new Review
                  {
                      ReviewId = 1,
                      Rating = 5,
                      Comment = "Amazing product, totally worth it!",
                      ReviewDate = DateTime.Now,
                      CustomerId = 1,
                      ProductId = 1
                  },
                  new Review
                  {
                      ReviewId = 2,
                      Rating = 4,
                      Comment = "Good value for money.",
                      ReviewDate = DateTime.Now.AddDays(-10),
                      CustomerId = 2,
                      ProductId = 2
                  }
              );

            modelBuilder.Entity<OrderItem>().HasData(
               new OrderItem
               {
                   OrderItemId = 1,
                   Quantity = 1,
                   UnitPrice = 699.99M,
                   ProductId = 1,
                   OrderId = 1
               },
               new OrderItem
               {
                   OrderItemId = 2,
                   Quantity = 1,
                   UnitPrice = 1299.99M,
                   ProductId = 2,
                   OrderId = 2
               },
                new OrderItem
                {
                    OrderItemId = 3,
                    Quantity = 1,
                    UnitPrice = 138.99M,
                    ProductId = 9,
                    OrderId = 3
                }
           );

            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    PaymentId = 1,
                    PaymentDate = DateTime.Now.AddDays(-6),
                    Amount = 699.99M,
                    PaymentMethod = Payment.PaymentMethodEnum.CreditCard,
                    OrderId = 1
                },
                new Payment
                {
                    PaymentId = 2,
                    PaymentDate = DateTime.Now.AddDays(-4),
                    Amount = 1299.99M,
                    PaymentMethod = Payment.PaymentMethodEnum.PayPal,
                    OrderId = 2
                },
                 new Payment
                 {
                     PaymentId = 3,
                     PaymentDate = DateTime.Now.AddDays(-4),
                     Amount = 138.99M,
                     PaymentMethod = Payment.PaymentMethodEnum.PayPal,
                     OrderId = 3
                 }
            );

            modelBuilder.Entity<ShoppingCart>().HasData(
               new ShoppingCart
               {
                   ShoppingCartId = 1,
                   CreatedDate = DateTime.Now.AddDays(-5),
                   CustomerId = 1 // John's Shopping Cart
               },
               new ShoppingCart
               {
                   ShoppingCartId = 2,
                   CreatedDate = DateTime.Now.AddDays(-3),
                   CustomerId = 2 // Jane's Shopping Cart
               },
               new ShoppingCart
               {
                   ShoppingCartId = 3,
                   CreatedDate = DateTime.Now.AddDays(-3),
                   CustomerId = 3 
               }
           );

            // Seed CartItems
            modelBuilder.Entity<CartItem>().HasData(
                new CartItem
                {
                    CartItemId = 1,
                    Quantity = 2,
                    ProductId = 1, // Smartphone
                    ShoppingCartId = 1 // John's Cart
                },
                new CartItem
                {
                    CartItemId = 2,
                    Quantity = 1,
                    ProductId = 2, // Laptop
                    ShoppingCartId = 2 // Jane's Cart
                },
                new CartItem
                {
                    CartItemId = 3,
                    Quantity = 1,
                    ProductId = 3, 
                    ShoppingCartId = 3 
                }
            );
        }
    }
}
