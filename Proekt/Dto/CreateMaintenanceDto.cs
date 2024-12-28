using System.ComponentModel.DataAnnotations;

namespace Proekt.Data.Dto
{
    public class CreateMaintenanceDTO
    {
        [Required]
        public int GarageId { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ServiceType { get; set; }

        [Required]
        public DateTime ScheduledDate { get; set; }
    }
}
