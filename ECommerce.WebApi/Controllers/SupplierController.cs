using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.OData;
using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Controllers
{
    public class SupplierController : ApiController
    {
        private readonly ISupplierRepo _repository;

        public SupplierController(ISupplierRepo repo)
        {
            _repository = repo;
        }

        [EnableQuery()]
        [ResponseType(typeof(SupplierSummaryViewModel))]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_repository.Retrieve().AsQueryable());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [ResponseType(typeof(SupplierViewModel))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                if (id < 0)
                    return BadRequest("id cannot be null");

                SupplierViewModel item = _repository.Get(id);
                if (item == null)
                    return NotFound();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}