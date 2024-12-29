using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;
using Proekt.Services.Interfaces;
using Proekt.Dto;

namespace Proekt.Services
{
    public class GaragesService : IGaragesService
    {
        private readonly IGaragesRepository _garageRepository;
        public GaragesService(IGaragesRepository garagesRepository)
        {
            _garageRepository = garagesRepository;
        }
        public IEnumerable<GaragesDto> GetAllGarages()
        {
            var garages = _garageRepository.GetAllGarages();
            return garages.Select(g => new GaragesDto
            {
                Id = g.Id,
                Name = g.Name,
                City = g.City,
                Location = g.Location,
                Capacity = g.Capacity
            });
        }
        public GaragesDto GetGarageById(int id)
        {
            var garage = _garageRepository.GetGarageById(id);
            if (garage == null)
            {
                return null;
            }
            return new GaragesDto
            {
                Id = garage.Id,
                Name = garage.Name,
                City = garage.City,
                Location = garage.Location,
                Capacity = garage.Capacity
            };
        }
        public void AddGarage(GaragesDto garageDto)
        {
            var garage = new Garages
            {
                Id = garageDto.Id,
                Name = garageDto.Name,
                City = garageDto.City,
                Location = garageDto.Location,
                Capacity = garageDto.Capacity
            };
            _garageRepository.AddGarage(garage);
        }
        public void UpdateGarage(GaragesDto garagesDto)
        {
            var garage = _garageRepository.GetGarageById(garagesDto.Id);
            if (garagesDto != null)
            {
                garagesDto.Name = garage.Name;
                garagesDto.City = garage.City;
                garagesDto.Capacity = garage.Capacity;
                garagesDto.Location = garage.Location;
                _garageRepository.UpdateGarage(garage);
            }
        }
        public void DeleteGarage(int id)
        {
            _garageRepository.DeleteGarage(id);
        }
    }
}
