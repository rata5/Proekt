using System.ComponentModel.DataAnnotations;

namespace Proekt.Dto
{
    public class UpdateMaintenanceDTO
    {
        public int CarId { get; set; }
        public string ServiceType { get; set; }
        public DateTime ScheduledDate { get; set; }
        [Required]
        public int GarageId { get; set; }
    }
}
