using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatedatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "Description",
                value: "Cải thiện kỹ năng thuyết trình của bạn là rất quan trọng bởi vì bài thuyết trình của bạn càng đáng nhớ, có tác động và hiệu quả, thì cả bạn và khán giả của bạn sẽ càng nhận được nhiều kinh nghiệm học tập và chia sẻ của một cuộc họp, bài giảng hoặc hội thảo (hoặc bất kỳ điều gì khác mà bài thuyết trình của bạn)");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Improving your presentation skills is important because the more memorable, impactful, and effective your presentations are, the more both you and your audience will get out of the learning and sharing experience of a meeting, lecture, or workshop (or whatever else your presentation is for)");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Details",
                value: "Kiểu trả về của phương thức GetTodoItems và GetTodoItem là kiểu ActionResult <T>. ASP.NET Core tự động tuần tự hóa đối tượng thành JSON và ghi JSON vào phần nội dung của thông báo phản hồi. Mã phản hồi cho kiểu trả về này là 200 OK, giả sử không có ngoại lệ nào được xử lý. Các ngoại lệ chưa được xử lý được chuyển thành lỗi 5xx.");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Details" },
                values: new object[] { "In this tutorial, you learn how to:  Create a web API project. Add a model class and a database context.     Scaffold a controller with CRUD methods. Configure routing, URL paths, and return values. Call the web API with Postman.", "The return type of the GetTodoItems and GetTodoItem methods is ActionResult<T> type. ASP.NET Core automatically serializes the object to JSON and writes the JSON into the body of the response message. The response code for this return type is 200 OK, assuming there are no unhandled exceptions. Unhandled exceptions are translated into 5xx errors." });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Details",
                value: "Để hiểu những thành phần nào chúng ta có thể cần và cách lắp ráp chúng,t trực tuyến hàng nghìn tỷ giao dịch blockchain, ở độ trễ 10 mili giây, từ không gian giữa các vì sao! Hãy áp dụng đủ các ràng buộc thiết kế để giải quyết vấn đề trước mắt của bạn. Để chuẩn bị cho nơi mà bạn mong đợi một cách hợp lý trong một năm. phần thiết kế nào để xem lại.");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "481fda51-84c5-4e36-b92e-fb5e2f2f0a74");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "47c34c88-f201-42c5-87eb-084e9cce351c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "cc160dbf-7b9a-470e-964d-d7792008d9dd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6931c100-ab7f-4ff7-9a09-8354fe84d1ae", "AQAAAAEAACcQAAAAEAIAZCkmzvXTHlxG/hmKj0H6OpVeUeTBz0UvAXncknJhpqf+n+lf9gr72cEvgIjeSw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cbc0992-500b-4d20-9b5f-f1d94c084ed3", "AQAAAAEAACcQAAAAEPjba1YUQkcZRfmP21ZNy/5WFnSEEQkoQyG+85U9r3igi4FKUMU+ZXkvTevbzmtsTw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0e05bfd-6ab2-48cd-9e73-19b6ceebd399", "AQAAAAEAACcQAAAAEP+Fp4Xxt8xVMBrU3dO0lM4yrirLD1wEduqR3vja1nS/80tlsDJza92DvSBkMTLirg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ea33bb8-46ba-4984-ae71-50c9e56e8a4d", "AQAAAAEAACcQAAAAEFQ4KYt3KDAwyTRfDL8hEaiFvL5XsRH2JX/R3VlDGLIGqUkcaBoEcK73i2baVIeA0Q==" });

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
                keyValue: 1,
                column: "Description",
                value: "Cải thiện kỹ năng thuyết trình của bạn )");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Improving your presentation skills)");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Details",
                value: "Tạo một API web với ASP.NET Core");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Details" },
                values: new object[] { "In this tutorial, you learn how to:  Create a web API project. Add a model class and a database context.    Scaffold a controller with CRUD methods. Configure routing, URL paths, and return values. Call the web API with Postman.", "Create a web API with ASP.NET Core." });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Details",
                value: "Để hiểu những thành phần nào chúng ta có thể cần và cách lắp ráp chúng");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 20, 51, 51, 499, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 20, 51, 51, 501, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 20, 51, 51, 501, DateTimeKind.Local).AddTicks(960));
        }
    }
}
