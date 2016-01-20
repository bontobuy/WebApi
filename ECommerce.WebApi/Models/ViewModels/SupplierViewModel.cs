using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.WebApi.Models
{
    [Table("SupplierSummary")]
    public class SupplierSummaryViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductSummaryViewModel> Products { get; set; }
    }

    [Table("SupplierDetails")]
    public class SupplierViewModel : SupplierSummaryViewModel
    {
        public string Website { get; set; }
    }
}