using Proekt.Data.Entities;

namespace Proekt.Data.Repositories.Interfaces
{
    public interface ICarsRepository
    {
        IEnumerable<Cars> GetAllCars();
        Cars GetCarById(int Id);
        void AddCar(Cars car);
        void UpdateCar(Cars car);
        void DeleteCar(int id);
    }
}