﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopStore.Server;

#nullable disable

namespace ShopStore.Server.Migrations
{
    [DbContext(typeof(ShpoSDbContext))]
    [Migration("20241028133302_ExpandedSeedData3")]
    partial class ExpandedSeedData3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopStore.Shared.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Gadgets and electronic devices.",
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description = "Men's and women's fashion clothing.",
                            Name = "Clothing"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Daily essentials and grocery items.",
                            Name = "Groceries"
                        },
                        new
                        {
                            CategoryId = 8,
                            Description = "Appliances for home use.",
                            Name = "Home Appliances"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "A wide selection of books and literature.",
                            Name = "Books"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Sporting goods and outdoor equipment.",
                            Name = "Sports & Outdoors"
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Elm Street, Springfield",
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PasswordHash = "hashedpassword123",
                            PhoneNumber = "555-1234"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "456 Oak Avenue, Metropolis",
                            Email = "janesmith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PasswordHash = "hashedpassword456",
                            PhoneNumber = "555-5678"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "789 Pine Lane, Gotham",
                            Email = "alicejohnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            PasswordHash = "hashedpassword789",
                            PhoneNumber = "555-9012"
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2024, 10, 21, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7343),
                            OrderStatus = 1,
                            TotalAmount = 699.99m
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerId = 2,
                            OrderDate = new DateTime(2024, 10, 23, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7362),
                            OrderStatus = 0,
                            TotalAmount = 1299.99m
                        },
                        new
                        {
                            OrderId = 3,
                            CustomerId = 3,
                            OrderDate = new DateTime(2024, 10, 23, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7364),
                            OrderStatus = 0,
                            TotalAmount = 138.99m
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 1,
                            UnitPrice = 699.99m
                        },
                        new
                        {
                            OrderItemId = 2,
                            OrderId = 2,
                            ProductId = 2,
                            Quantity = 1,
                            UnitPrice = 1299.99m
                        },
                        new
                        {
                            OrderItemId = 3,
                            OrderId = 3,
                            ProductId = 9,
                            Quantity = 1,
                            UnitPrice = 138.99m
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            Amount = 699.99m,
                            OrderId = 1,
                            PaymentDate = new DateTime(2024, 10, 22, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7413),
                            PaymentMethod = 0
                        },
                        new
                        {
                            PaymentId = 2,
                            Amount = 1299.99m,
                            OrderId = 2,
                            PaymentDate = new DateTime(2024, 10, 24, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7416),
                            PaymentMethod = 1
                        },
                        new
                        {
                            PaymentId = 3,
                            Amount = 138.99m,
                            OrderId = 3,
                            PaymentDate = new DateTime(2024, 10, 24, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7418),
                            PaymentMethod = 1
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 13,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7246),
                            Description = "Latest model with advanced features.",
                            ImageUrl = "https://cdn.thewirecutter.com/wp-content/media/2024/05/smartphone-2048px-1013.jpg?auto=webp&quality=75&width=1024",
                            Name = "Smartphone",
                            Price = 999.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7249),
                            Description = "High-performance laptop for work and gaming.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtx2RG7uu8ZNC3OjKHz0-crGiazI5WakIPkw&s",
                            Name = "Laptop",
                            Price = 1299.99m,
                            StockQuantity = 30
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7251),
                            Description = "Stylish blue denim jeans.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrbTx7GNrW-VEYs2e0NJeeLnTy1Tp1X5jAYw&s",
                            Name = "Jeans",
                            Price = 49.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7253),
                            Description = "Casual cotton t-shirt in various colors.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTeNJ8472BMvKR7qF6MR_VebosgHbJ4PeFDA&s",
                            Name = "T-Shirt",
                            Price = 19.99m,
                            StockQuantity = 200
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7255),
                            Description = "Fresh organic apples (1kg).",
                            ImageUrl = "https://freshindiaorganics.com/cdn/shop/products/Apples.jpg?v=1686739530",
                            Name = "Organic Apples",
                            Price = 3.99m,
                            StockQuantity = 200
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7256),
                            Description = "Dairy-free almond milk (1L).",
                            ImageUrl = "https://i0.wp.com/stephanieleenutrition.com/wp-content/uploads/2022/06/Untitled-design-8-e1654793763569.png?fit=600%2C401&ssl=1",
                            Name = "Almond Milk",
                            Price = 2.99m,
                            StockQuantity = 150
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7258),
                            Description = "Compact microwave oven for quick meals.",
                            ImageUrl = "https://www.ikea.com/sa/en/images/products/vaermd-microwave-oven-ikea-300-black__1337364_pe947844_s5.jpg?f=s",
                            Name = "Microwave Oven",
                            Price = 79.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7260),
                            Description = "Powerful vacuum cleaner with HEPA filter.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyAdTTxEvokOw5nJ1f1yKpIDmyF-KEK6cOA&s",
                            Name = "Vacuum Cleaner",
                            Price = 199.99m,
                            StockQuantity = 40
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7262),
                            Description = "Classic novel by F. Scott Fitzgerald.",
                            ImageUrl = "https://images.penguinrandomhouse.com/cover/9780593311844",
                            Name = "The Great Gatsby",
                            Price = 10.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7300),
                            Description = "Dystopian novel by George Orwell.",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1657781256i/61439040.jpg",
                            Name = "1984",
                            Price = 9.99m,
                            StockQuantity = 120
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 6,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7302),
                            Description = "Professional-grade tennis racket.",
                            ImageUrl = "https://example.com/images/tennisracket.jpg",
                            Name = "Tennis Racket",
                            Price = 99.99m,
                            StockQuantity = 30
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 6,
                            CreatedDate = new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7304),
                            Description = "Waterproof 2-person camping tent.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71Nao63gy7S.jpg",
                            Name = "Camping Tent",
                            Price = 149.99m,
                            StockQuantity = 20
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Comment = "Amazing product, totally worth it!",
                            CustomerId = 1,
                            ProductId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2024, 10, 28, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7381)
                        },
                        new
                        {
                            ReviewId = 2,
                            Comment = "Good value for money.",
                            CustomerId = 2,
                            ProductId = 2,
                            Rating = 4,
                            ReviewDate = new DateTime(2024, 10, 18, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7384)
                        });
                });

            modelBuilder.Entity("ShopStore.Shared.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.CartItem", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ShopStore.Shared.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("CartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Order", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.OrderItem", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopStore.Shared.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Payment", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Product", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Review", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Customer", "Customer")
                        .WithMany("reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopStore.Shared.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.ShoppingCart", b =>
                {
                    b.HasOne("ShopStore.Shared.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("reviews");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ShopStore.Shared.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
