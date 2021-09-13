using FPT.Data.Entities;
using FPT.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of FPT" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of FPT" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of FPT" }
               );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = false },
                new Language() { Id = "en", Name = "English", IsDefault = true });


            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },

                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 },

                new Category()
                {
                    Id = 3,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active
                },

                new Category()
                {
                    Id = 4,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 5,
                    Status = Status.Active
                });



            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Kĩ năng thuyết trình", LanguageId = "vi" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Presentation skills", LanguageId = "en" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Đào tạo ASP.NET CORE 101", LanguageId = "vi" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "ASP.NET Core Training 101", LanguageId = "en" },
                  new CategoryTranslation() { Id = 5, CategoryId = 3, Name = "Workshop: Code less, engineer more", LanguageId = "vi" },
                  new CategoryTranslation() { Id = 6, CategoryId = 3, Name = "Workshop: Code less, engineer more", LanguageId = "en" }

                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,

           });

            modelBuilder.Entity<Product>().HasData(new Product() { Id = 2,DateCreated = DateTime.Now});
            modelBuilder.Entity<Product>().HasData(new Product() { Id = 3, DateCreated = DateTime.Now });



            
            // Product ID 1
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Tập trung vào mục tiêu",
                     LanguageId = "vi",
                     Details = "Mục tiêu bài thuyết trình của bạn nên là một trong những ý sau: Để chia sẻ một số thông tin Để dạy một điều gì đó. Để giải trí.Để giải thích và giải quyết một vấn đềĐiều quan trọng nhất là khán giả của bạn nghe được những gì, vì vậy,bạn phải cân nhắc cẩn thận bạn nên nói những gì và bạn nên nói như thế nào.Mọi người không thể liên tục tập trung trong một khoảng thời gian dài.Bạn nên chia ra những phần nhỏ và mỗi phần khoảng 15 phút.Bạn cũng nên có phần thảo luận, câu hỏi hoặc hoạt động ngắn giữa những đoạn nói đó.",
                     Description = "Cải thiện kỹ năng thuyết trình của bạn là rất quan trọng bởi vì bài thuyết trình của bạn càng đáng nhớ, có tác động và hiệu quả, thì cả bạn và khán giả của bạn sẽ càng nhận được nhiều kinh nghiệm học tập và chia sẻ của một cuộc họp, bài giảng hoặc hội thảo (hoặc bất kỳ điều gì khác mà bài thuyết trình của bạn)",
                     Start = new DateTime(2021, 1, 3),
                     End = new DateTime(2021, 2, 3),
                     TrainerEmail= "NhanVGBS1588@fpt.staff.com",
                     TrainingTypes= "Tại Cơ Sở",
                     Address= "Căn hộ số 3 - Trường Sa -Phường 2 - Quận Phú Nhuận -TPHCM"
                 },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Focus on objectives",
                    LanguageId = "en",
                    Details = "You should make a presentation with the following objective: To share some information To teach something. For fun.To explain and solve a problem. Cannot focus continuously for a long period of time. It is recommended that you divide it into small parts and each section is about 15 minutes. You should also have a discussion, question or short activity in between the speeches.",
                    Description = "Improving your presentation skills is important because the more memorable, impactful, and effective your presentations are, the more both you and your audience will get out of the learning and sharing experience of a meeting, lecture, or workshop (or whatever else your presentation is for)",
                    Start = new DateTime(2021, 1, 3),
                    End = new DateTime(2021, 2, 3),
                    TrainerEmail = "NhanVGBS1588@fpt.staff.com",
                    TrainingTypes = "Offline",
                    Address = "Apartment No.3 - Truong Sa Street - Ward 2 - Phu NHuan District - Ho Chi Minh City"
                },

                  new ProductTranslation()
                  {
                      Id = 3,
                      ProductId = 2,
                      Name = "Hướng dẫn: Tạo một API web với ASP.NET Core",
                      LanguageId = "vi",
                      Details = "Kiểu trả về của phương thức GetTodoItems và GetTodoItem là kiểu ActionResult <T>. ASP.NET Core tự động tuần tự hóa đối tượng thành JSON và ghi JSON vào phần nội dung của thông báo phản hồi. Mã phản hồi cho kiểu trả về này là 200 OK, giả sử không có ngoại lệ nào được xử lý. Các ngoại lệ chưa được xử lý được chuyển thành lỗi 5xx.",
                      Description = "Trong hướng dẫn này, bạn học cách: Tạo một dự án API web. Thêm một lớp mô hình và một ngữ cảnh cơ sở dữ liệu. Scaffold một bộ điều khiển với các phương pháp CRUD. Định cấu hình định tuyến, đường dẫn URL và giá trị trả về. Gọi API web bằng Postman.",
                      Start = new DateTime(2021, 1, 3),
                      End = new DateTime(2021, 2, 3),
                      TrainerEmail = "NamLam@fpt.staff.com",
                      TrainingTypes = "Trực tuyến",
                      Address = "https://meet.google.com/ffy-huvy-cjg"
                  },
                new ProductTranslation()
                {
                    Id = 4,
                    ProductId = 2,
                    Name = "Tutorial: Create a web API with ASP.NET Core",
                    LanguageId = "en",
                    Details = "The return type of the GetTodoItems and GetTodoItem methods is ActionResult<T> type. ASP.NET Core automatically serializes the object to JSON and writes the JSON into the body of the response message. The response code for this return type is 200 OK, assuming there are no unhandled exceptions. Unhandled exceptions are translated into 5xx errors.",
                    Description = "In this tutorial, you learn how to:  Create a web API project. Add a model class and a database context.     Scaffold a controller with CRUD methods. Configure routing, URL paths, and return values. Call the web API with Postman.",
                    Start = new DateTime(2021, 11, 3),
                    End = new DateTime(2022, 1, 3),
                    TrainerEmail = "NamLam8@fpt.staff.com",
                    TrainingTypes = "Online",
                    Address = "https://meet.google.com/ffy-huvy-cjg"
                },

                  new ProductTranslation()
                  {
                      Id = 5,
                      ProductId = 3,
                      Name = "Lập Trình như là Kỹ Sư Phần Mềm",
                      LanguageId = "vi",
                      Details = "Để hiểu những thành phần nào chúng ta có thể cần và cách lắp ráp chúng,t trực tuyến hàng nghìn tỷ giao dịch blockchain, ở độ trễ 10 mili giây, từ không gian giữa các vì sao! Hãy áp dụng đủ các ràng buộc thiết kế để giải quyết vấn đề trước mắt của bạn. Để chuẩn bị cho nơi mà bạn mong đợi một cách hợp lý trong một năm. phần thiết kế nào để xem lại.",
                      Description = "Với tư cách là kỹ sư, chúng tôi thiết kế và xây dựng giải pháp cho các vấn đề mà doanh nghiệp của chúng tôi gặp phải. Viết mã của riêng chúng tôi thường là một phần của câu trả lời. Nhưng cũng như chúng tôi sẽ không khăng khăng rằng mọi cây cầu phải được xây dựng bằng dầm và bu lông đặt riêng, hoặc tất cả phích cắm và ổ cắm điện đều có các yếu tố hình thức riêng, chúng ta không nên khăng khăng xây dựng tùy chỉnh từng phần của thiết kế mà chúng ta tạo ra. Thay vào đó, chúng ta nên tập trung năng lượng hữu hạn của nhóm vào những nơi mà chúng có thể mang lại giá trị độc đáo . Nếu chúng ta thưởng cho các nhóm và cá nhân vì đã phát minh lại bánh xe thay vì tái sử dụng một cách thông minh các thành phần hiện có, chúng ta đang tự đưa mình vào những nỗ lực thủ công, tốn kém hơn là các nền tảng được chia sẻ hiệu quả",
                      Start = new DateTime(2020, 1, 21),
                      End = new DateTime(2021, 1, 21),
                      TrainerEmail = "NamLam@fpt.staff.com",
                      TrainingTypes = "Trực tuyến",
                      Address = "https://meet.google.com/ffy-huvy-cjg"
                  },

                new ProductTranslation()
                {
                    Id = 6,
                    ProductId = 3,
                    Name = "Code less, engineer more",
                    LanguageId = "en",
                    Details = "Code less, engineer more",
                    Description = "As engineers, we design and build solutions to the problems that our businesses face. Writing code of our own is often part of the answer. But just as we wouldn’t insist that every bridge be built with bespoke girders and bolts, or that all electrical plugs and sockets have their own form factors, we shouldn’t insist on custom-building every part of the designs that we craft. Instead, we should focus our teams’ finite energy on the places where they can deliver unique value. If we reward teams and individuals for reinventing the wheel rather than for the smart reuse of existing components, we’re dooming ourselves to costly, artisanal efforts rather than efficient shared platforms.",
                    Start = new DateTime(2020, 1, 21),
                    End = new DateTime(2021, 1, 21),
                    TrainerEmail = "NamLam@fpt.staff.com",
                    TrainingTypes = "Online",
                    Address = "https://meet.google.com/ffy-huvy-cjg"
                }







                ); ; ;





            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 2 },
                 new ProductInCategory() { ProductId = 3, CategoryId = 3 }
                );


                    // any guid
         



            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            var trainerId = new Guid("12BD354F-9101-45CA-B5B7-DA3F325983DC");

            var traineeId = new Guid("17D4ACF8-1131-B5B7-1100-AA6F321543BA");


            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = trainerId,
                Name = "Trainer",
                NormalizedName = "Trainer",
                Description = "Trainer role"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = traineeId,
                Name = "Trainee",
                NormalizedName = "Trainee",
                Description = "Trainee role"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = adminId,
                Name = "Admin",
                NormalizedName = "Admin",
                Description = "Administrator role"
            });



            var hasher = new PasswordHasher<AppUser>();
         
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"),
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "fptadmin@fpt.staff.com",
                NormalizedEmail = "fptadmin@fpt.staff.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Admin",
                LastName = "Vu Huu",
                Dob = new DateTime(2001, 01, 31)
            });


            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid("1710DCE2-969A-435D-BBA4-DF3F325983DC"),
                UserName = "Nghiavuhuu",
                NormalizedUserName = "Nghia",
                Email = "NghiaVHGCS190654@fpt.edu.com",
                NormalizedEmail = "NghiaVHGCS190654@fpt.edu.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Nghia@123"),
                SecurityStamp = string.Empty,
                FirstName = "Nghia",
                LastName = "Vu",
                Dob = new DateTime(2001, 10, 10)
            });


            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid("1A84DCE2-123A-435D-BBA4-DF3F325983DC"),
                UserName = "BaoNguyenLe",
                NormalizedUserName = "Bao",
                Email = "BaoNguyenLeVHGCS190654@fpt.edu.com",
                NormalizedEmail = "BaoNguyenLeVHGCS190654@fpt.edu.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "BaoLe@123"),
                SecurityStamp = string.Empty,
                FirstName = "Bao",
                LastName = "Le",
                Dob = new DateTime(2001, 1, 17)
            });




            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = new Guid("AD80DCE2-969A-1313-BBA4-8D89325983DC"),
                UserName = "NhanVan",
                NormalizedUserName = "Nhan",
                Email = "NhanVGBS1588@fpt.staff.com",
                NormalizedEmail = "NhanVGBS1588@fpt.staff.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Nhan@123"),
                SecurityStamp = string.Empty,
                FirstName = "Nhan",
                LastName = "Van",
                Dob = new DateTime(1997, 1, 2)
            });



            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = adminId,
                UserId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC")
            });


            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = traineeId,
                UserId = new Guid("1710DCE2-969A-435D-BBA4-DF3F325983DC")
            });


            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = trainerId,
                UserId = new Guid("AD80DCE2-969A-1313-BBA4-8D89325983DC")
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = traineeId,
                UserId = new Guid("1A84DCE2-123A-435D-BBA4-DF3F325983DC")
            });





            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", 
                  Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", 
                  Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );
        }
    }
}