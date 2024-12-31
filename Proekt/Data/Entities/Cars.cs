namespace Proekt.Data.Entities
{
    public class Cars
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string LicensePlate { get; set; }
        public int GarageId { get; set; }
        
        public List<Garages>? Garages { get; set; }

    }
}
