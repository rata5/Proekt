using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;
using Proekt.Dto;
using Proekt.Services.Interfaces;

namespace Proekt.Services
{
    public class GaragesService
    {
        private readonly IGaragesRepository _garagesService;
        public GaragesService(IGaragesRepository garagesService)
        {
            _garagesService = garagesService;
        }
        public IEnumerable<GaragesDto> GetAllGarages()
        {
            var garages = _garagesService.GetAllGarages();
            return garages.Select(garages = new GaragesDto
            {
                Id = garages.Id,
                Name = garages.Name,
                Location = garages.Location,
                City = garages.City,
                Capacity = garages.Capacity
            }).ToList();
        }
        public GetGarageById(int id)
        {
            var garage = _garagesService.GetGarageById(id);
            if (garage != null)
            {
                Id = garage.Id,
                Name = garage.Name,
                Location = garage.Location,
                City = garage.City,
                Capacity = garage.Capacity
            }
        }
        public void AddGarage(GaragesDto garageDto)
        {
            var garage = new Cars
            {
                Id = garageDto.Id,
                Name = garageDto.Name,
                Location = garageDto.Location,
                City = garageDto.City,
                Capacity = garageDto.Capacity
            };
            _garagesService.AddGarage(garage);
        }
        public void UpdateGarage(GaragesDto garageDto)
        {
            var garage = _garagesService.GetGarageById(garageDto.Id);
            if (garage != null) 
            {
                garageDto.Name = garage.Name;
                garageDto.Location = garage.Location;
                garageDto.City = garage.City;
                garageDto.Capacity = garageDto.Capacity;
                _garagesService.UpdateGarage(garage);
            }
        }
        public void DeleteGarage(int id)
        {
            _garagesService.DeleteGarage(id);
        }
    }
}