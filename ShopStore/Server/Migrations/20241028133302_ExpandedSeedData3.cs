using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedSeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 699.99m },
                    { 2, 2, 2, 1, 1299.99m }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 21, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 23, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "OrderStatus", "TotalAmount" },
                values: new object[] { 3, 3, new DateTime(2024, 10, 23, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7364), 0, 138.99m });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "OrderId", "PaymentDate", "PaymentMethod" },
                values: new object[,]
                {
                    { 1, 699.99m, 1, new DateTime(2024, 10, 22, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7413), 0 },
                    { 2, 1299.99m, 2, new DateTime(2024, 10, 24, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7416), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 33, 2, 415, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 10, 28, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 10, 18, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { 3, 3, 9, 1, 138.99m });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "OrderId", "PaymentDate", "PaymentMethod" },
                values: new object[] { 3, 138.99m, 3, new DateTime(2024, 10, 24, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7418), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 21, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 23, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(282));

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 10, 28, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 10, 18, 16, 25, 42, 88, DateTimeKind.Local).AddTicks(299));
        }
    }
}
