using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Models.DTOs;
using VehicleCatalogAPI.Repository.Interfaces;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public CatalogController(ILogger<CatalogController> logger, IRepositoryManager repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("car")]
        public async Task<IActionResult> GetCars([FromQuery] CarRequestParameters requestParameters)
        {
            var cars = await _repository.Car.GetCarsAsync(requestParameters, false);

            var carsDto = _mapper.Map<IEnumerable<CarDto>>(cars);

            return Ok(new { data = carsDto });
        }

        /*[HttpGet("extra")]
        public async Task<IActionResult> GetExtras()
        {
            var extras = await _context.Extras.ToListAsync();

            var extrasDto = _mapper.Map<IEnumerable<ExtraDto>>(extras);

            return Ok(extrasDto);
        }*/
    }
}
