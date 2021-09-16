using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatedatabase6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a6900c47-1053-46d8-8e77-e35fbf2c62ce");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "8b16d4e8-d140-4fa4-9929-fe881214ff73");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "e3ff48b0-9eaa-490b-b7a0-87f6bf24a4d0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce151747-4be5-4a25-8f90-63c042b67c1e", "AQAAAAEAACcQAAAAEI+5xEkFGIXBhMp1/DBA08ErVaexcUsRNhrApIQMyQf7+HcNlAOz/bm7ry2OcOsDBw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb5ee9f9-b351-4b98-96af-efa5353ace72", "AQAAAAEAACcQAAAAEGZsWWGDUnvuh2cQ9KTVLHUa0ZdJ31mZVuAncuseo5RGIDrfUIkIY83kiBGj4wndFw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7addfc74-9e31-4b1d-b150-6a528ab5943e", "AQAAAAEAACcQAAAAENR7OebrSu3WvaYJYaYUGaXU2ZqHe2Y2WY+BVEpzGH9/arpBJ1q13qz8uG2DxffluA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4c57608-acf9-403b-b412-6f79d0dc0728", "AQAAAAEAACcQAAAAELm6g1WKK22i1eM0iUQuTRo0tdn8t3OQ3CveC9lo9EEdRCWKRWy/67U/lS9VCUCtIA==" });

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
                value: "Effective teams write less software, and writing less software enables teams to be more effective. This may sound counterintuitive at first: Aren’t we all here as engineers to write software? Isn’t our productivity measured in lines of code? To dispel this illusion, we need to stop conflating what we sometimes do with why.  As engineers, we design and build solutions to the problems that our businesses face. Writing code of our own is often part of the answer. But just as we wouldn’t insist that every bridge be built with bespoke girders and bolts, or that all electrical plugs and sockets have their own form factors, we shouldn’t insist on custom-building every part of the designs that we craft. Instead, we should focus our teams’ finite energy on the places where they can deliver unique value. If we reward teams and individuals for reinventing the wheel rather than for the smart reuse of existing components, we’re dooming ourselves to costly, artisanal efforts rather than efficient shared platforms. <h5> Build what you must, buy what you can, and write it all down </h5> When we’re building something new, our work starts with mapping out an overall strategy, with an understanding of the organization’s context and needs, and writing the pieces that we must create ourselves. As the project progresses, we identify appropriate vendors and suppliers for the pieces we think are more efficient to purchase off the shelf than to build from scratch. The work ends with integrating all of these components into solutions for our customers. And since engineering is a continuous rather than one-time process, we ought to document our decisions for future maintainability, and to share what we’ve learned within our organizations and our broader communities.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 48, 8, 883, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 48, 8, 887, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 48, 8, 887, DateTimeKind.Local).AddTicks(8539));
        }
    }
}
