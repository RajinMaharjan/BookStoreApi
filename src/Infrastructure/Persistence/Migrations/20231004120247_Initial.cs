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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "c40f27f2-397d-49d3-bd58-6aa6eb314fb1")
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
                    year_published = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 4, 17, 47, 47, 294, DateTimeKind.Local).AddTicks(6610)),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true)
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
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "0356f693-8ab8-4601-ad34-aa52421f6a7f", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$8zTnftA1sMlEpc2tvZu6guY80E.8QpHKyTF1lcJzGoGL/FY.U408G", "1134567890", 1 },
                    { "56a5bee1-84e4-47b3-a4c3-886bd38400bb", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$3vHk31fT/UdBX9C8okAU9eTty4GnBlu9PhHLcxoS2x3QErXAT..By", "1234567890", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "c1586376-7a4e-4e10-9253-6b56c346e984", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$l03/TPZjs4dWKrFoqPQQKujRAlxpP9dKmAPR5nMVdlqmJ0j2QVugO", "1234567800" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "05572c6d-29cf-456d-ab2e-6bb13fff7e24", "K", "K", "K", null, "K", 1999.99m, "A", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "205845cb-cf25-4d01-bdcc-c5e51ea48272", "B", "B", "B", null, "B", 1199.99m, "B", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "262f6a1b-7814-46dd-a563-66d0464fbb78", "F", "F", "F", null, "F", 1599.99m, "F", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "49e108fb-d9c0-435e-b017-59cde4330770", "H", "H", "H", null, "H", 1699.99m, "H", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "7c8d313c-3017-40cd-b52f-9805169b1ee0", "C", "C", "C", null, "C", 1299.99m, "C", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "a46f6e16-c413-4318-84a7-acab60e05c3e", "D", "D", "D", null, "D", 1399.99m, "D", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "b566183c-5d44-4a94-8b39-9c34eae685df", "J", "J", "J", null, "J", 1899.99m, "J", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "b8e454a8-7fb9-4843-bbe8-c538b03a70f6", "L", "L", "L", null, "L", 2099.99m, "L", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "cc3fcb7d-0d6f-4ecd-b4db-7e44696a3272", "I", "I", "I", null, "I", 1799.99m, "I", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "cfacbbfb-f079-41f8-9cc6-894d6db3d1d1", "E", "E", "E", null, "E", 1499.99m, "E", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "d54bbe51-be6c-4c7f-b2a6-3bff99084adf", "G", "G", "G", null, "G", 1699.99m, "G", "c1586376-7a4e-4e10-9253-6b56c346e984" },
                    { "e116bac5-4e60-4382-834c-78f55b3b730c", "A", "A", "A", null, "A", 1099.99m, "A", "c1586376-7a4e-4e10-9253-6b56c346e984" }
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
