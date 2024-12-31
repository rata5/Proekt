using Proekt.Data.Dto;
using Proekt.Dto;

namespace Proekt.Services.Interfaces
{
    using System.Collections.Generic;
    public interface IMaintenanceService
    {
        IEnumerable<MaintenanceDto> GetAllMaintenances();
        MaintenanceDto GetMaintenanceById(int id);
        void AddMaintenance(MaintenanceDto maintenanceDto);
        void UpdateMaintenance(MaintenanceDto maintenanceDto);
        void DeleteMaintenance(int id);
    }
}
