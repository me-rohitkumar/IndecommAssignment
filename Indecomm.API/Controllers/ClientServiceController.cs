using Indecomm.ApiServices.Repository;
using Indecomm.BusinessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Indecomm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientServiceController : ControllerBase
    {
        IPropertyRepository propertyRepository;
        public ClientServiceController(IPropertyRepository _propertyRepository )
        {
            propertyRepository = _propertyRepository;
        }

        // GET: api/PropertyResult
        [HttpGet]
        [Route("GetAllProperty")]
        public IActionResult GetProperties()
        {
            try
            {
                var properties = propertyRepository.GetPropertyDetails();
                if (properties == null)
                {
                    return NotFound();
                }

                return Ok(properties);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        // POST: api/PropertyResult
        [HttpPost]
        [Route("AddProperty")]
        public async Task<IActionResult> AddProperty([FromBody]PropertyModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var postId = await propertyRepository.AddProperty(model);
                    if (postId > 0)
                    {
                        return Ok(postId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }
    }
}
