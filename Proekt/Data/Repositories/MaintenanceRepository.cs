using Microsoft.EntityFrameworkCore;
using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;

namespace Proekt.Data.Repositories
{
    public class MaintenanceRepository:IMaintenanceRepository
    {
        private readonly DataContext _dataContext;
        public MaintenanceRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<Maintenance> GetAllMaintenances()
        {
            return _dataContext.Maintenances.Include(m=>m.Cars).Include(m=>m.Garages).ToList();
        }
        public Maintenance GetMaintenanceById(int id)
        {
            return _dataContext.Maintenances.Include(m => m.Cars).Include(m => m.Garages).FirstOrDefault(m=>m.Id == id);
        }
        public IEnumerable<Maintenance> GetMaintenanceByCarId(int carId)
        {
            return _dataContext.Maintenances.Where(m=>m.CarId == carId).Include(m=>m.Garages).ToList();
        }
        public void AddMaintenance(Maintenance maintenance)
        {
            _dataContext.Maintenances.Add(maintenance);
            _dataContext.SaveChanges();
        }
        public void UpdateMaintenance(Maintenance maintenance)
        {
            _dataContext.Update(maintenance);
            _dataContext.SaveChanges();
        }
        public void DeleteMaintenance(int id)
        {
            var maintenance = _dataContext.Maintenances.Find(id);
            if (maintenance != null)
            {
                _dataContext.Maintenances.Remove(maintenance);
                _dataContext.SaveChanges();
            }
        }
    }
}
