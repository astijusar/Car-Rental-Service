using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Repository.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetCarsAsync(CarRequestParameters requestParameters, bool trackChanges);
        Task<Car> GetCar(int carId, bool trackChanges);
    }
}
