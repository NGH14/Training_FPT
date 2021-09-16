using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updaterole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "1124755a-5215-4c8b-b120-0b209b730f6b", "Training Analyst role", "Training Analyst", "Training Analyst" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "8e044f5e-6d87-4db6-afeb-e2c5e59bf751", "FPT Staff role", "FPT Staff", "FPT Staff" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "84bf8ce6-9ab7-49ea-9fa7-48d47201a237");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33f0795d-cb64-4226-b293-192a38e75f17", "AQAAAAEAACcQAAAAEGgeoDd/zWuGxBiPrGL83W/koh6rtXWOmy+4YWq5yZdxpweEf8AO+gP1DKUBQM/WTQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55bd3250-178a-48b0-8abe-f4dec9de83fb", "AQAAAAEAACcQAAAAEFadOuilH4mQ+n5lqCjQzXACh4sYH2u1534Z5mvIsH+fy+2LW7dd8OBNuwya9qQD8Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de4ecb13-5024-4007-a9d0-caba304c2af8", "AQAAAAEAACcQAAAAEO2ZSiWKLvFOxGBLekUkTx3l3exgpQzpFmy5fgq0E03w2cMdnxKKm5Wu9E1Zqd4IXg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a039249e-350b-427e-a3db-bf84adfdd62d", "AQAAAAEAACcQAAAAEJ30SaMtdFc7PeQCz9nMs9TTPliX4E+li4/HhK/NrGNo0ZqPthwcWZ4rTFqBa8PR2Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 14, 22, 55, 1, 413, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 14, 22, 55, 1, 417, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 14, 22, 55, 1, 417, DateTimeKind.Local).AddTicks(1169));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "4a6feda0-1db6-4ed0-bd88-f023eca6848a", "Trainer role", "Trainer", "Trainer" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "db36ddcd-d735-4b26-96dd-b86c560f5773", "Trainee role", "Trainee", "Trainee" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "de463d95-0484-4ae2-951c-ad2a8947f9b4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80d20341-5827-441a-9e69-9401c9ac34d7", "AQAAAAEAACcQAAAAEJ0zb4NqUdNE//bk/ePJt5q1KZwSKy1aIe+SZHssa4XxnGSpPGbXf5jDAZE3ThTajA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7e0cfbc-a4da-4b5d-8514-1c86be754c88", "AQAAAAEAACcQAAAAEIpoaexQ+eWjcvKeC4mIe3STaU6q6GvfV2dHbK/xZlhTEpFXuihbk4qQplAv0OcN+w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "440b3f43-75dc-4d2d-91f2-cd538b1f8e0b", "AQAAAAEAACcQAAAAEHTJddDGtSRQ2emti5OyCI6ApdoKnu/SojnICj+uUoPnykEBsXPlFTQf5sTFOqu0lg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7f0bc99-0ba6-4bad-abdb-f6b905f14954", "AQAAAAEAACcQAAAAEO3ehf1woF56V9tqUzXyNOjTVV+/ATDdIiLhLtcPr2azLTKndm3E2yIub48dfG2rxg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 56, 9, 846, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 56, 9, 847, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 56, 9, 847, DateTimeKind.Local).AddTicks(9338));
        }
    }
}
