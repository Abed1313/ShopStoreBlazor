using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Elm Street, Springfield", "johndoe@example.com", "John", "Doe", "hashedpassword123", "555-1234" },
                    { 2, "456 Oak Avenue, Metropolis", "janesmith@example.com", "Jane", "Smith", "hashedpassword456", "555-5678" },
                    { 3, "789 Pine Lane, Gotham", "alicejohnson@example.com", "Alice", "Johnson", "hashedpassword789", "555-9012" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 25, 42, 88, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "OrderStatus", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 21, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(262), 1, 699.99m },
                    { 2, 2, new DateTime(2024, 10, 23, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(282), 0, 1299.99m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CustomerId", "ProductId", "Rating", "ReviewDate" },
                values: new object[,]
                {
                    { 1, "Amazing product, totally worth it!", 1, 1, 5, new DateTime(2024, 10, 28, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(297) },
                    { 2, "Good value for money.", 2, 2, 4, new DateTime(2024, 10, 18, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(299) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 15, 40, 770, DateTimeKind.Utc).AddTicks(9500));
        }
    }
}
