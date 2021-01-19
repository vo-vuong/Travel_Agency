using AutoMapper;
using Model.EF;
using TravelAgency.Models;

namespace TravelAgency.Mappings
{
    public class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<TOUR, TourViewModel>();
            Mapper.CreateMap<ACCOUNT, AccountViewModel>();
            Mapper.CreateMap<BILL, BillViewModel>();
            Mapper.CreateMap<CATEGORY_TOUR, CategoryTourViewModel>();
            Mapper.CreateMap<COMMENT, CommentViewModel>();
            Mapper.CreateMap<CONTENT, ContentViewModel>();
            Mapper.CreateMap<MESSAGE, MessageViewModel>();
            Mapper.CreateMap<SALE, SaleViewModel>();
            Mapper.CreateMap<TOUREVALUATION, TourEvaluationViewModel>();
            Mapper.CreateMap<TOURSALE, TourSaleViewModel>();
            Mapper.CreateMap<USERGROUP, UserGroupViewModel>();
        }
    }
}