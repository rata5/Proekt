using Proekt.Data.Entities;

namespace Proekt.Data.Repositories.Interfaces
{
    public interface IGaragesRepository
    {
        IEnumerable<Garages> GetAllGarages();
        Garages GetGarageById(int id);
        void AddGarage(Garages garage);
        void UpdateGarage(Garages garage);
        void DeleteGarage(int id);
    }
}
