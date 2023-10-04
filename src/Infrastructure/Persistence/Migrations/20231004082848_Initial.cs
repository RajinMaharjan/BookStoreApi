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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "de9efe78-d9c5-41d2-a165-4d9845b3b83c")
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
                    photo_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    year_published = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 4, 14, 13, 47, 727, DateTimeKind.Local).AddTicks(6143)),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descriptiion = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    available = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    user_id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
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
                columns: new[] { "id", "email", "first_name", "last_name", "password_hash", "phone_number", "photo_url", "role" },
                values: new object[] { "78cc59f6-1b45-4328-8806-6db4a50cc6f9", "milan@gmail.com", "Milan", "Maharjan", "$2a$11$F7F0aXLrpRv/JdNlDgC8o.D5x6vV2BeqaFQS8fOyc87k.xaOxpH.2", "1234567890", null, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "last_name", "password_hash", "phone_number", "photo_url" },
                values: new object[] { "981809c0-731c-4cd7-b299-aefc180327b2", "rajin@gmail.com", "Rajin", "Maharjan", "$2a$11$qKAxgJdTB.o2v/97rouqGerHfghW0vsVHVqhxNql3mO7gXq2MtXNK", "1234567800", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "last_name", "password_hash", "phone_number", "photo_url", "role" },
                values: new object[] { "c8d90c90-c9f5-4feb-bfb2-68d24c9c2587", "gagan@gmail.com", "Gagan", "Maharjan", "$2a$11$sEQsJVfFUUawWSGye.mBUepCpqpaeUKlfgtB5S7GOVkJPaiJA5p9m", "1134567890", null, 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "022837c7-081c-43fe-9d36-90686e5876e0", "D", "D", "D", "D", 1399.99m, "D", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "20d5ac09-3563-4ab7-8cd3-178afba7b8d4", "K", "K", "K", "K", 1999.99m, "A", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "521319ca-63a7-4172-918b-b24ce2c02db7", "I", "I", "I", "I", 1799.99m, "I", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "5f3f6522-a658-4026-86f9-66d2fd5e0130", "H", "H", "H", "H", 1699.99m, "H", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "6f661180-0429-4999-87d3-148f3c0eec4e", "J", "J", "J", "J", 1899.99m, "J", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "8075f240-9e21-4705-964a-32a3c20b7ce0", "G", "G", "G", "G", 1699.99m, "G", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "84fc41dd-48f0-4d1e-a3a2-eb4e13611bb7", "A", "A", "A", "A", 1099.99m, "A", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "b0a4e258-c9dc-49f7-86d1-783b08f854c5", "C", "C", "C", "C", 1299.99m, "C", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "bba88591-3c2a-4356-9b03-75a6d0018aed", "F", "F", "F", "F", 1599.99m, "F", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "d7884635-5a9e-4913-a4c9-f55e9a6dd8dc", "B", "B", "B", "B", 1199.99m, "B", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "f008b8b3-9603-4fa0-bf74-de98bc97545c", "L", "L", "L", "L", 2099.99m, "L", "981809c0-731c-4cd7-b299-aefc180327b2" },
                    { "f6882e8a-57b3-49d6-858a-b3e647a92232", "E", "E", "E", "E", 1499.99m, "E", "981809c0-731c-4cd7-b299-aefc180327b2" }
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
