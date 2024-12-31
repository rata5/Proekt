using Proekt.Data.Entities;
using Proekt.Dto;

namespace Proekt.Data.Dto
{
    public class MaintenanceDto
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }
        public int GarageId { get; set; }
        public int CarId { get; set; }
        public List<GaragesDto> Garages { get; set; } = new List<GaragesDto>();
        public List<CarsDto> Cars { get; set; } = new List<CarsDto>();
    }
}
