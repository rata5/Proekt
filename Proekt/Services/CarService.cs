using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;
using Proekt.Services.Interfaces;
using Proekt.Dto;


namespace Proekt.Services
{
    public class CarService : ICarService
    {
        private readonly ICarsRepository _carsRepository;
        public CarService(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public IEnumerable<CarsDto> GetAllCars()
        {
            var cars = _carsRepository.GetAllCars();
            return cars.Select(car => new CarsDto
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear,
                LicensePlate = car.LicensePlate,
                Garage = car.Garages.Select(g => new GaragesDto
                {
                    Id = g.Id
                }).ToList()
            });
        }
        public CarsDto GetCarById(int id)
        {
            var car = _carsRepository.GetCarById(id);
            if (car == null)
            {
                return null;
            }
            return new CarsDto
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear,
                LicensePlate = car.LicensePlate,
                Garage = car.Garages.Select(g => new GaragesDto
                {
                    Id = g.Id
                }).ToList()
            };
        }
        public void AddCar(CarsDto carsDto)
        {
            var car = new Cars
            {
                Id = carsDto.Id,
                Make = carsDto.Make,
                Model = carsDto.Model,
                ProductionYear = carsDto.ProductionYear,
                LicensePlate = carsDto.LicensePlate
            };
            _carsRepository.AddCar(car);
        }
        public void UpdateCar(CarsDto carsDto)
        {
            var car = _carsRepository.GetCarById(carsDto.Id);
            if (carsDto != null)
            {
                carsDto.Make = car.Make;
                carsDto.Model = car.Model;
                carsDto.LicensePlate = car.LicensePlate;
                carsDto.ProductionYear = car.ProductionYear;
                _carsRepository.UpdateCar(car);
            }
        }
        public void DeleteCar(int id)
        {
            _carsRepository.DeleteCar(id);
        }
    }
}