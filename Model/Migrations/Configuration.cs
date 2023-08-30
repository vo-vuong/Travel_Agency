namespace Model.Migrations
{
    using CommonModel.Common;
    using Model.EF;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.EF.TravelAgencyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Model.EF.TravelAgencyDbContext";
        }

        protected override void Seed(Model.EF.TravelAgencyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.USERGROUPs.AddOrUpdate(
                new USERGROUP
                {
                    IDUserGroup = "ADMIN",
                    GroupName = "ADMIN"
                },
                new USERGROUP
                {
                    IDUserGroup = "MEMBER",
                    GroupName = "MEMBER"
                });

            context.ACCOUNTs.AddOrUpdate(
                account => account.UserName,
                new ACCOUNT
                {
                    UserName = "admin",
                    Password = Encryptor.MD5Hash("12345678"),
                    Name = "admin",
                    PhoneNumber = "0977816676",
                    BirthDay = DateTime.Now,
                    Status = true,
                    IDUserGroup = "ADMIN"
                },
                new ACCOUNT
                {
                    UserName = "member",
                    Password = Encryptor.MD5Hash("12345678"),
                    Name = "member",
                    PhoneNumber = "0977816676",
                    BirthDay = DateTime.Now,
                    Status = true,
                    IDUserGroup = "MEMBER"
                }
            );

            context.CATEGORY_TOUR.AddOrUpdate(
                categoryTour => categoryTour.CategoryName,
                new CATEGORY_TOUR
                {
                    CategoryName = "Tour trong nước"
                },
                new CATEGORY_TOUR
                {
                    CategoryName = "Tour nước ngoài"
                }
            );

            context.TOURs.AddOrUpdate(
                tour => tour.TourName,
                new TOUR
                {
                    TourName = "Đà nẵng",
                    Description = "Đà nẵng đẹp quá",
                    Image = "/Data/images/Tour/danang.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay đà nẵng",
                    IDCategory = 1,
                    Shortbody = "Đà nẵng đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Đà Lạt",
                    Description = "Đà Lạt đẹp quá",
                    Image = "/Data/images/Tour/dalat.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Đà Lạt",
                    IDCategory = 1,
                    Shortbody = "Đà Lạt đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Hội an",
                    Description = "Hội an đẹp quá",
                    Image = "/Data/images/Tour/hoian.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Hội an",
                    IDCategory = 1,
                    Shortbody = "Hội an đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Huế",
                    Description = "Huế đẹp quá",
                    Image = "/Data/images/Tour/hue.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay huế",
                    IDCategory = 1,
                    Shortbody = "Huế đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Nha trang",
                    Description = "Nha trang đẹp quá",
                    Image = "/Data/images/Tour/nhatrang.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Nha trang",
                    IDCategory = 1,
                    Shortbody = "Nha trang đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Phú quốc",
                    Description = "Huế đẹp quá",
                    Image = "/Data/images/Tour/phuquoc.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Phú quốc",
                    IDCategory = 1,
                    Shortbody = "Phú quốc đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Hạ long",
                    Description = "Hạ long đẹp quá",
                    Image = "/Data/images/Tour/halong.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Hạ long",
                    IDCategory = 1,
                    Shortbody = "Hạ long đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Ninh bình",
                    Description = "Huế đẹp quá",
                    Image = "/Data/images/Tour/ninhbinh.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Ninh bình",
                    IDCategory = 1,
                    Shortbody = "Ninh bình đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Italia",
                    Description = "Italia đẹp quá",
                    Image = "/Data/images/Tour/italia.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Italia",
                    IDCategory = 2,
                    Shortbody = "Italia đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Singapore",
                    Description = "Singapore đẹp quá",
                    Image = "/Data/images/Tour/singapore.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Singapore",
                    IDCategory = 2,
                    Shortbody = "Singapore đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Seoul",
                    Description = "Seoul đẹp quá",
                    Image = "/Data/images/Tour/seoul.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Seoul",
                    IDCategory = 2,
                    Shortbody = "Seoul đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Trung Quốc",
                    Description = "Trung Quốc đẹp quá",
                    Image = "/Data/images/Tour/trungquoc.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Trung Quốc",
                    IDCategory = 2,
                    Shortbody = "Trung Quốc đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Thuỵ Sĩ",
                    Description = "Thuỵ Sĩ đẹp quá",
                    Image = "/Data/images/Tour/thuysi.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Thuỵ Sĩ",
                    IDCategory = 2,
                    Shortbody = "Thuỵ Sĩ đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Scotland",
                    Description = "Scotland đẹp quá",
                    Image = "/Data/images/Tour/scotland.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Scotland",
                    IDCategory = 2,
                    Shortbody = "Scotland đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Nhật bản",
                    Description = "Nhật bản đẹp quá",
                    Image = "/Data/images/Tour/nhatban.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Nhật bản",
                    IDCategory = 2,
                    Shortbody = "Nhật bản đẹp quá, quá đẹp"
                },
                new TOUR
                {
                    TourName = "Pháp",
                    Description = "Pháp đẹp quá",
                    Image = "/Data/images/Tour/phap.jpg",
                    Price = 123456,
                    Quantity = 10,
                    Status = true,
                    DateStart = DateTime.Now,
                    Time = "3 ngày 2 đêm",
                    LocationStart = "Sân bay Pháp",
                    IDCategory = 2,
                    Shortbody = "Pháp đẹp quá, quá đẹp"
                }
            );
        }
    }
}
