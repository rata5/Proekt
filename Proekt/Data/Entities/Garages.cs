namespace Proekt.Data.Entities
{
    public class Garages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public int Capacity { get; set; }

        /// <summary>
        /// razdelenie za vunshni kluchove
        /// </summary>
       
        public ICollection<Cars> Car { get; set; }
    }
}
