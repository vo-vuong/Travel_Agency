namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_shortBodyTour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TOUR", "Shortbody", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TOUR", "Shortbody");
        }
    }
}
