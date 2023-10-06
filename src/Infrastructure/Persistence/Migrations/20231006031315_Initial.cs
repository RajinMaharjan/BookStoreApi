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
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "fa618f5f-591a-48a3-881d-54735eb8da2f")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password_hash = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "VARCHAR(10)", fixedLength: true, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_deleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    role = table.Column<int>(type: "INT", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "1caa618d-cc22-4703-b560-b4ff969d132a")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    year_published = table.Column<DateTime>(type: "datetime(6)", nullable: true, defaultValue: new DateTime(2023, 10, 6, 8, 58, 15, 144, DateTimeKind.Local).AddTicks(2024)),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptiion = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    available = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    user_id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                    table.ForeignKey(
                        name: "FK_Books_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[] { "5c487efd-b1e8-4788-a40b-9905302826c5", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$Kdsuyx06lTRANKzFLoN3deiYGNrEPFGPnmeTRl.PU0exFEVN.c6PS", "1234567890", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$h/WiWa6.ZC4doFiBft0eb.WSTTGEjUSdKUOj55zvSJ8dlohqDIbZe", "1234567800" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[] { "f13db9e8-1bb3-4db1-81a6-ec7d82af270d", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$TvYGU/OlaTvib9AvmgXAXeD.KM95SiZ0hieNXtjyaFmF1trTtlhvq", "1134567890", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "2803e963-2bf7-44d4-a9a0-e5635781ed08", "I", "I", "I", null, "I", 1799.99m, "I", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "34f5bfb9-d8c6-4ed1-a64d-17eaf37ea5df", "B", "B", "B", null, "B", 1199.99m, "B", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "7921cb2d-a323-46f8-a926-23d98887e652", "J", "J", "J", null, "J", 1899.99m, "J", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "7af21cea-7ce5-4f39-96d2-51f76e7478ee", "C", "C", "C", null, "C", 1299.99m, "C", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "898c6781-6c37-4e11-817c-28ea838ee323", "G", "G", "G", null, "G", 1699.99m, "G", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "a4203c62-1dc8-451a-96b7-9f937cec1a25", "F", "F", "F", null, "F", 1599.99m, "F", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "ae6527d3-6f37-4152-848b-0c0fbb49f11e", "E", "E", "E", null, "E", 1499.99m, "E", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "b821d092-350b-4ec9-adb7-168c86856e29", "D", "D", "D", null, "D", 1399.99m, "D", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "c1971480-5af6-4519-b921-6114abce9d83", "K", "K", "K", null, "K", 1999.99m, "A", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "d5293663-8d03-41f8-a244-5a08a67bfc6f", "H", "H", "H", null, "H", 1699.99m, "H", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "dce568c1-c379-4c86-a004-fa3b3de8fb1f", "A", "A", "A", null, "A", 1099.99m, "A", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" },
                    { "f77d35fc-4cf5-4eda-bc83-2868afe966e4", "L", "L", "L", null, "L", 2099.99m, "L", "87ac6167-355b-4ac8-ba4e-6f0e9a7e5f5f" }
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
