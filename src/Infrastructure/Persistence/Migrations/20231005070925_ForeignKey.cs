using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "00c279cf-5173-4a6a-97fc-93c51b85857c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "5518b997-132f-4769-b2a1-0aae0f4e733c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "56f21411-7496-4693-b8f6-883ee047e74c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "61469db1-8293-4168-b3c3-61f7fd10785a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "8ed32fe0-0a99-4c76-a9ac-bd39d6e25e8a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "a71dcb36-c947-483d-a1da-6e702fb9241c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "ba9f483f-a893-4b13-a28c-9f82b26a0e5b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "c239e5a5-ae47-42fb-95fd-c4dbe142dad9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "c5896581-8ea6-4932-83b0-824a96a8b0e2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "d0ad21fc-3d77-4988-bd99-304ad8be8657");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "d27d7f30-c4c9-4df6-8ee8-a0290806e53f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "f79b9703-1379-45cc-af39-35c310a7a9a6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "8dd32fbf-92b7-4b29-a30c-0a7254f16d72");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "b675ffb6-daf4-40a3-a3ac-7f302a71aa74");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "d222ada2-499c-43c0-aa2c-ef1bf39476b6");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Users",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "fddb809e-accc-4217-9a18-6c03b96d98f9",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "931bb6b6-87a4-4f80-bfca-60591759285c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year_published",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 12, 54, 24, 856, DateTimeKind.Local).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 11, 52, 37, 555, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Books",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "d2a2737f-9e14-4453-b93e-c3cd320db725",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "f0d6a190-05a2-4085-8929-2a312443fa22");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "36377e96-958b-48d8-89ba-478a0601ccf8", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$uqV/qDAIaLNBOxb2St/qNejFqbnQpM.SaZ1GBeP.KIVkjqM.wBLBe", "1134567890", 1 },
                    { "39a62334-17fb-4448-8559-84091f9a6a62", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$kiQP5CvGGqdj4MOcbYz1r.EL1HK316YzVl7wBE3lVURzu4nKWBasa", "1234567890", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "b3e5e152-374e-414f-9f75-96f05054e2bf", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$OWUqpx1y/p85PCTN4sFxvu.g8pSe99hiZdQDAI/./UcLidYyi1lM2", "1234567800" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "0359efac-13a2-44c4-b0ce-d10710e5c67a", "A", "A", "A", null, "A", 1099.99m, "A", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "0c29bee6-7e1d-44a9-940a-726de338755a", "K", "K", "K", null, "K", 1999.99m, "A", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "57268c9d-882b-4fc8-b954-b92cc614d51f", "C", "C", "C", null, "C", 1299.99m, "C", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "68a8504a-ecf1-47a6-af43-2c9c54410f25", "F", "F", "F", null, "F", 1599.99m, "F", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "737b2b47-9229-4a60-bc81-b69dc7ff1c31", "I", "I", "I", null, "I", 1799.99m, "I", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "7c05607f-b2d6-4fef-b5da-f76178a84b7c", "H", "H", "H", null, "H", 1699.99m, "H", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "8683599c-b776-42b4-a04a-7f25a493e9a1", "D", "D", "D", null, "D", 1399.99m, "D", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "88d710ba-9f00-451f-80a5-e84ecb19f92d", "B", "B", "B", null, "B", 1199.99m, "B", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "b1add67b-516b-4ea4-8f23-ea1de0b005ff", "J", "J", "J", null, "J", 1899.99m, "J", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "ebc17f3b-8773-458e-bf3b-119ee1bded80", "E", "E", "E", null, "E", 1499.99m, "E", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "ee4d8f97-8416-49ae-8e46-4db8271dc78d", "G", "G", "G", null, "G", 1699.99m, "G", "b3e5e152-374e-414f-9f75-96f05054e2bf" },
                    { "f462be9e-ef3d-46b8-93bf-235c467248cc", "L", "L", "L", null, "L", 2099.99m, "L", "b3e5e152-374e-414f-9f75-96f05054e2bf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "0359efac-13a2-44c4-b0ce-d10710e5c67a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "0c29bee6-7e1d-44a9-940a-726de338755a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "57268c9d-882b-4fc8-b954-b92cc614d51f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "68a8504a-ecf1-47a6-af43-2c9c54410f25");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "737b2b47-9229-4a60-bc81-b69dc7ff1c31");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "7c05607f-b2d6-4fef-b5da-f76178a84b7c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "8683599c-b776-42b4-a04a-7f25a493e9a1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "88d710ba-9f00-451f-80a5-e84ecb19f92d");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "b1add67b-516b-4ea4-8f23-ea1de0b005ff");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "ebc17f3b-8773-458e-bf3b-119ee1bded80");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "ee4d8f97-8416-49ae-8e46-4db8271dc78d");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "f462be9e-ef3d-46b8-93bf-235c467248cc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "36377e96-958b-48d8-89ba-478a0601ccf8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "39a62334-17fb-4448-8559-84091f9a6a62");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "b3e5e152-374e-414f-9f75-96f05054e2bf");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Users",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "931bb6b6-87a4-4f80-bfca-60591759285c",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "fddb809e-accc-4217-9a18-6c03b96d98f9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year_published",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 11, 52, 37, 555, DateTimeKind.Local).AddTicks(6901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 12, 54, 24, 856, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Books",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "f0d6a190-05a2-4085-8929-2a312443fa22",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "d2a2737f-9e14-4453-b93e-c3cd320db725");

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
        }
    }
}
