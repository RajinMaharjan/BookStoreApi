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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    first_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    password_hash = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    phone_number = table.Column<string>(type: "VARCHAR(10)", fixedLength: true, nullable: false),
                    photo_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    role = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    year_published = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 3, 10, 46, 14, 566, DateTimeKind.Local).AddTicks(6373)),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    descriptiion = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    available = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    user_id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
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
                columns: new[] { "id", "email", "first_name", "last_name", "password_hash", "phone_number", "photo_url", "role" },
                values: new object[,]
                {
                    { "021bd58d-0270-418e-b8cf-654696f11b36", "gagan@gmail.com", "Gagan", "Maharjan", "G@g12345", "1134567890", null, 1 },
                    { "626c7270-febc-4c38-9ccb-d44d7c8ef98f", "rajin@gmail.com", "Rajin", "Maharjan", "R@r12345", "1234567800", null, 0 },
                    { "80b3153b-ed07-4e70-8694-f297dad8b854", "milann@gmail.com", "Milan", "Maharjan", "M@m12345", "1234567890", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "1aa96689-8c8d-4946-8914-f299503cb32e", "I", "I", "I", "I", 1799.99m, "I", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "229b0fdc-24de-41f9-9176-dd56f359abd0", "G", "G", "G", "G", 1699.99m, "G", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "26f7f428-2b9f-4c90-9f3d-812e73b086ad", "C", "C", "C", "C", 1299.99m, "C", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "55cd5d1f-a9c5-4fb4-80eb-028b7a336517", "E", "E", "E", "E", 1499.99m, "E", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "65d9a9cd-0692-42a6-b436-cee0040eabbb", "F", "F", "F", "F", 1599.99m, "F", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "759fcdea-2762-439c-ac11-8304429f2c40", "K", "K", "K", "K", 1999.99m, "A", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "762cef45-40b2-4ff7-9914-5f0462afa6ec", "J", "J", "J", "J", 1899.99m, "J", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "8b1e26b2-4ce5-48d1-b4e0-9f5dceda9987", "B", "B", "B", "B", 1199.99m, "B", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "aa72953e-9847-485c-b958-1862b690e7ab", "L", "L", "L", "L", 2099.99m, "L", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "cbf9a973-7826-48a2-93d3-f1ba0fefe4d7", "A", "A", "A", "A", 1099.99m, "A", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "d571b4f2-f4a3-47b3-ac53-91dc7e16b90e", "H", "H", "H", "H", 1699.99m, "H", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" },
                    { "fc8765f3-99ba-4bab-b9dc-331d5e66a3b0", "D", "D", "D", "D", 1399.99m, "D", "626c7270-febc-4c38-9ccb-d44d7c8ef98f" }
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
