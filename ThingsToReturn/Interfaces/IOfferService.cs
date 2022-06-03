namespace ThingsToReturn.Interfaces
{
    public interface IOfferService
    {
        public OfferToListVM GetAllOffers();
        public void AddOffer(Offer offer);
    }
}
