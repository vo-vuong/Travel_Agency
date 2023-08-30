using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Seed
{
    public class CategoryTourSeeder
    {
        public static void Seed(Model.EF.TravelAgencyDbContext context)
        {
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
        }
    }
}
