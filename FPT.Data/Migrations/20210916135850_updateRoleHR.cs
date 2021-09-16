using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updateRoleHR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fe2ccb55-7eef-4598-9ae8-76ab0c8c7cf4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "e3dd011d-86ce-4f07-90ec-e4799366e713");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "17a2462d-d61a-4187-be18-fc136ac2bb43");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("074bc203-87c9-4dc6-883e-4800b5e9d4eb"), "26bd670a-fa40-452d-ad6f-cc60b734e90f", "Human Resources role", "Human Resources", "Human Resources" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a2b6756-de00-4138-bc3f-71d9ea9a4149", "AQAAAAEAACcQAAAAEMioo7Fh1bkInONwPdD/LoN4/KRY6tvpC+ts4/E8I9EgWUBVYLICSeRHyNDh9SaE0A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35e5e5e0-eb8c-49ab-840c-d6d8a3bd9c56", "AQAAAAEAACcQAAAAEPt0Hflm/E67ZXJp79dWRCDCLGupTRfTYdyZ+WJ72GMElvZXfhsYGhDhGylcEdRvIw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e61d57e7-d7f2-44ac-aaba-326f437dc51b", "AQAAAAEAACcQAAAAEFXVnbsjh2fqiCnneVfMlbvG+CJa9AmsMHEqRfU4OiOuWerxpgttZCu98gmBSr5DSA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41f8c01b-457a-4b66-9ac4-a66ef239e68b", "AQAAAAEAACcQAAAAEGPM+53vvq42+QwEPOX5N4yd6+YIaPoepxituW5Bu+I8m8H5nogNC7Xik00ge6Q8mw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1e71b9a-7aae-4f7c-9ab9-b9e52d1ef6da"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9435769b-a773-49f0-beb0-d18bc9042b9f", "AQAAAAEAACcQAAAAEL/DKmyvss8AB9eogV5COToKB478uka912Mls5GOlr0Cyf6dUEdmqEIDuI3v86q00Q==" });

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
                value: new DateTime(2021, 9, 16, 20, 58, 49, 362, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 20, 58, 49, 363, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 16, 20, 58, 49, 363, DateTimeKind.Local).AddTicks(6802));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("074bc203-87c9-4dc6-883e-4800b5e9d4eb"));

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

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1e71b9a-7aae-4f7c-9ab9-b9e52d1ef6da"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca3162b3-81f0-4792-a6cb-da1a309d25b8", "AQAAAAEAACcQAAAAEK6xH4EL1cKVpac8ke9rD4VNs0wwovUK9M3K9CYiSPR0zO0JTRiMDfXo4grvvP98aQ==" });

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
    }
}
