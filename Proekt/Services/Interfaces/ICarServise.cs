using Proekt.Data.Entities;
using Proekt.Dto;

namespace Proekt.Services.Interfaces
{
    public interface ICarServise
    {
        IEnumerable<CarsDto> GetAllCars();
        CarsDto GetCarById(int Id);
        void AddCar(CarsDto car);
        void UpdateCar(CarsDto car);
        void DeleteCar(int id);
    }
}
