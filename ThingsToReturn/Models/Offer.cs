namespace ThingsToReturn.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public Address Address { get; set; }
        [Column(TypeName="Date")]
        public DateTime ExpirationDate { get; set; }
        public AppUser User { get; set; }
        public ICollection<AppUserOffer>? AppUserOffers { get; set; }
        public ICollection<OfferCategory>? OfferCategories { get; set; }
        
        public int? BookingId { get; set; }

    }
}
