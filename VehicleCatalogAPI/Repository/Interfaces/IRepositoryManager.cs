namespace VehicleCatalogAPI.Repository.Interfaces
{
    public interface IRepositoryManager
    {
        ICarRepository Car { get; }
        void Save();
    }
}
