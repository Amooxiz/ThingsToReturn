namespace ThingsToReturn.Models
{
    public class OfferCategory
    {
        public int OfferId { get; set; }
        public Offer Offer { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
