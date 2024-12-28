using Proekt.Data.Entities;

namespace Proekt.Data.Dto
{
    public class ResponseMaintenanceDTO
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string ServiceType { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int GarageId { get; set; }
        public string GarageName { get; set; }
    }
}