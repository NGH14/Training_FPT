using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPT.Data.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"), new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba") });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "940b3574-219a-47ce-aaff-31ed078ded07", "AQAAAAEAACcQAAAAEEa50Ph+JiflyAQ1bfamncUFEtvEKJjKBvSHbaH9v/9s21KACXtNnJopuko+iCM06A==" });

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

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"), 0, "540a7be2-cc2c-404e-9e74-364891da98e7", new DateTime(2001, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "BaoNguyenLeVHGCS190654@fpt.edu.com", true, "Bao", "Le", false, null, "BaoNguyenLeVHGCS190654@fpt.edu.com", "Bao", "AQAAAAEAACcQAAAAEIHLaQbIblJaJpji7AGh3h8eE5tX46hvqUf4YHz5sYoNFAYbjP8rK/pZ1Jj1+xD9Fg==", null, false, "", false, "BaoNguyenLe" });

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
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Workshop: Code less, engineer more");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Workshop: Code less, engineer more");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "End", "Start" },
                values: new object[] { "Cải thiện kỹ năng thuyết trình của bạn là rất quan trọng bởi vì bài thuyết trình của bạn càng đáng nhớ, có tác động và hiệu quả, thì cả bạn và khán giả của bạn sẽ càng nhận được nhiều kinh nghiệm học tập và chia sẻ của một cuộc họp, bài giảng hoặc hội thảo (hoặc bất kỳ điều gì khác mà bài thuyết trình của bạn)", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "End", "Start" },
                values: new object[] { "mproving your presentation skills is important because the more memorable, impactful, and effective your presentations are, the more both you and your audience will get out of the learning and sharing experience of a meeting, lecture, or workshop (or whatever else your presentation is for)", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Address", "Description", "Details", "End", "LanguageId", "Name", "ProductId", "Start", "TrainerEmail", "TrainingTypes" },
                values: new object[,]
                {
                    { 6, "https://meet.google.com/ffy-huvy-cjg", "As engineers, we design and build solutions to the problems that our businesses face. Writing code of our own is often part of the answer. But just as we wouldn’t insist that every bridge be built with bespoke girders and bolts, or that all electrical plugs and sockets have their own form factors, we shouldn’t insist on custom-building every part of the designs that we craft. Instead, we should focus our teams’ finite energy on the places where they can deliver unique value. If we reward teams and individuals for reinventing the wheel rather than for the smart reuse of existing components, we’re dooming ourselves to costly, artisanal efforts rather than efficient shared platforms.", "In order to understand which components we may need and how to assemble them, the very first step is to gather requirements on the problem we face today and how far the solution must scale. This allows us to identify which pieces are unique rather than commodities, and which pieces must be completed soonest to begin delivering value. For platform and infrastructure projects in particular, reaching out to the teams expected to use the infrastructure is essential. Disconnects between the teams that design tools and the teams that use them waste innovation. Internal platforms and tools especially need product managers and developer advocates to ensure that software meets user needs and will be enthusiastically adopted rather than abandoned on the side of the road.Premature optimization for the wrong set of requirements artificially boxes us in and constrains our options.Of course you’re going to conclude that you need your own software if you insist that your product has to support streaming trillions of blockchain transactions, at 10 milliseconds latency, from interstellar space!Apply enough design constraints to solve your immediate problem, as well as to prepare for where you reasonably expect to be in a year.Along the way, write down the alternatives you considered and why you didn’t choose them.You might save time for someone else—or even yourself— during a future evaluation of which design pieces to revisit.", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "en", "Code less, engineer more", 3, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "NamLam@fpt.staff.com", "Online" },
                    { 5, "https://meet.google.com/ffy-huvy-cjg", "Với tư cách là kỹ sư, chúng tôi thiết kế và xây dựng giải pháp cho các vấn đề mà doanh nghiệp của chúng tôi gặp phải. Viết mã của riêng chúng tôi thường là một phần của câu trả lời. Nhưng cũng như chúng tôi sẽ không khăng khăng rằng mọi cây cầu phải được xây dựng bằng dầm và bu lông đặt riêng, hoặc tất cả phích cắm và ổ cắm điện đều có các yếu tố hình thức riêng, chúng ta không nên khăng khăng xây dựng tùy chỉnh từng phần của thiết kế mà chúng ta tạo ra. Thay vào đó, chúng ta nên tập trung năng lượng hữu hạn của nhóm vào những nơi mà chúng có thể mang lại giá trị độc đáo . Nếu chúng ta thưởng cho các nhóm và cá nhân vì đã phát minh lại bánh xe thay vì tái sử dụng một cách thông minh các thành phần hiện có, chúng ta đang tự đưa mình vào những nỗ lực thủ công, tốn kém hơn là các nền tảng được chia sẻ hiệu quả", "Để hiểu những thành phần nào chúng ta có thể cần và cách lắp ráp chúng, bước đầu tiên là thu thập các yêu cầu về vấn đề chúng ta phải đối mặt ngày nay và giải pháp phải mở rộng đến đâu. Điều này cho phép chúng tôi xác định phần nào là duy nhất chứ không phải hàng hóa và phần nào phải được hoàn thành sớm nhất để bắt đầu mang lại giá trị. Đối với các dự án nền tảng và cơ sở hạ tầng nói riêng, việc tiếp cận với các nhóm dự kiến ​​sẽ sử dụng cơ sở hạ tầng là điều cần thiết. Việc ngắt kết nối giữa nhóm thiết kế công cụ và nhóm sử dụng chúng gây lãng phí sự đổi mới. Các nền tảng và công cụ nội bộ đặc biệt cần người quản lý sản phẩm và người ủng hộ nhà phát triển để đảm bảo rằng phần mềm đáp ứng nhu cầu của người dùng và sẽ được nhiệt tình áp dụng thay vì bị bỏ rơi bên đường. Tất nhiên bạn sẽ kết luận rằng bạn cần phần mềm của riêng mình nếu bạn nhấn mạnh rằng sản phẩm của bạn phải hỗ trợ phát trực tuyến hàng nghìn tỷ giao dịch blockchain, ở độ trễ 10 mili giây, từ không gian giữa các vì sao! Hãy áp dụng đủ các ràng buộc thiết kế để giải quyết vấn đề trước mắt của bạn. Để chuẩn bị cho nơi mà bạn mong đợi một cách hợp lý trong một năm. phần thiết kế nào để xem lại.", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi", "Lập Trình như là Kỹ Sư Phần Mềm", 3, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "NamLam@fpt.staff.com", "Trực tuyến" },
                    { 4, "https://meet.google.com/ffy-huvy-cjg", "In this tutorial, you learn how to:  Create a web API project. Add a model class and a database context.     Scaffold a controller with CRUD methods. Configure routing, URL paths, and return values. Call the web API with Postman.", "The return type of the GetTodoItems and GetTodoItem methods is ActionResult<T> type. ASP.NET Core automatically serializes the object to JSON and writes the JSON into the body of the response message. The response code for this return type is 200 OK, assuming there are no unhandled exceptions. Unhandled exceptions are translated into 5xx errors.", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "en", "Tutorial: Create a web API with ASP.NET Core", 2, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "NamLam8@fpt.staff.com", "Online" },
                    { 3, "https://meet.google.com/ffy-huvy-cjg", "Trong hướng dẫn này, bạn học cách: Tạo một dự án API web. Thêm một lớp mô hình và một ngữ cảnh cơ sở dữ liệu. Scaffold một bộ điều khiển với các phương pháp CRUD. Định cấu hình định tuyến, đường dẫn URL và giá trị trả về. Gọi API web bằng Postman.", "Kiểu trả về của phương thức GetTodoItems và GetTodoItem là kiểu ActionResult <T>. ASP.NET Core tự động tuần tự hóa đối tượng thành JSON và ghi JSON vào phần nội dung của thông báo phản hồi. Mã phản hồi cho kiểu trả về này là 200 OK, giả sử không có ngoại lệ nào được xử lý. Các ngoại lệ chưa được xử lý được chuyển thành lỗi 5xx.", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "vi", "Hướng dẫn: Tạo một API web với ASP.NET Core", 2, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "NamLam@fpt.staff.com", "Trực tuyến" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"), new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a84dce2-123a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("12bd354f-9101-45ca-b5b7-da3f325983dc"),
                column: "ConcurrencyStamp",
                value: "869ee561-54b2-4bc3-8489-9535485f7b16");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("17d4acf8-1131-b5b7-1100-aa6f321543ba"),
                column: "ConcurrencyStamp",
                value: "9260a1f6-1226-48a7-aa46-9feca7168af5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                column: "ConcurrencyStamp",
                value: "2d929111-4ceb-4107-8810-a2615ac2c77d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1710dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bb17a54-b40c-4c9d-b531-6673f43ebd6d", "AQAAAAEAACcQAAAAEHjOlOAWUAqU/lCwZzG7TxomwxQ5QqS7FJDqTFbzOKQ3KBDoFJASbGl1nqTqHiFSOA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5630169d-ea3f-4973-bc5d-e8d013b88ff6", "AQAAAAEAACcQAAAAEM3tQMNWsgLQwvqlnDOAAOv1Y/Q4c+z5ybd23AkOgnb8nPm1MJIz+6z1YqhU6h9P0Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad80dce2-969a-1313-bba4-8d89325983dc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e83c78f5-3744-4574-a8c9-b8eb22f9c5e3", "AQAAAAEAACcQAAAAEH9K5QZNx5owJZyGlEboWZlLybadxCJa9JKvitCX0VTo9cADnSO1BrbPT5qIRpsyRA==" });

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
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Đào Tạo Trình Soạn Thảo CKEditor");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "CKEditor Training 102");

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 7, 4, "vi", "Workshop: Code less, engineer more", null, null, null },
                    { 8, 4, "en", "Workshop: Code less, engineer more", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "End", "Start" },
                values: new object[] { "Cải thiện kĩ năng thuyết trình", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "End", "Start" },
                values: new object[] { "Improve Presentation Skill", new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 17, 32, 42, 376, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "IsFeatured" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2940), null },
                    { 9, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2917), null },
                    { 8, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2895), null },
                    { 7, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2875), null },
                    { 6, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2855), null },
                    { 5, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2832), null },
                    { 4, new DateTime(2021, 9, 13, 17, 32, 42, 377, DateTimeKind.Local).AddTicks(2809), null }
                });
        }
    }
}
