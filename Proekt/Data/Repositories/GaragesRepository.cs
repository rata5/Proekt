using Proekt.Data.Entities;
using Proekt.Data.Repositories.Interfaces;

namespace Proekt.Data.Repositories
{
    public class GaragesRepository : IGaragesRepository
    {
        private readonly DataContext _dataContext;

        public GaragesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void AddGarage(Garages garage)
        {
            _dataContext.Add(garage);
            _dataContext.SaveChanges();
        }
        public void DeleteGarage(int id)
        {
            var garage = _dataContext.Garages.Find(id);
            if (garage != null)
            {
                _dataContext.Garages.Remove(garage);
                _dataContext.SaveChanges();
            }
        }
        public Garages GetGarageById(int id)
        {
            return _dataContext.Garages.Find(id);
        }
        public IEnumerable<Garages> GetAllGarages()
        {
            return _dataContext.Garages.ToList();
        }
        public void UpdateGarage(Garages garage)
        {
            _dataContext.Garages.Update(garage);
            _dataContext.SaveChanges();
        }
    }
}