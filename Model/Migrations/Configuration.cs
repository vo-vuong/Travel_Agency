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
