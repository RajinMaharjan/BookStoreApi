using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "618818ee-0628-47fe-901f-935d6216dcf8"),
                    first_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    password_hash = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    phone_number = table.Column<string>(type: "VARCHAR(10)", fixedLength: true, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    role = table.Column<int>(type: "INT", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "9cfd253a-ebe8-4ccc-95e8-b4f012f43ff1"),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    year_published = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 10, 7, 16, 54, 40, 593, DateTimeKind.Local).AddTicks(6113)),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    descriptiion = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    available = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    user_id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                    table.ForeignKey(
                        name: "FK_Books_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$CldF2Gc/DmMzS5UIhNMIYu47mwxzh7cxn.vqcncDmSaTLdCnJ6E06", "1234567800" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "55abb6ef-e9b9-4b70-bb75-0cdbbc8605c3", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$oCt68LcWfW2EOQK/cbTT3.NZqQJWniuYUU9zfs9JyAR2U8y1Mok92", "1134567890", 1 },
                    { "88c58619-59b5-4709-8612-9e23b1da8281", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$fytESG5Ng9kqwYF5iXEcJu/9LD8OmxON4EaBvojVrVmDUl10E59JS", "1234567890", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "002ab839-9690-4b6f-9d4c-12592635078c", "B", "B", "B", null, "B", 1199.99m, "B", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "10447bc1-efab-4471-8d19-b81f9bb431cd", "H", "H", "H", null, "H", 1699.99m, "H", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "1a43810a-8d87-428c-8435-e730c34f4156", "K", "K", "K", null, "K", 1999.99m, "A", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "4d68b11f-1295-458a-b391-65e5a23cd6ee", "F", "F", "F", null, "F", 1599.99m, "F", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "81e30fad-21a7-4b98-b56e-1a0a45debb7f", "J", "J", "J", null, "J", 1899.99m, "J", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "8eae9518-7d32-4d32-ad98-0043c7893d05", "G", "G", "G", null, "G", 1699.99m, "G", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "a03ab336-e9f5-4f1c-8130-2e0597e96883", "L", "L", "L", null, "L", 2099.99m, "L", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "b89ab5c2-3ad5-48b4-a2b6-b38c284e790b", "C", "C", "C", null, "C", 1299.99m, "C", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "c1282db4-fa3d-4631-87bc-e98586cfe7b2", "I", "I", "I", null, "I", 1799.99m, "I", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "cfc4ffd5-a816-4ed1-818b-81a165eb82e9", "E", "E", "E", null, "E", 1499.99m, "E", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "d87ca85f-fa40-455e-b7a1-1f6156a029f4", "D", "D", "D", null, "D", 1399.99m, "D", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" },
                    { "e26b7b16-977c-4424-91ae-6af9b44441f7", "A", "A", "A", null, "A", 1099.99m, "A", "2a97ed85-d217-4aba-9b5e-6d1e6cc2239b" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_user_id",
                table: "Books",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
