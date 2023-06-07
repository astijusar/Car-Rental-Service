using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Repository.Extensions
{
    public static class CarRepositoryExtensions
    {
        public static IQueryable<Car> OffsetPage(this IQueryable<Car> cars, CarRequestParameters parameters) =>
            cars.Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize);

        public static IQueryable<Car> FilterCars(this IQueryable<Car> cars, CarRequestParameters parameters)
        {
            cars = cars.Where(c => c.Year >= parameters.YearMin && c.Year <= parameters.YearMax &&
                                   c.Power >= parameters.PowerMin && c.Power <= parameters.PowerMax);

            if (parameters.Make != null)
            {
                cars = cars.Where(c => c.Make.Equals(parameters.Make));
            }

            if (parameters.Model != null)
            {
                cars = cars.Where(c => c.Model.Equals(parameters.Model));
            }

            if (parameters.Color != null)
            {
                cars = cars.Where(c => c.Color.Equals(parameters.Color));
            }

            if (parameters.Type != null)
            {
                cars = cars.Where(c => c.Type.Equals(parameters.Type));
            }

            if (parameters.Transmission != null)
            {
                cars = cars.Where(c => c.Transmission.Equals(parameters.Transmission));
            }

            if (parameters.Electric != null)
            {
                cars = cars.Where(c => c.Electric.Equals(parameters.Electric));
            }

            if (parameters.Seats != null)
            {
                cars = cars.Where(c => c.Seats.Equals(parameters.Seats));
            }

            if (parameters.Doors != null)
            {
                cars = cars.Where(c => c.Doors.Equals(parameters.Doors));
            }

            return cars;
        }
    }
}
