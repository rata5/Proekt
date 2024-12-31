using Proekt.Data.Dto;
using Proekt.Dto;

namespace Proekt.Services.Interfaces
{
    using System.Collections.Generic;
    public interface IMaintenanceService
    {
        IEnumerable<MaintenanceDto> GetAllGarages();
        MaintenanceDto GetGarageById(int id);
        void AddGarage(MaintenanceDto garage);
        void UpdateGarage(MaintenanceDto garage);
        void DeleteGarage(int id);
    }
}
