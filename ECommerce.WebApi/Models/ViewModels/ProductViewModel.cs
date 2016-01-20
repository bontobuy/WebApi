using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.WebApi.Models.ViewModels
{
    [Table("ProductSummary")]
    public class ProductSummaryViewModel
    {
        [Key]
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