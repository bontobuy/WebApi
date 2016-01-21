namespace ECommerce.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComputerApplianceMobileFashionProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductAppliance",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Model = c.String(),
                        Type = c.String(),
                        Variant = c.String(),
                        Functions = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductDetails", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductComputer",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Type = c.String(),
                        Series = c.String(),
                        Utility = c.String(),
                        ModelNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductDetails", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductManFashion",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        ClothingType = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductDetails", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductMobile",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Content = c.String(),
                        NumberOfSim = c.Int(nullable: false),
                        SimSize = c.String(),
                        OtherFeatures = c.String(),
                        CallFeatures = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductDetails", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductWomanFashion",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        ClothingType = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductDetails", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductFurniture",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Shape = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductDetails", t => t.ProductId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductFurniture", "ProductId", "dbo.ProductDetails");
            DropForeignKey("dbo.ProductWomanFashion", "ProductId", "dbo.ProductDetails");
            DropForeignKey("dbo.ProductMobile", "ProductId", "dbo.ProductDetails");
            DropForeignKey("dbo.ProductManFashion", "ProductId", "dbo.ProductDetails");
            DropForeignKey("dbo.ProductComputer", "ProductId", "dbo.ProductDetails");
            DropForeignKey("dbo.ProductAppliance", "ProductId", "dbo.ProductDetails");
            DropIndex("dbo.ProductFurniture", new[] { "ProductId" });
            DropIndex("dbo.ProductWomanFashion", new[] { "ProductId" });
            DropIndex("dbo.ProductMobile", new[] { "ProductId" });
            DropIndex("dbo.ProductManFashion", new[] { "ProductId" });
            DropIndex("dbo.ProductComputer", new[] { "ProductId" });
            DropIndex("dbo.ProductAppliance", new[] { "ProductId" });
            DropTable("dbo.ProductFurniture");
            DropTable("dbo.ProductWomanFashion");
            DropTable("dbo.ProductMobile");
            DropTable("dbo.ProductManFashion");
            DropTable("dbo.ProductComputer");
            DropTable("dbo.ProductAppliance");
        }
    }
}
