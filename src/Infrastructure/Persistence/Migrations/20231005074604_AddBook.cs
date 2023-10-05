using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: "3beb9185-70c6-412d-8172-24719aa83a82",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "355fb25e-595a-44fc-8a2e-4c028767be97");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year_published",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 13, 31, 4, 106, DateTimeKind.Local).AddTicks(8665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 12, 57, 19, 922, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Books",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "49fa1188-fbf8-4b6d-ab08-b99c56dbdbaf",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50,
                oldDefaultValue: "479b4528-3b77-4b75-96e1-bea4d41dd7a5");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number", "role" },
                values: new object[,]
                {
                    { "99c41963-ba97-4cdb-a9f6-81e43e6954d7", "gagan@gmail.com", "Gagan", null, null, "Maharjan", "$2a$11$3v2Z49Pc6qiAquxaTTFSru6Bv1ki3/Gte7MNbgC0s0voHiX4xDWR6", "1134567890", 1 },
                    { "b0916300-f9b2-40f0-aeac-2a56707afa2e", "milan@gmail.com", "Milan", null, null, "Maharjan", "$2a$11$t2UUNbnEnoIF.HG.KS95euB1KMc32jP0u5MNK2JQVgNMIgHbiBxNy", "1234567890", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "first_name", "image_path", "image_url", "last_name", "password_hash", "phone_number" },
                values: new object[] { "d88192b5-a229-485b-aa0e-58e27ecd1307", "rajin@gmail.com", "Rajin", null, null, "Maharjan", "$2a$11$fVbekEKZ4lRv9n7VKkK.U.5qTLxdtiQe2sO8G5MQ/J1nxslK8jxw.", "1234567800" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "author", "category", "descriptiion", "image_path", "image_url", "price", "title", "user_id" },
                values: new object[,]
                {
                    { "322e856d-c863-428e-ae14-38f7cf176268", "G", "G", "G", null, "G", 1699.99m, "G", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "509ff7b5-1c9c-4f30-9aa5-c509fd79c70f", "L", "L", "L", null, "L", 2099.99m, "L", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "72bf017c-59ec-45bc-9e2f-c9ebb7684b74", "F", "F", "F", null, "F", 1599.99m, "F", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "88bd37d6-8321-48d2-ac0e-2b312516a3a2", "K", "K", "K", null, "K", 1999.99m, "A", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "abb12092-df60-43b2-9ae5-eacabdacc6f0", "C", "C", "C", null, "C", 1299.99m, "C", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "af075a30-65f8-424e-bd31-d3edb3ef125c", "A", "A", "A", null, "A", 1099.99m, "A", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "c93ddc06-38f1-47ed-bb87-cb79097dda5c", "D", "D", "D", null, "D", 1399.99m, "D", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "c9e6e583-4511-401d-9c5e-eaae78e41f9a", "E", "E", "E", null, "E", 1499.99m, "E", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "e81d6bb8-b7d1-41b3-89c5-68891f109ec0", "I", "I", "I", null, "I", 1799.99m, "I", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "f4ce1f0d-a21a-4a23-9304-ea75110384c7", "J", "J", "J", null, "J", 1899.99m, "J", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "f4d5efc7-1332-44ce-ab26-19ba8e0c0126", "B", "B", "B", null, "B", 1199.99m, "B", "d88192b5-a229-485b-aa0e-58e27ecd1307" },
                    { "f6d3dfc3-4f53-4fae-9da9-57cc29cd7e3a", "H", "H", "H", null, "H", 1699.99m, "H", "d88192b5-a229-485b-aa0e-58e27ecd1307" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "322e856d-c863-428e-ae14-38f7cf176268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "509ff7b5-1c9c-4f30-9aa5-c509fd79c70f");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "72bf017c-59ec-45bc-9e2f-c9ebb7684b74");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "88bd37d6-8321-48d2-ac0e-2b312516a3a2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "abb12092-df60-43b2-9ae5-eacabdacc6f0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "af075a30-65f8-424e-bd31-d3edb3ef125c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "c93ddc06-38f1-47ed-bb87-cb79097dda5c");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "c9e6e583-4511-401d-9c5e-eaae78e41f9a");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "e81d6bb8-b7d1-41b3-89c5-68891f109ec0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "f4ce1f0d-a21a-4a23-9304-ea75110384c7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "f4d5efc7-1332-44ce-ab26-19ba8e0c0126");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "id",
                keyValue: "f6d3dfc3-4f53-4fae-9da9-57cc29cd7e3a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "99c41963-ba97-4cdb-a9f6-81e43e6954d7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "b0916300-f9b2-40f0-aeac-2a56707afa2e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: "d88192b5-a229-485b-aa0e-58e27ecd1307");

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
                oldDefaultValue: "3beb9185-70c6-412d-8172-24719aa83a82");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year_published",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 12, 57, 19, 922, DateTimeKind.Local).AddTicks(8092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 13, 31, 4, 106, DateTimeKind.Local).AddTicks(8665));

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
                oldDefaultValue: "49fa1188-fbf8-4b6d-ab08-b99c56dbdbaf");

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
    }
}
