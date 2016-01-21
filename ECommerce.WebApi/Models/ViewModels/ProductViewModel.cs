using System.Collections.Generic;
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

        //   public int BrandId { get; set; }
        public string Name { get; set; }

        [ForeignKey("SupplierId")]
        public SupplierSummaryViewModel Supplier { get; set; }

        //[ForeignKey("BrandId")]
        //public BrandViewModel ProductBrand { get; set; }
    }

    [Table("ProductDetails")]
    public class ProductViewModel : ProductSummaryViewModel
    {
        public string Highlights { get; set; }
    }

    [Table("ProductComputer")]
    public class ProductComputerViewModel : ProductViewModel
    {
        public string Type { get; set; }
        public string Series { get; set; }
        public string Utility { get; set; }
        public int ModelNumber { get; set; }
    }

    [Table("ProductMobile")]
    public class ProductMobileViewModel : ProductViewModel
    {
        public string Content { get; set; }
        public int NumberOfSim { get; set; }
        public string SimSize { get; set; }
        public string OtherFeatures { get; set; }
        public string CallFeatures { get; set; }
    }

    [Table("ProductFurniture")]
    public class ProductFurnitureViewModel : ProductViewModel
    {
        public int Type { get; set; }
        public string Shape { get; set; }
    }

    [Table("ProductAppliance")]
    public class ProductApplianceViewModel : ProductViewModel
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string Variant { get; set; }
        public string Functions { get; set; }
    }

    [Table("ProductManFashion")]
    public class ProductManFashionViewModel : ProductViewModel
    {
        public int Size { get; set; }
        public string ClothingType { get; set; }
    }

    [Table("ProductWomanFashion")]
    public class ProductWomanFashionViewModel : ProductViewModel
    {
        public int Size { get; set; }
        public string ClothingType { get; set; }
    }
}