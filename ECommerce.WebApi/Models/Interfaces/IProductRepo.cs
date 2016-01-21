using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.WebApi.Models
{
    public interface IProductRepo
    {
        IEnumerable<ProductSummaryViewModel> Retrieve();
        ProductViewModel Get(int id);
        ProductViewModel Create(ProductViewModel item);
        ProductViewModel Update(int id, ProductViewModel item);
        void Remove(int id);
    }
}