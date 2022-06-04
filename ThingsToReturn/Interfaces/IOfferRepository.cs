namespace ThingsToReturn.Interfaces
{
    public interface IOfferRepository
    {
        public IQueryable<Offer> GetAllOffers();
        public void AddOffer(Offer offer);
    }
}
