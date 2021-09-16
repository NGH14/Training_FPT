using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatehrrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "56637188-a51d-47a6-befe-d18fa3d010e3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "0a66425f-39a3-45e7-8aeb-4bbe118ee828");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "279d6805-94c7-40a0-99f5-9883f57f9568");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("c1e71b9a-7aae-4f7c-9ab9-b9e52d1ef6da"), new Guid("074bc203-87c9-4dc6-883e-4800b5e9d4eb") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6a1afb0-db5f-479f-b5af-a464fe4d834a", "AQAAAAEAACcQAAAAEOynm1Kr86YXdWeeQeW7i6fgSDJVlzNU6G14lNZwwpcNqtRDP4KUmUtAH2KutuTVJg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45b0460f-69c7-4bf3-bce7-a04d7d2b2f19", "AQAAAAEAACcQAAAAEOrLgEUMqaSZ5m284WhSxXjJeAqaKnqafhEpiK1C5QxY/gvo3dJGQcVuqVdJtjOS6w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "baae0dbf-5ed8-44fc-9201-e8f6667960b5", "AQAAAAEAACcQAAAAEOKJJziHSTLOqZFtv/h8/ZcVeKK/5qL3AC3SXbocq3T5vodb88AE8CHMSksPX7EI2g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23a486ff-1d68-480b-ab4f-5f5039a7394d", "AQAAAAEAACcQAAAAEHqgkNBwLHJyCOgWg8VVaDqrEMHoIt5pUU692Uxsy0h3do32F7nanqOdh28RQEBiAg==" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c1e71b9a-7aae-4f7c-9ab9-b9e52d1ef6da"), 0, "ca3162b3-81f0-4792-a6cb-da1a309d25b8", new DateTime(1998, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "DuyNguyenDalat@fpt.staff.com", true, "Duy", "Nguyen", false, null, "DuyNguyenDalat@fpt.staff.com", "Duy", "AQAAAAEAACcQAAAAEK6xH4EL1cKVpac8ke9rD4VNs0wwovUK9M3K9CYiSPR0zO0JTRiMDfXo4grvvP98aQ==", null, false, "", false, "DuyDallat34" });

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
                value: new DateTime(2021, 9, 15, 14, 16, 6, 586, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 16, 6, 587, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 15, 14, 16, 6, 587, DateTimeKind.Local).AddTicks(4265));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c1e71b9a-7aae-4f7c-9ab9-b9e52d1ef6da"), new Guid("074bc203-87c9-4dc6-883e-4800b5e9d4eb") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1e71b9a-7aae-4f7c-9ab9-b9e52d1ef6da"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1124755a-5215-4c8b-b120-0b209b730f6b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "8e044f5e-6d87-4db6-afeb-e2c5e59bf751");

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
    }
}
