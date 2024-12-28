using System.ComponentModel.DataAnnotations;

namespace Proekt.Data.Dto
{
    public class CreateGarageDTO
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Location { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive number.")]
        public int Capacity { get; set; }
    }
}