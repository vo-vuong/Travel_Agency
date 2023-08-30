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
    public class AccountSeeder
    {
        public static void Seed(Model.EF.TravelAgencyDbContext context)
        {
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
        }
    }
}
