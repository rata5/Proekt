using Proekt.Data.Entities;

namespace Proekt.Data.Repositories.Interfaces
{
    public interface IMaintenanceRepository
    {
        IEnumerable<Maintenance> GetAllMaintenances();
        Maintenance GetMaintenanceById(int id);
        IEnumerable<Maintenance> GetMaintenanceByCarId(int carId);
        void AddMaintenance(Maintenance maintenance);
        void UpdateMaintenance(Maintenance maintenance);
        void DeleteMaintenance(int id);
    }
}
