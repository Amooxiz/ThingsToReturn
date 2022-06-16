namespace ThingsToReturn.Interfaces
{
    public interface IOfferRepository
    {
        public void ReserveOffer(string bookingUserId, int offerId);
        public void CancelReservation(int offerId);
        public IQueryable<Offer> Get20LatestOffers();
        public IQueryable<Offer> GetAllOffers();
        public IQueryable<Offer> GetUsersOffers(string userId);
        public void AddOffer(Offer offer);
        public IQueryable<Offer> FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByNameAndCity(string offerName, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByCategoryIdAndCity(int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByCity(string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public IQueryable<Offer> FiltrateOffersByNameAndCategoryIdAndCity(string offerName, int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public Offer GetOfferToDel(int offerId);
        public DateTime GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit();
    }
}
