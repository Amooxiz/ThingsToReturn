namespace ThingsToReturn.Models
{
    public class AppUserOffer
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
    }
}
