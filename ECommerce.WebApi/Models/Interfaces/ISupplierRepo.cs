using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.WebApi.Models
{
    public interface ISupplierRepo
    {
        IEnumerable<SupplierSummaryViewModel> Retrieve();
        SupplierViewModel Get(int id);
    }
}