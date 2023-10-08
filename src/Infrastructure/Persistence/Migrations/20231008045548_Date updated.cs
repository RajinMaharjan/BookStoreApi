using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Dateupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "46ed2534-3def-4da2-8442-76dea05c8cc7"),
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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "156352c2-2ec0-4701-bbed-63a1fc55e18f"),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    year_published = table.Column<DateTime>(type: "DATETIME", nullable: false),
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
                values: new object[] { "000c040c-715e-4f67-a584-ac379ca1fa78", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$tD4C3RT0oQL7vk7kXKcaa.BIBRxOSGI0z9YBshQTvGEIQ65IQqny2", "1234567800" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "7f0670c9-4d43-475a-9f7d-d75d07836f3d", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$9RYzVIkgnkHFQxUaF/CvLu12nbZOp4YmSdztQkBNqy1i8h9c7M36G", "1134567890", 1 },
                    { "c988bb0a-8bf8-4c4a-ad2b-55457f27d754", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$IfCiwHrwbqub/rdaDdycu.p8xtXhyAymzYdQ31gHi38qwU6jyIaYq", "1234567890", 1 }
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
