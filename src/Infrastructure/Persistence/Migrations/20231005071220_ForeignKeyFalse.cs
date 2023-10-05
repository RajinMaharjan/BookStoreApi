using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: "355fb25e-595a-44fc-8a2e-4c028767be97",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "fddb809e-accc-4217-9a18-6c03b96d98f9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year_published",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 12, 57, 19, 922, DateTimeKind.Local).AddTicks(8092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 12, 54, 24, 856, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Books",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Books",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "479b4528-3b77-4b75-96e1-bea4d41dd7a5",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "d2a2737f-9e14-4453-b93e-c3cd320db725");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "2ef5743e-9051-40cf-82e0-2ede041e707b", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$XumbAZ4b0lDVxRsOrvvxB.7LjYOL/2sqFsKKeK1tghnENcviLH9nq", "1234567890", 1 },
                    { "9cbbeb26-4da9-4cbd-acf4-3f08adf3f481", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$27WBo/Tbb8.8qcNcmZYAH./TnuhzlgF0lkNy8KEZdEdXAKzb89PpG", "1134567890", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "d5171da9-8577-48ba-bca8-f3c65f238899", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$aZ7zNWrQi3Iu18c0/sa7Du4VfxL1zcNCESiOC5aqSW.Iis/9tFnKe", "1234567800" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "0a649d3d-d754-45ba-ab3c-145516ae3935", "I", "I", "I", null, "I", 1799.99m, "I", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "16016198-1e13-4d5f-9f59-991e05f6432b", "D", "D", "D", null, "D", 1399.99m, "D", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "23a38047-59be-4fed-b6db-d21ae279382f", "J", "J", "J", null, "J", 1899.99m, "J", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "25506d4f-601f-4cc9-b5eb-3940c4197d30", "C", "C", "C", null, "C", 1299.99m, "C", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "2dcefad1-11f7-4ee6-bba5-38ed0cd7abb1", "F", "F", "F", null, "F", 1599.99m, "F", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "4990a3f0-9875-4449-8f72-6d7e2cd3da3e", "E", "E", "E", null, "E", 1499.99m, "E", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "6c022e44-6876-409f-bf76-e1eed092701e", "K", "K", "K", null, "K", 1999.99m, "A", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "9705d3ef-fae6-4270-9de1-f43b0f395da1", "L", "L", "L", null, "L", 2099.99m, "L", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "c37f6594-246f-45ca-a3ac-b01ac032456a", "H", "H", "H", null, "H", 1699.99m, "H", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "ca7daa86-a303-4cb7-829b-f2b527d30cf3", "G", "G", "G", null, "G", 1699.99m, "G", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "ce87b71a-bc47-4620-be4f-055298c10a23", "B", "B", "B", null, "B", 1199.99m, "B", "d5171da9-8577-48ba-bca8-f3c65f238899" },
                    { "fdb905a7-2330-4e78-ad67-be4299dd6ab0", "A", "A", "A", null, "A", 1099.99m, "A", "d5171da9-8577-48ba-bca8-f3c65f238899" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "0a649d3d-d754-45ba-ab3c-145516ae3935");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "16016198-1e13-4d5f-9f59-991e05f6432b");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "23a38047-59be-4fed-b6db-d21ae279382f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "25506d4f-601f-4cc9-b5eb-3940c4197d30");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "2dcefad1-11f7-4ee6-bba5-38ed0cd7abb1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "4990a3f0-9875-4449-8f72-6d7e2cd3da3e");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "6c022e44-6876-409f-bf76-e1eed092701e");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "9705d3ef-fae6-4270-9de1-f43b0f395da1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "c37f6594-246f-45ca-a3ac-b01ac032456a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "ca7daa86-a303-4cb7-829b-f2b527d30cf3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "ce87b71a-bc47-4620-be4f-055298c10a23");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "fdb905a7-2330-4e78-ad67-be4299dd6ab0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "2ef5743e-9051-40cf-82e0-2ede041e707b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "9cbbeb26-4da9-4cbd-acf4-3f08adf3f481");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "d5171da9-8577-48ba-bca8-f3c65f238899");

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
                oldDefaultValue: "355fb25e-595a-44fc-8a2e-4c028767be97");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year_published",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 12, 54, 24, 856, DateTimeKind.Local).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 12, 57, 19, 922, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Books",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldNullable: true);

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
                oldDefaultValue: "479b4528-3b77-4b75-96e1-bea4d41dd7a5");

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
    }
}
