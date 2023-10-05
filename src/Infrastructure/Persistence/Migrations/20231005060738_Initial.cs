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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "931bb6b6-87a4-4f80-bfca-60591759285c"),
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
                    id = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false, defaultValue: "f0d6a190-05a2-4085-8929-2a312443fa22"),
                    title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    category = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    author = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    year_published = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 5, 11, 52, 37, 555, DateTimeKind.Local).AddTicks(6901)),
                    price = table.Column<decimal>(type: "DECIMAL(18,2)", maxLength: 20, nullable: false),
                    image_url = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    image_path = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
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
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "8dd32fbf-92b7-4b29-a30c-0a7254f16d72", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$Sf8b4uEHgZrKNEpVxj0IbOfo70/FX.7fYXkr.xo5v4EY572ruclee", "1234567890", 1 },
                    { "b675ffb6-daf4-40a3-a3ac-7f302a71aa74", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$bXX35GrOY2tBo4l4uqe2POVirQCGs9iIAM.cGlS0chfJyoQ.VzCGG", "1134567890", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "d222ada2-499c-43c0-aa2c-ef1bf39476b6", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$8PhSWn/cFgy7N1hno67kJu78ZgsfTYd4L7nehUzupNQSLeNJUd5wu", "1234567800" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "00c279cf-5173-4a6a-97fc-93c51b85857c", "C", "C", "C", null, "C", 1299.99m, "C", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "5518b997-132f-4769-b2a1-0aae0f4e733c", "E", "E", "E", null, "E", 1499.99m, "E", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "56f21411-7496-4693-b8f6-883ee047e74c", "D", "D", "D", null, "D", 1399.99m, "D", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "61469db1-8293-4168-b3c3-61f7fd10785a", "L", "L", "L", null, "L", 2099.99m, "L", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "8ed32fe0-0a99-4c76-a9ac-bd39d6e25e8a", "G", "G", "G", null, "G", 1699.99m, "G", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "a71dcb36-c947-483d-a1da-6e702fb9241c", "H", "H", "H", null, "H", 1699.99m, "H", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "ba9f483f-a893-4b13-a28c-9f82b26a0e5b", "F", "F", "F", null, "F", 1599.99m, "F", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "c239e5a5-ae47-42fb-95fd-c4dbe142dad9", "B", "B", "B", null, "B", 1199.99m, "B", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "c5896581-8ea6-4932-83b0-824a96a8b0e2", "I", "I", "I", null, "I", 1799.99m, "I", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "d0ad21fc-3d77-4988-bd99-304ad8be8657", "K", "K", "K", null, "K", 1999.99m, "A", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "d27d7f30-c4c9-4df6-8ee8-a0290806e53f", "J", "J", "J", null, "J", 1899.99m, "J", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" },
                    { "f79b9703-1379-45cc-af39-35c310a7a9a6", "A", "A", "A", null, "A", 1099.99m, "A", "d222ada2-499c-43c0-aa2c-ef1bf39476b6" }
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
