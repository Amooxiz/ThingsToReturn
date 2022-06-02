using System.ComponentModel.DataAnnotations;

namespace ThingsToReturn.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        [Display(Name ="Zip code")]
        public string ZipCode { get; set; }

        [Display(Name = "Building number")]
        public int BuildingNr { get; set; }

        [Display(Name = "Apartment number")]
        public int ApartmentNr { get; set; }
    }
}
