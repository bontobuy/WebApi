using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.WebApi.Models
{
    [Table("ProductSummary")]
    public class ProductSummaryViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }

        [ForeignKey("SupplierId")]
        public SupplierSummaryViewModel Supplier { get; set; }
    }

    [Table("ProductDetails")]
    public class ProductViewModel : ProductSummaryViewModel
    {
        public string Highlights { get; set; }
    }
}