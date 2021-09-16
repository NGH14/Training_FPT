using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatedatabase7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4a6feda0-1db6-4ed0-bd88-f023eca6848a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "db36ddcd-d735-4b26-96dd-b86c560f5773");

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
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Details",
                value: "Effective teams write less software, and writing less software enables teams to be more effective. This may sound counterintuitive at first: Aren’t we all here as engineers to write software? Isn’t our productivity measured in lines of code? To dispel this illusion, we need to stop conflating what we sometimes do with why.  As engineers, we design and build solutions to the problems that our businesses face. Writing code of our own is often part of the answer. But just as we wouldn’t insist that every bridge be built with bespoke girders and bolts, or that all electrical plugs and sockets have their own form factors, we shouldn’t insist on custom-building every part of the designs that we craft. Instead, we should focus our teams’ finite energy on the places where they can deliver unique value. If we reward teams and individuals for reinventing the wheel rather than for the smart reuse of existing components, we’re dooming ourselves to costly, artisanal efforts rather than efficient shared platforms. Build what you must, buy what you can, and write it all down When we’re building something new, our work starts with mapping out an overall strategy, with an understanding of the organization’s context and needs, and writing the pieces that we must create ourselves. As the project progresses, we identify appropriate vendors and suppliers for the pieces we think are more efficient to purchase off the shelf than to build from scratch. The work ends with integrating all of these components into solutions for our customers. And since engineering is a continuous rather than one-time process, we ought to document our decisions for future maintainability, and to share what we’ve learned within our organizations and our broader communities.");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ed7472b9-d0fa-4de6-a939-e9563d8f880e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "6e8bb9ec-c9f4-483c-b04b-d44ac2ca1cdf");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "16a4fd2c-0932-47c3-ad0b-156c3fcaa1d1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "957659b6-9d04-45ac-ae88-a5a32515bb5e", "AQAAAAEAACcQAAAAEEiUcolHxnGTwmEnZWgNU3C8PCwxt0CCI0yXlEUxfHsPCcsGisR8JVOhmvA2PL3Rzg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4c40013-a3e7-4307-884e-66363f74a367", "AQAAAAEAACcQAAAAEO6aRHmCkGba6gtVlqzJQyB0BfJQEyecmCBonzmidWCcIHldjW3v2zpcGQQRc3huyw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f58bc4ef-36d7-476d-a24b-b918dbfc1827", "AQAAAAEAACcQAAAAEFkq7EdUl3inZBXTVmRv2P0w7/BGVOBL4KLO5KtJ2Zz6+srhhYHA7Nzw/IauoGL4oA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1dc1590-4fa1-4050-9b61-61ff083008a2", "AQAAAAEAACcQAAAAEGQ8B4T8mrV+wdCh4l6rKNvSVI5dU8z+7sorgrTX+VfOnTxsvmecGQKBGKG+ChYsnw==" });

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
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Details",
                value: "Effective teams write less software, and writing less software enables teams to be more effective. This may sound counterintuitive at first: Aren’t we all here as engineers to write software? Isn’t our productivity measured in lines of code? To dispel this illusion, we need to stop conflating what we sometimes do with why.  As engineers, we design and build solutions to the problems that our businesses face. Writing code of our own is often part of the answer. But just as we wouldn’t insist that every bridge be built with bespoke girders and bolts, or that all electrical plugs and sockets have their own form factors, we shouldn’t insist on custom-building every part of the designs that we craft. Instead, we should focus our teams’ finite energy on the places where they can deliver unique value. If we reward teams and individuals for reinventing the wheel rather than for the smart reuse of existing components, we’re dooming ourselves to costly, artisanal efforts rather than efficient shared platforms. <h5> <p>Build what you must, buy what you can, and write it all down </h5> When we’re building something new, our work starts with mapping out an overall strategy, with an understanding of the organization’s context and needs, and writing the pieces that we must create ourselves. As the project progresses, we identify appropriate vendors and suppliers for the pieces we think are more efficient to purchase off the shelf than to build from scratch. The work ends with integrating all of these components into solutions for our customers. And since engineering is a continuous rather than one-time process, we ought to document our decisions for future maintainability, and to share what we’ve learned within our organizations and our broader communities </p>.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 53, 17, 535, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 53, 17, 536, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 53, 17, 536, DateTimeKind.Local).AddTicks(5143));
        }
    }
}
