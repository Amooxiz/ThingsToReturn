namespace ThingsToReturn.Models
{
    public class Address
    {
        public int? Id { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }

        [Display(Name ="Zip code")]
        public string? ZipCode { get; set; }

        [Display(Name = "Building number")]
        [Range(1,10000)]
        public int? BuildingNr { get; set; }

        [Display(Name = "Apartment number")]
        [Range(1, 10000)]
        public int? ApartmentNr { get; set; }
    }
}
