using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Descupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "5ef3a45d-2729-4d4f-b50e-490312094e03"),
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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "d278f43f-6157-4f71-9eaa-d775f9162f31"),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    year_published = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    descriptiion = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
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
                values: new object[] { "26aae3fc-596f-42da-bdb6-f1f266ef127a", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$7H6tBd8/SKM9ph32/BnnzOjle6F7j1elEnDnRkfwZfBxB8WRgFiu.", "1234567800" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "2cb167d6-fb93-4088-b993-6f24d4e735d0", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$cdpEy6z8shN2aBE4aZ2S8Oi2S1by78fgMqAdBPwEZNqZRjzHmBV5S", "1234567890", 1 },
                    { "60ca2526-2ef7-429c-a0cb-7d684a876a88", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$eT7L1653gRyhjYANt8opEeM0QHx0/MsDzNJB/PtHNxxM.FncIvOK6", "1134567890", 1 }
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
