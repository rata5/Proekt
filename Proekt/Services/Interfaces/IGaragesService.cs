using Proekt.Data.Entities;
using Proekt.Dto;

namespace Proekt.Services.Interfaces
{
    public interface IGaragesService
    {
        IEnumerable<GaragesDto> GetAllGarages();
        GaragesDto GetGarageById(int id);
        GaragesDto GetGarageByCity(string city);
        void AddGarage(GaragesDto garage);
        void UpdateGarage(GaragesDto garage);
        void DeleteGarage(int id);

    }
}
