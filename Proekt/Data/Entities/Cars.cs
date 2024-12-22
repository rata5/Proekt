namespace Proekt.Data.Entities
{
    public class Cars
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }

        /// <summary>
        /// razdelenie za vunshni kluchove
        /// </summary>
        
        public int GarageId { get; set; }
        public Garages Garages { get; set; }

    }
}
