using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using FieryRestaurent.LoggingService;
using FieryRestaurent.ServiceLayer.SupplierService;
using FieryRestaurent_Api.Filter;
using FieryRestaurent_Api.Wrapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;

namespace FieryRestaurent_Service.Controllers
{
    [EnableCors("Supplier")]
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService Service;
        private readonly ILoggerManager _logger;

        public SuppliersController(ISupplierService Service, ILoggerManager _logger)
        {
            this.Service = Service;
            this._logger = _logger;
        }

        [HttpPost]
        [Route("Supplier")]
        public IActionResult Post(SupplierDto SupplierDto)
        {
            _logger.LogDebug("Posting Supplier..........");
            try
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogCritical($"Supplier{SupplierDto}NotAdded");
                    return NotFound("Invalid Supplier data");
                }
               Supplier supplier = Service.Post(SupplierDto);

                // status code - 201/location/data
                return Created($"api/FieryRestaurent/Supplier/{supplier.SupplierID}", supplier);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("View")]
        [EnableQuery]
        public IActionResult Get()
        {
            _logger.LogInfo("Supplier get viewed");
            try
            {
                List<SupplierDto> suppliers = Service.Get();
                return Ok(suppliers.AsQueryable());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("View/Page")]
       
        public IActionResult Get([FromQuery] PaginationFilter filter)
        {
            _logger.LogInfo("Supplier get viewed");
            try
            {
                var response = Service.Get();
                var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
                var pagedData = response
                                       .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                                       .Take(validFilter.PageSize)
                                       .ToList();
                var totalRecords =  response.Count();
                return Ok(new PagedResponse<List<SupplierDto>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // get Supplier by id
        // .../api/Supplier/1

        [HttpGet]
        [Route("Id")]
        public IActionResult Get(Guid SupplierID)
        {
            _logger.LogDebug("Supplier get viewed.......");
            SupplierDto p = Service.Get(SupplierID);
            try
            {
                if (p == null) // not found
                {
                    _logger.LogCritical($"Supplier{SupplierID}NotAdded");

                    // return http status code 404

                    return NotFound();

                }
                else //found
                {
                    // return http status code 200 with data
                    return Ok(new Response<SupplierDto>(p));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
