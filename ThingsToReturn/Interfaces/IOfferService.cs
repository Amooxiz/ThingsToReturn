namespace ThingsToReturn.Interfaces
{
    public interface IOfferService
    {
        public OfferToListVM GetAllOffers();
        public void AddOffer(Offer offer);
        public OfferToListVM Get20LatestOffers();
        public OfferToListVM FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public DateTime GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit();
    }
}
