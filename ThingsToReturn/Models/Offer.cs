namespace ThingsToReturn.Models
{
    public class Offer
    {
        public int Id { get; set; }
        
        [MaxLength(40, ErrorMessage ="Maximum 40 characters allowed")]
        [MinLength(8, ErrorMessage = "Minimum 8 characters required")]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        
        [MaxLength(245, ErrorMessage = "Maximum 200 characters allowed")]
        [MinLength(8, ErrorMessage = "Minimum 8 characters required")]
        public string Description { get; set; }
        public Address Address { get; set; }
        
        [Column(TypeName="Date")]
        [DataType("Date")]
        public DateTime CreatedDate { get; set; }
        
        [Column(TypeName = "Date")]
        [DataType("Date")]
        public DateTime ExpirationDate { get; set; }
        public AppUser User { get; set; }
        public ICollection<AppUserOffer>? AppUserOffers { get; set; }
        public ICollection<OfferCategory>? OfferCategories { get; set; }
        
        public string? BookingId { get; set; }

    }
}
