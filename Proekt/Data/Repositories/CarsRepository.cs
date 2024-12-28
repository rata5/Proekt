using Microsoft.EntityFrameworkCore;
using Proekt.Controllers;
using Proekt.Data.Entities;
using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;

namespace Proekt.Data.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private DataContext _dataContext;
        public CarsRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public void AddCar(Cars car)
        {
            _dataContext.Add(car);
            _dataContext.SaveChanges();
        }
        public void DeleteCar(int id)
        {
            var car = _dataContext.Cars.Find(id);
            if (car != null) 
            {
                _dataContext.Remove(car);
                _dataContext.SaveChanges();
            }
        }
        public IEnumerable<Cars> GetAllCars()
        {
            return _dataContext.Cars.Include(c => c.Garages).ToList() ?? new List<Cars>();
        }
        public Cars GetCarById(int carId)
        {
            return _dataContext.Cars.Find(carId);
        }
        public void UpdateCar(Cars car)
        {
            _dataContext.Cars.Update(car);
            _dataContext.SaveChanges();
        }
    }
}
