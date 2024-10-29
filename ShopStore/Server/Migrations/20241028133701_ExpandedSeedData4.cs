using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedSeedData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 21, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 23, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 23, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 22, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 24, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 24, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 28, 13, 37, 1, 643, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 10, 28, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 10, 18, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "ShoppingCartId", "CreatedDate", "CustomerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4361), 1 },
                    { 2, new DateTime(2024, 10, 25, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4363), 2 },
                    { 3, new DateTime(2024, 10, 25, 16, 37, 1, 643, DateTimeKind.Local).AddTicks(4364), 3 }
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "CartItemId", "ProductId", "Quantity", "ShoppingCartId" },
                values: new object[,]
                {
                    { 1, 1, 2, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 3, 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "ShoppingCartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "ShoppingCartId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "ShoppingCartId",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 23, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 22, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 24, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 24, 16, 33, 2, 415, DateTimeKind.Local).AddTicks(7418));

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
        }
    }
}
