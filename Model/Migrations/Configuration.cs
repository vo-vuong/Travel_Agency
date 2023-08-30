namespace Model.Migrations
{
    using CommonModel.Common;
    using Model.EF;
    using Model.Seed;
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

            UserGroupSeeder.Seed(context);
            AccountSeeder.Seed(context);
            CategoryTourSeeder.Seed(context);
            TourSeeder.Seed(context);
            ContentCategorySeeder.Seed(context);
            ContentSeeder.Seed(context);
        }
    }
}
