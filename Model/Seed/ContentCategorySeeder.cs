using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Seed
{
    public class ContentCategorySeeder
    {
        public static void Seed(Model.EF.TravelAgencyDbContext context)
        {
            context.CONTENTCATEGORies.AddOrUpdate(
                contentCategory => contentCategory.ContentCategoryName,
                new CONTENTCATEGORY
                {
                    ContentCategoryName = "Du lịch trong nước"
                },
                new CONTENTCATEGORY
                {
                    ContentCategoryName = "Du lịch nước ngoài"
                }
            );
        }
    }
}
