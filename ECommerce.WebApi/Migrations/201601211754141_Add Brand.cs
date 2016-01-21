namespace ECommerce.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBrand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrandViewModels",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BrandViewModels");
        }
    }
}
