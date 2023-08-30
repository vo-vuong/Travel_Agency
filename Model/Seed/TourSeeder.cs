using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Seed
{
    public class TourSeeder
    {
        public static void Seed(Model.EF.TravelAgencyDbContext context)
        {
            context.TOURs.AddOrUpdate(
                tour => tour.TourName,
                new TOUR
                {
                    TourName = "Đà nẵng",
                    Description = "Đà nẵng đẹp quá",
                    Image = "/Data/images/Seed/Tour/danang.jpg",
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
                    Image = "/Data/images/Seed/Tour/dalat.jpg",
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
                    Image = "/Data/images/Seed/Tour/hoian.jpg",
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
                    Image = "/Data/images/Seed/Tour/hue.jpg",
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
                    Image = "/Data/images/Seed/Tour/nhatrang.jpg",
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
                    Image = "/Data/images/Seed/Tour/phuquoc.jpg",
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
                    Image = "/Data/images/Seed/Tour/halong.jpg",
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
                    Image = "/Data/images/Seed/Tour/ninhbinh.jpg",
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
                    Image = "/Data/images/Seed/Tour/italia.jpg",
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
                    Image = "/Data/images/Seed/Tour/singapore.jpg",
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
                    Image = "/Data/images/Seed/Tour/seoul.jpg",
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
                    Image = "/Data/images/Seed/Tour/trungquoc.jpg",
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
                    Image = "/Data/images/Seed/Tour/thuysi.jpg",
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
                    Image = "/Data/images/Seed/Tour/scotland.jpg",
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
                    Image = "/Data/images/Seed/Tour/nhatban.jpg",
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
                    Image = "/Data/images/Seed/Tour/phap.jpg",
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
