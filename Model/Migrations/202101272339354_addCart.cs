namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BILL", "IDAccount", "dbo.ACCOUNT");
            DropIndex("dbo.BILL", new[] { "IDAccount" });
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CreatedDate = c.DateTime(),
                        IDAccount = c.Int(nullable: false),
                        ShipName = c.String(maxLength: 50),
                        ShipMobile = c.String(maxLength: 50),
                        ShipAddress = c.String(maxLength: 50),
                        ShipEmail = c.String(maxLength: 50),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ACCOUNT", t => t.IDAccount, cascadeDelete: true)
                .Index(t => t.IDAccount);
            
            AddColumn("dbo.BILL", "IDOrder", c => c.Long());
            AddColumn("dbo.BILL", "Order_ID", c => c.Long());
            CreateIndex("dbo.BILL", "Order_ID");
            AddForeignKey("dbo.BILL", "Order_ID", "dbo.Order", "ID");
            DropColumn("dbo.BILL", "IDAccount");
            DropColumn("dbo.BILL", "DateCreated");
            DropColumn("dbo.BILL", "DateModified");
            DropColumn("dbo.BILL", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BILL", "Status", c => c.Boolean());
            AddColumn("dbo.BILL", "DateModified", c => c.DateTime());
            AddColumn("dbo.BILL", "DateCreated", c => c.DateTime());
            AddColumn("dbo.BILL", "IDAccount", c => c.Int());
            DropForeignKey("dbo.BILL", "Order_ID", "dbo.Order");
            DropForeignKey("dbo.Order", "IDAccount", "dbo.ACCOUNT");
            DropIndex("dbo.Order", new[] { "IDAccount" });
            DropIndex("dbo.BILL", new[] { "Order_ID" });
            DropColumn("dbo.BILL", "Order_ID");
            DropColumn("dbo.BILL", "IDOrder");
            DropTable("dbo.Order");
            CreateIndex("dbo.BILL", "IDAccount");
            AddForeignKey("dbo.BILL", "IDAccount", "dbo.ACCOUNT", "IDAccount");
        }
    }
}
