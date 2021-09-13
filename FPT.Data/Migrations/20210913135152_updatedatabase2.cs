using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatedatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ef7e2aa0-b647-49c7-9330-cdfffc135f8e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "655ca028-c106-40c4-aab8-a4f1ded34ef4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "9a0b283b-ff9e-49b4-9db7-f544d11bceb0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "940b3574-219a-47ce-aaff-31ed078ded07", "AQAAAAEAACcQAAAAEEa50Ph+JiflyAQ1bfamncUFEtvEKJjKBvSHbaH9v/9s21KACXtNnJopuko+iCM06A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "540a7be2-cc2c-404e-9e74-364891da98e7", "AQAAAAEAACcQAAAAEIHLaQbIblJaJpji7AGh3h8eE5tX46hvqUf4YHz5sYoNFAYbjP8rK/pZ1Jj1+xD9Fg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ea6d883-a2d1-47ee-812b-aeb57203f0cf", "AQAAAAEAACcQAAAAEFiPY8hMzg6BM2GLTsLAqjdBdaQz/UW14SPopt5AKBzhelVRfjsfP1YcdVR1lswWdg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "809e9b8c-3e6c-4465-a7ed-7a818bca1608", "AQAAAAEAACcQAAAAEGQzu9V8eqEcFTorFivAO1TN7HVEsQCTrGsbAf2Vnr0sPyRO2Y0nWPbSI6RoV+H91w==" });

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
                value: "mproving your presentation skills is important because the more memorable, impactful, and effective your presentations are, the more both you and your audience will get out of the learning and sharing experience of a meeting, lecture, or workshop (or whatever else your presentation is for)");

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
                value: "Để hiểu những thành phần nào chúng ta có thể cần và cách lắp ráp chúng, bước đầu tiên là thu thập các yêu cầu về vấn đề chúng ta phải đối mặt ngày nay và giải pháp phải mở rộng đến đâu. Điều này cho phép chúng tôi xác định phần nào là duy nhất chứ không phải hàng hóa và phần nào phải được hoàn thành sớm nhất để bắt đầu mang lại giá trị. Đối với các dự án nền tảng và cơ sở hạ tầng nói riêng, việc tiếp cận với các nhóm dự kiến ​​sẽ sử dụng cơ sở hạ tầng là điều cần thiết. Việc ngắt kết nối giữa nhóm thiết kế công cụ và nhóm sử dụng chúng gây lãng phí sự đổi mới. Các nền tảng và công cụ nội bộ đặc biệt cần người quản lý sản phẩm và người ủng hộ nhà phát triển để đảm bảo rằng phần mềm đáp ứng nhu cầu của người dùng và sẽ được nhiệt tình áp dụng thay vì bị bỏ rơi bên đường. Tất nhiên bạn sẽ kết luận rằng bạn cần phần mềm của riêng mình nếu bạn nhấn mạnh rằng sản phẩm của bạn phải hỗ trợ phát trực tuyến hàng nghìn tỷ giao dịch blockchain, ở độ trễ 10 mili giây, từ không gian giữa các vì sao! Hãy áp dụng đủ các ràng buộc thiết kế để giải quyết vấn đề trước mắt của bạn. Để chuẩn bị cho nơi mà bạn mong đợi một cách hợp lý trong một năm. phần thiết kế nào để xem lại.");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Details",
                value: "In order to understand which components we may need and how to assemble them, the very first step is to gather requirements on the problem we face today and how far the solution must scale. This allows us to identify which pieces are unique rather than commodities, and which pieces must be completed soonest to begin delivering value. For platform and infrastructure projects in particular, reaching out to the teams expected to use the infrastructure is essential. Disconnects between the teams that design tools and the teams that use them waste innovation. Internal platforms and tools especially need product managers and developer advocates to ensure that software meets user needs and will be enthusiastically adopted rather than abandoned on the side of the road.Premature optimization for the wrong set of requirements artificially boxes us in and constrains our options.Of course you’re going to conclude that you need your own software if you insist that your product has to support streaming trillions of blockchain transactions, at 10 milliseconds latency, from interstellar space!Apply enough design constraints to solve your immediate problem, as well as to prepare for where you reasonably expect to be in a year.Along the way, write down the alternatives you considered and why you didn’t choose them.You might save time for someone else—or even yourself— during a future evaluation of which design pieces to revisit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 18, 43, 26, 812, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 18, 43, 26, 814, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 18, 43, 26, 814, DateTimeKind.Local).AddTicks(1246));
        }
    }
}
