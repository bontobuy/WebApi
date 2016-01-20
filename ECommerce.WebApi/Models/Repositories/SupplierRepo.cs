using System.Collections.Generic;
using System.Linq;

namespace ECommerce.WebApi.Models
{
    public class SupplierRepo : ISupplierRepo
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<SupplierSummaryViewModel> Retrieve()
        {
            var records = db.SupplierSummary.ToList();

            return records;
        }

        public SupplierViewModel Get(int id)
        {
            var record = db.SupplierDetails.Find(id);

            return record;
        }
    }
}