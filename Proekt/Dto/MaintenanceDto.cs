using Proekt.Dto;

namespace Proekt.Data.Dto
{
    public class MaintenanceDto
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }

        public List<GaragesDto> Garage { get; set; } = new List<GaragesDto>();
        public List<CarsDto> Car { get; set; } = new List<CarsDto>();
    }
}
