using Microsoft.EntityFrameworkCore;
using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Repository.Interfaces;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Repository
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Car> GetCar(int carId, bool trackChanges) =>
            await FindBy(c => c.Id.Equals(carId), trackChanges)
                .SingleOrDefaultAsync();

        public async Task<IEnumerable<Car>> GetCarsAsync(CarRequestParameters requestParameters, bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Make)
                .Skip((requestParameters.PageNumber - 1) * requestParameters.PageSize)
                .Take(requestParameters.PageSize)
                .Include(c => c.CarExtras)
                    .ThenInclude(e => e.Extra)
                .ToListAsync();
    }
}
