using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatedatabase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2a998145-c267-4309-a85a-31245b4c8803");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "de7d6e23-a2bf-40b5-b656-697180eeee6e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "c3c4fe73-7aba-4caa-aba4-8840dfbef5da");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac6eff83-62b4-4fca-93ff-5d5ed8301e8b", "AQAAAAEAACcQAAAAEIU//yovNQrv/v/ZGA92hlJgIlVrBClhHsBRoSgs2FRO8wefdR5UnGXcxc2oVtdiPA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70e05bea-ead6-4768-a599-09e76925b43d", "AQAAAAEAACcQAAAAECFhu0B/U3NE2wtc74LXVs3uUKJNXkinXpkIQVRRG7Sba30FM55ODlRxGbvO1zNpVg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09cfb1b0-0b8d-440d-bdf5-5806d8e9db28", "AQAAAAEAACcQAAAAEBXzi9+jkuJKyAQXtJpHrLC1FfxCkmMTYtHMvK/wMruqJxsPwz/k3YfF8CZbCga5nQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e18fbd16-a74e-4577-9602-2a0cde278e6b", "AQAAAAEAACcQAAAAEOVEKIEhHqt7MWeHdLRC+SanqCpot65LCqq2W/UT0WDhWdBAQmVSng1t7Lc4Cv0Pjg==" });

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
                keyValue: 5,
                column: "Details",
                value: "Các nhóm hiệu quả viết ít phần mềm hơn và viết ít phần mềm hơn cho phép các nhóm làm việc hiệu quả hơn. Thoạt nghe, điều này nghe có vẻ phản trực giác: Không phải tất cả chúng ta ở đây đều là kỹ sư viết phần mềm sao? Năng suất của chúng ta không được đo bằng các dòng mã sao? Để xua tan ảo tưởng này, chúng ta cần dừng việc nhầm lẫn đôi khi chúng ta làm gì với lý do tại sao. Với tư cách là kỹ sư, chúng tôi thiết kế và xây dựng các giải pháp cho các vấn đề mà doanh nghiệp của chúng tôi gặp phải. Viết mã của riêng chúng ta thường là một phần của câu trả lời. Nhưng cũng như chúng tôi sẽ không khăng khăng rằng mọi cây cầu đều được xây dựng bằng dầm và bu lông đặt riêng hoặc tất cả các phích cắm và ổ cắm điện đều có kiểu dáng riêng, chúng tôi không nên nhấn mạnh vào việc xây dựng theo yêu cầu của từng bộ phận của thiết kế mà chúng tôi chế tạo. Thay vào đó, chúng ta nên tập trung năng lượng hữu hạn của nhóm vào những nơi mà họ có thể mang lại giá trị độc đáo. Nếu chúng tôi thưởng cho các nhóm và cá nhân vì đã phát minh lại bánh xe thay vì tái sử dụng một cách thông minh các thành phần hiện có, chúng tôi đang tự mình hướng tới những nỗ lực thủ công, tốn kém hơn là các nền tảng được chia sẻ hiệu quả.");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Details",
                value: "Effective teams write less software, and writing less software enables teams to be more effective. This may sound counterintuitive at first: Aren’t we all here as engineers to write software? Isn’t our productivity measured in lines of code? To dispel this illusion, we need to stop conflating what we sometimes do with why.  As engineers, we design and build solutions to the problems that our businesses face. Writing code of our own is often part of the answer. But just as we wouldn’t insist that every bridge be built with bespoke girders and bolts, or that all electrical plugs and sockets have their own form factors, we shouldn’t insist on custom-building every part of the designs that we craft. Instead, we should focus our teams’ finite energy on the places where they can deliver unique value. If we reward teams and individuals for reinventing the wheel rather than for the smart reuse of existing components, we’re dooming ourselves to costly, artisanal efforts rather than efficient shared platforms.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 10, 6, 606, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 10, 6, 607, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 23, 10, 6, 607, DateTimeKind.Local).AddTicks(8934));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9597863f-03fb-41f4-abec-8a63014fb5fd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "87646e1c-a833-4694-9ce5-e2b61a3ed953");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "d403edd2-9ea2-4a38-9335-d5dc2e76447a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c753de9b-4a4b-4cd5-ba6f-176ad9d7bba3", "AQAAAAEAACcQAAAAEBWKmhGLJcxlit+/0YpWrtmM7UUm/obKeUlicTzVTFx90WRs4665E25Vnok4Mvwofg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9635465-4d1b-49c0-9ff6-75d7dced74a6", "AQAAAAEAACcQAAAAENwfIx0KmyFTQxuOPZHT8f/HkzxgY48dT1oeveaM7zEff1BRBWetlgP1CTCWsUZ+Mw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ea9b64a-f1ee-4572-a80b-33a28722fa19", "AQAAAAEAACcQAAAAEO5JO0TbwnDwKHz/FTVa1DulxcJmlsWcX4WVQ0aE775Lb8XP7iHPHI64MEVRBVauHw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54900498-2c81-44ac-b650-c333a0c06c76", "AQAAAAEAACcQAAAAEB6ot4Z9+fyD28ToJl3vDljNkUxCNQUZA6yDTuSA9hvOtC3hpSqoM2wtru0iTdTV7A==" });

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
                keyValue: 5,
                column: "Details",
                value: "Để hiểu những thành phần nào chúng ta có thể cần và cách lắp ráp chúng,t trực tuyến hàng nghìn tỷ giao dịch blockchain, ở độ trễ 10 mili giây, từ không gian giữa các vì sao! Hãy áp dụng đủ các ràng buộc thiết kế để giải quyết vấn đề trước mắt của bạn. Để chuẩn bị cho nơi mà bạn mong đợi một cách hợp lý trong một năm. phần thiết kế nào để xem lại.");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Details",
                value: "Code less, engineer more");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 21, 18, 32, 507, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 21, 18, 32, 508, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 21, 18, 32, 508, DateTimeKind.Local).AddTicks(2245));
        }
    }
}
