using Microsoft.EntityFrameworkCore;
using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Repository.Extensions;
using VehicleCatalogAPI.Repository.Interfaces;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Repository
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Car> GetCarAsync(int carId, bool trackChanges) =>
            await FindBy(c => c.Id.Equals(carId), trackChanges)
                .SingleOrDefaultAsync();

        public async Task<(IEnumerable<Car>, int totalCount)> GetCarsAsync(CarRequestParameters requestParameters, bool trackChanges)
        {
            var query = FindAll(trackChanges)
                .OrderBy(c => c.Make)
                .FilterCars(requestParameters)
                .Include(c => c.CarExtras)
                    .ThenInclude(e => e.Extra);

            var totalCount = await query.CountAsync();

            var cars = await query
                .OffsetPage(requestParameters)
                .ToListAsync();

            return(cars, totalCount);
        }
    }
}
