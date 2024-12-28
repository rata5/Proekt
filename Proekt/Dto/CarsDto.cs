namespace Proekt.Dto
{
    public class CarsDto
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string LicensePlate { get; set; }

        public int GarageId { get; set; }
    }
}
