namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ABOUT",
                c => new
                    {
                        IDAbout = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Content = c.String(storeType: "ntext"),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.IDAbout);
            
            CreateTable(
                "dbo.ACCOUNT",
                c => new
                    {
                        IDAccount = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 32),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Address = c.String(maxLength: 255),
                        PhoneNumber = c.String(nullable: false, maxLength: 15, unicode: false),
                        BirthDay = c.DateTime(nullable: false),
                        Grener = c.Boolean(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        Image = c.String(maxLength: 255),
                        IDUserGroup = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.IDAccount)
                .ForeignKey("dbo.USERGROUP", t => t.IDUserGroup)
                .Index(t => t.IDUserGroup);
            
            CreateTable(
                "dbo.BILL",
                c => new
                    {
                        IDBill = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        IDTour = c.Int(),
                        IDAccount = c.Int(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.IDBill)
                .ForeignKey("dbo.ACCOUNT", t => t.IDAccount)
                .ForeignKey("dbo.TOUR", t => t.IDTour)
                .Index(t => t.IDTour)
                .Index(t => t.IDAccount);
            
            CreateTable(
                "dbo.TOUR",
                c => new
                    {
                        IDTour = c.Int(nullable: false, identity: true),
                        TourName = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, storeType: "ntext"),
                        Image = c.String(maxLength: 255),
                        policy = c.String(),
                        termsProvisions = c.String(),
                        Price = c.Decimal(precision: 18, scale: 0),
                        Quantity = c.Int(nullable: false),
                        Views = c.Int(),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        Time = c.String(nullable: false, maxLength: 100),
                        LocationStart = c.String(nullable: false, maxLength: 255),
                        IDCategory = c.Int(),
                    })
                .PrimaryKey(t => t.IDTour)
                .ForeignKey("dbo.CATEGORY_TOUR", t => t.IDCategory)
                .Index(t => t.IDCategory);
            
            CreateTable(
                "dbo.CATEGORY_TOUR",
                c => new
                    {
                        IDCategory = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IDCategory);
            
            CreateTable(
                "dbo.COMMENT",
                c => new
                    {
                        IDComment = c.Int(nullable: false, identity: true),
                        content = c.String(nullable: false, storeType: "ntext"),
                        DateCreated = c.DateTime(),
                        IDAccount = c.Int(),
                        IDTour = c.Int(),
                    })
                .PrimaryKey(t => t.IDComment)
                .ForeignKey("dbo.ACCOUNT", t => t.IDAccount)
                .ForeignKey("dbo.TOUR", t => t.IDTour)
                .Index(t => t.IDAccount)
                .Index(t => t.IDTour);
            
            CreateTable(
                "dbo.TOUREVALUATION",
                c => new
                    {
                        IDEvaluation = c.Int(nullable: false, identity: true),
                        Point = c.Int(nullable: false),
                        content = c.String(storeType: "ntext"),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        IDTour = c.Int(),
                    })
                .PrimaryKey(t => t.IDEvaluation)
                .ForeignKey("dbo.TOUR", t => t.IDTour)
                .Index(t => t.IDTour);
            
            CreateTable(
                "dbo.TOURSALE",
                c => new
                    {
                        SaleRate = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Status = c.Boolean(nullable: false),
                        IDSale = c.Int(),
                        IDTour = c.Int(),
                    })
                .PrimaryKey(t => new { t.SaleRate, t.Status })
                .ForeignKey("dbo.SALE", t => t.IDSale)
                .ForeignKey("dbo.TOUR", t => t.IDTour)
                .Index(t => t.IDSale)
                .Index(t => t.IDTour);
            
            CreateTable(
                "dbo.SALE",
                c => new
                    {
                        IDSale = c.Int(nullable: false, identity: true),
                        SaleName = c.String(nullable: false, maxLength: 50),
                        DateStart = c.DateTime(),
                        DateEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDSale);
            
            CreateTable(
                "dbo.CONTENT",
                c => new
                    {
                        IDContent = c.Int(nullable: false, identity: true),
                        ContentName = c.String(nullable: false, maxLength: 255),
                        body = c.String(storeType: "ntext"),
                        shortBody = c.String(maxLength: 500),
                        Image = c.String(maxLength: 255),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                        status = c.Boolean(nullable: false),
                        views = c.Int(nullable: false),
                        dateShow = c.DateTime(nullable: false),
                        IDContentCategory = c.Int(),
                        IDAccount = c.Int(),
                    })
                .PrimaryKey(t => t.IDContent)
                .ForeignKey("dbo.ACCOUNT", t => t.IDAccount)
                .ForeignKey("dbo.CONTENTCATEGORY", t => t.IDContentCategory)
                .Index(t => t.IDContentCategory)
                .Index(t => t.IDAccount);
            
            CreateTable(
                "dbo.CONTENTCATEGORY",
                c => new
                    {
                        IDContentCategory = c.Int(nullable: false, identity: true),
                        ContentCategoryName = c.String(nullable: false, maxLength: 255),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.IDContentCategory);
            
            CreateTable(
                "dbo.MESSAGE",
                c => new
                    {
                        IDMessage = c.Int(nullable: false, identity: true),
                        body = c.String(nullable: false, storeType: "ntext"),
                        DateCreated = c.DateTime(),
                        IDAccount = c.Int(),
                    })
                .PrimaryKey(t => t.IDMessage)
                .ForeignKey("dbo.ACCOUNT", t => t.IDAccount)
                .Index(t => t.IDAccount);
            
            CreateTable(
                "dbo.USERGROUP",
                c => new
                    {
                        IDUserGroup = c.String(nullable: false, maxLength: 20),
                        GroupName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.IDUserGroup);
            
            CreateTable(
                "dbo.MENU",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 30),
                        Link = c.String(maxLength: 255),
                        DisplayOrder = c.Int(),
                        Target = c.String(maxLength: 50),
                        Status = c.Boolean(),
                        ParentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SLIDE",
                c => new
                    {
                        IDSLIDE = c.Int(nullable: false, identity: true),
                        UrlSlide = c.String(maxLength: 255),
                        DateCreated = c.DateTime(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.IDSLIDE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ACCOUNT", "IDUserGroup", "dbo.USERGROUP");
            DropForeignKey("dbo.MESSAGE", "IDAccount", "dbo.ACCOUNT");
            DropForeignKey("dbo.CONTENT", "IDContentCategory", "dbo.CONTENTCATEGORY");
            DropForeignKey("dbo.CONTENT", "IDAccount", "dbo.ACCOUNT");
            DropForeignKey("dbo.TOURSALE", "IDTour", "dbo.TOUR");
            DropForeignKey("dbo.TOURSALE", "IDSale", "dbo.SALE");
            DropForeignKey("dbo.TOUREVALUATION", "IDTour", "dbo.TOUR");
            DropForeignKey("dbo.COMMENT", "IDTour", "dbo.TOUR");
            DropForeignKey("dbo.COMMENT", "IDAccount", "dbo.ACCOUNT");
            DropForeignKey("dbo.TOUR", "IDCategory", "dbo.CATEGORY_TOUR");
            DropForeignKey("dbo.BILL", "IDTour", "dbo.TOUR");
            DropForeignKey("dbo.BILL", "IDAccount", "dbo.ACCOUNT");
            DropIndex("dbo.MESSAGE", new[] { "IDAccount" });
            DropIndex("dbo.CONTENT", new[] { "IDAccount" });
            DropIndex("dbo.CONTENT", new[] { "IDContentCategory" });
            DropIndex("dbo.TOURSALE", new[] { "IDTour" });
            DropIndex("dbo.TOURSALE", new[] { "IDSale" });
            DropIndex("dbo.TOUREVALUATION", new[] { "IDTour" });
            DropIndex("dbo.COMMENT", new[] { "IDTour" });
            DropIndex("dbo.COMMENT", new[] { "IDAccount" });
            DropIndex("dbo.TOUR", new[] { "IDCategory" });
            DropIndex("dbo.BILL", new[] { "IDAccount" });
            DropIndex("dbo.BILL", new[] { "IDTour" });
            DropIndex("dbo.ACCOUNT", new[] { "IDUserGroup" });
            DropTable("dbo.SLIDE");
            DropTable("dbo.MENU");
            DropTable("dbo.USERGROUP");
            DropTable("dbo.MESSAGE");
            DropTable("dbo.CONTENTCATEGORY");
            DropTable("dbo.CONTENT");
            DropTable("dbo.SALE");
            DropTable("dbo.TOURSALE");
            DropTable("dbo.TOUREVALUATION");
            DropTable("dbo.COMMENT");
            DropTable("dbo.CATEGORY_TOUR");
            DropTable("dbo.TOUR");
            DropTable("dbo.BILL");
            DropTable("dbo.ACCOUNT");
            DropTable("dbo.ABOUT");
        }
    }
}
