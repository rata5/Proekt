namespace Proekt.Data.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public DateTime Date { get; set; }
        public string Garage { get; set; }
        public string Car { get; set; }
       
        /// <summary>
        /// razdelenie za vunshni kluchove
        /// </summary>
      
        public int GarageId { get; set; }
        public Garages Garages { get; set; }
        public int CarId { get; set; }
        public Cars Cars { get; set; }
    }
}
