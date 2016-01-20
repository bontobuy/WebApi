namespace ECommerce.WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ECommerce.WebApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerce.WebApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ECommerce.WebApi.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.SupplierSummary.AddOrUpdate(x => x.SupplierId,
                new SupplierSummaryViewModel()
                {
                    SupplierId = 1,
                    Name = "Courts"
                },
                new SupplierSummaryViewModel()
                {
                    SupplierId = 2,
                    Name = "Cash and Carry"
                },
                new SupplierSummaryViewModel()
                {
                    SupplierId = 3,
                    Name = "Galaxy"
                }
                );
        }
    }
}