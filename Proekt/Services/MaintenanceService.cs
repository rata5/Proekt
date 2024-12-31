using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;
using Proekt.Services.Interfaces;
using Proekt.Dto;
using Proekt.Data.Dto;

namespace Proekt.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public IEnumerable<MaintenanceDto> GetAllMaintenances()
        {
            var maintenances = _maintenanceRepository.GetAllMaintenances();
            return maintenances.Select(maintenances => new MaintenanceDto
            {
                Id = maintenances.Id,
                ServiceType = maintenances.ServiceType,
                Date = maintenances.Date,
                Garages = maintenances.Garages.Select(g => new GaragesDto
                {
                    Id = g.Id
                }).ToList(),
                Cars = maintenances.Cars.Select(c => new CarsDto
                {
                    Id = c.Id,
                }).ToList()
            });
        }

        public MaintenanceDto GetMaintenanceById(int id)
        {
            var maintenance = _maintenanceRepository.GetMaintenanceById(id);
            if (maintenance == null)
            {
                return null;
            }
            return new MaintenanceDto
            {
                Id = maintenance.Id,
                ServiceType = maintenance.ServiceType,
                Date = maintenance.Date,
                Garages = maintenance.Garages.Select(g => new GaragesDto
                {
                    Id = g.Id
                }).ToList(),
                Cars = maintenance.Cars.Select(c => new CarsDto
                {
                    Id = c.Id
                }).ToList()
            };
        }

        public void AddMaintenance(MaintenanceDto maintenanceDto)
        {
            var maintenance = new Maintenance
            {
                Id = maintenanceDto.Id,
                ServiceType = maintenanceDto.ServiceType,
                Date = maintenanceDto.Date
            };
            _maintenanceRepository.AddMaintenance(maintenance);
        }

        public void UpdateMaintenance(MaintenanceDto maintenanceDto)
        {
            var maintenance = _maintenanceRepository.GetMaintenanceById(maintenanceDto.Id);
            if (maintenance != null)
            {
                maintenance.ServiceType = maintenanceDto.ServiceType;
                maintenance.Date = maintenanceDto.Date;
                _maintenanceRepository.UpdateMaintenance(maintenance);
            }
        }

        public void DeleteMaintenance(int id)
        {
            _maintenanceRepository.DeleteMaintenance(id);
        }
    }
}
