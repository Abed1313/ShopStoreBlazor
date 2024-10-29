using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Gadgets and electronic devices.", "Electronics" },
                    { 3, "Daily essentials and grocery items.", "Groceries" },
                    { 5, "A wide selection of books and literature.", "Books" },
                    { 6, "Sporting goods and outdoor equipment.", "Sports & Outdoors" },
                    { 7, "Men's and women's fashion clothing.", "Clothing" },
                    { 8, "Appliances for home use.", "Home Appliances" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9506), "Stylish blue denim jeans.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrbTx7GNrW-VEYs2e0NJeeLnTy1Tp1X5jAYw&s", "Jeans", 49.99m, 100 },
                    { 4, 2, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9508), "Casual cotton t-shirt in various colors.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTeNJ8472BMvKR7qF6MR_VebosgHbJ4PeFDA&s", "T-Shirt", 19.99m, 200 },
                    { 7, 4, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9513), "Compact microwave oven for quick meals.", "https://www.ikea.com/sa/en/images/products/vaermd-microwave-oven-ikea-300-black__1337364_pe947844_s5.jpg?f=s", "Microwave Oven", 79.99m, 50 },
                    { 8, 4, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9515), "Powerful vacuum cleaner with HEPA filter.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyAdTTxEvokOw5nJ1f1yKpIDmyF-KEK6cOA&s", "Vacuum Cleaner", 199.99m, 40 },
                    { 2, 1, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9504), "High-performance laptop for work and gaming.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtx2RG7uu8ZNC3OjKHz0-crGiazI5WakIPkw&s", "Laptop", 1299.99m, 30 },
                    { 5, 3, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9509), "Fresh organic apples (1kg).", "https://freshindiaorganics.com/cdn/shop/products/Apples.jpg?v=1686739530", "Organic Apples", 3.99m, 200 },
                    { 6, 3, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9511), "Dairy-free almond milk (1L).", "https://i0.wp.com/stephanieleenutrition.com/wp-content/uploads/2022/06/Untitled-design-8-e1654793763569.png?fit=600%2C401&ssl=1", "Almond Milk", 2.99m, 150 },
                    { 9, 5, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9517), "Classic novel by F. Scott Fitzgerald.", "https://images.penguinrandomhouse.com/cover/9780593311844", "The Great Gatsby", 10.99m, 100 },
                    { 10, 5, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9520), "Dystopian novel by George Orwell.", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1657781256i/61439040.jpg", "1984", 9.99m, 120 },
                    { 11, 6, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9522), "Professional-grade tennis racket.", "https://example.com/images/tennisracket.jpg", "Tennis Racket", 99.99m, 30 },
                    { 12, 6, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9523), "Waterproof 2-person camping tent.", "https://m.media-amazon.com/images/I/71Nao63gy7S.jpg", "Camping Tent", 149.99m, 20 },
                    { 13, 1, new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9500), "Latest model with advanced features.", "https://cdn.thewirecutter.com/wp-content/media/2024/05/smartphone-2048px-1013.jpg?auto=webp&quality=75&width=1024", "Smartphone", 999.99m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
