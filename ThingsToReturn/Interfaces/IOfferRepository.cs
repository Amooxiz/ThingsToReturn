namespace ThingsToReturn.Interfaces
{
    public interface IOfferRepository
    {
        public IQueryable<Offer> GetAllOffers();
        public void AddOffer(Offer offer);
        public IQueryable<Offer> Get20LatestOffers();
        public void ReserveOffer(string bookingUserId, int offerId);
        public IQueryable<Offer> FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public DateTime GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit();
    }
}
