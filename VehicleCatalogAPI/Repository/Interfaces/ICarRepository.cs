using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Repository.Interfaces
{
    public interface ICarRepository
    {
        Task<(IEnumerable<Car>, int totalCount)> GetCarsAsync(CarRequestParameters requestParameters, bool trackChanges);
        Task<Car> GetCarAsync(int carId, bool trackChanges);
    }
}
