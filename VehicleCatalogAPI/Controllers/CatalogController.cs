using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Models.DTOs;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CatalogController(ILogger<CatalogController> logger, ApplicationDbContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("car")]
        public async Task<IActionResult> GetCars([FromQuery] CarRequestParameters requestParameters)
        {
            var cars = await _context.Cars
                .OrderBy(c => c.Make)
                .Skip((requestParameters.PageNumber - 1) * requestParameters.PageSize)
                .Take(requestParameters.PageSize)
                .Include(c => c.CarExtras)
                .ThenInclude(e => e.Extra)
                .ToListAsync();

            var carsDto = _mapper.Map<IEnumerable<CarDto>>(cars);

            return Ok(new { data = carsDto });
        }

        [HttpGet("extra")]
        public async Task<IActionResult> GetExtras()
        {
            var extras = await _context.Extras.ToListAsync();

            var extrasDto = _mapper.Map<IEnumerable<ExtraDto>>(extras);

            return Ok(extrasDto);
        }
    }
}
