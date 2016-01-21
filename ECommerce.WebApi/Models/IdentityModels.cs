using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace ECommerce.WebApi.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<SupplierSummaryViewModel> SupplierSummary { get; set; }
        public DbSet<SupplierViewModel> SupplierDetails { get; set; }
        public DbSet<ProductSummaryViewModel> Productsummary { get; set; }
        public DbSet<ProductViewModel> ProductDetails { get; set; }
        public DbSet<BrandViewModel> BrandDetails { get; set; }

        //public DbSet<RatingViewModel> RatingDetails { get; set; }
        public DbSet<ProductComputerViewModel> ProductComputerDetails { get; set; }
        public DbSet<ProductApplianceViewModel> ProductApplianceDetails { get; set; }
        public DbSet<ProductMobileViewModel> ProductMobileDetails { get; set; }
        public DbSet<ProductManFashionViewModel> ProductManFashionDetails { get; set; }
        public DbSet<ProductWomanFashionViewModel> ProductWomanFashionDetails { get; set; }
    }
}