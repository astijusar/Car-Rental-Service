using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Repository.Interfaces;

namespace VehicleCatalogAPI.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationDbContext _context;
        private ICarRepository _carRepository;

        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICarRepository Car
        {
            get
            {
                if (_carRepository == null)
                    _carRepository = new CarRepository(_context);

                return _carRepository;
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
