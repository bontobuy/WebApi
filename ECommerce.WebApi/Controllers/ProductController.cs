using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.OData;
using ECommerce.WebApi.Attributes;
using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductRepo _repository;

        public ProductController(IProductRepo repo)
        {
            _repository = repo;
        }

        [EnableQuery()]
        [ResponseType(typeof(ProductSummaryViewModel))]
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

        [ResponseType(typeof(ProductViewModel))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                if (id < 0)
                    return BadRequest();

                ProductViewModel item = _repository.Get(id);
                if (item == null)
                    return NotFound();

                return Ok(item);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [ValidateModel]
        public IHttpActionResult Post([FromBody]ProductViewModel item)
        {
            try
            {
                if (item == null)
                    return BadRequest("Product cannot be null");

                if (item.ProductId < 0)
                    return BadRequest("Invalid identifier");

                var newItem = _repository.Create(item);
                if (newItem == null)
                    return Conflict();

                return Created<ProductViewModel>(Request.RequestUri + newItem.ToString(),
                    newItem);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [ValidateModel]
        public IHttpActionResult Put(int id, [FromBody]ProductViewModel item)
        {
            try
            {
                if (item == null)
                    return BadRequest("Product cannot be null");
                if (item.ProductId < 0)
                    return BadRequest("Invalid identifier");

                var updatedItem = _repository.Update(id, item);
                if (updatedItem == null)
                    return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}