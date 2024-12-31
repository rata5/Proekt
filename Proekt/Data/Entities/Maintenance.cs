namespace Proekt.Data.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }
        public int GarageId { get; set; }
        public List<Garages> Garages { get; set; }
        public int CarId { get; set; }
        public List<Cars> Cars { get; set; }
    }
}