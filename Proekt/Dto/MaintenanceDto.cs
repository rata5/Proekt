namespace Proekt.Data.Dto
{
    public class MaintenanceDto
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }

        public int GarageId { get; set; }
        public int CarId { get; set; }
    }
}
