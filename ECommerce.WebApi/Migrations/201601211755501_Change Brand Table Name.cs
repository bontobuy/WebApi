namespace ECommerce.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBrandTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BrandViewModels", newName: "BrandDetails");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.BrandDetails", newName: "BrandViewModels");
        }
    }
}
