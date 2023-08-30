using CommonModel.Common;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Seed
{
    public class UserGroupSeeder
    {
        public static void Seed(Model.EF.TravelAgencyDbContext context)
        {
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
        }
    }
}
