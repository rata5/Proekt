using System.ComponentModel.DataAnnotations;

namespace Proekt.Data.Dto
{
    public class ResponseGarageDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}