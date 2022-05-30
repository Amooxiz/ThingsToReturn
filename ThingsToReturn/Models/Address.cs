namespace ThingsToReturn.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public int BuildingNr { get; set; }
        public int ApartmentNr { get; set; }
    }
}
