using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.WebApi.Models
{
    [Table("BrandDetails")]
    public class BrandViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        public string Name { get; set; }

        //public IEnumerable<ProductSummaryViewModel> BrandProduct { get; set; }
    }
}