using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleCatalogAPI.Models;

namespace VehicleCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;
        private readonly ApplicationDbContext _context;

        [HttpGet]
        public IActionResult GetVehicles()
        {
            return Ok("All vehicles");
        }
    }
}
