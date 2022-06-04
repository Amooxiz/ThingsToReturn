namespace ThingsToReturn.Interfaces
{
    public interface IOfferRepository
    {
        public IQueryable<Offer> GetAllOffers();
        public void AddOffer(Offer offer);
        public IQueryable<Offer> Get20LatestOffers();
        public void ReserveOffer(string bookingUserId, int offerId);
        public IQueryable<Offer> FiltrateOffers(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
    }
}
