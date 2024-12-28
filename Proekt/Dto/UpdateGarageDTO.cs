using System.ComponentModel.DataAnnotations;

namespace Proekt.Data.Dto
{
    public class UpdateGarageDTO
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Location { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive number.")]
        public int Capacity { get; set; }

        [MaxLength(100)]
        public string City { get; set; }
    }
}