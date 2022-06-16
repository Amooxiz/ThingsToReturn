using System.Security.Claims;

namespace ThingsToReturn.Interfaces
{
    public interface IOfferService
    {
        public OfferToListVM GetAllOffers();
        public void AddOffer(Offer offer);
        public void ReserveOffer(string bookingUserId, int offerId);
        public void CancelReservation(int offerId);
        public OfferToListVM Get20LatestOffers();
        public OfferToListVM GetUsersOffers(Claim claim);
        public OfferToListVM FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByNameAndCity(string offerName, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByCategoryIdAndCity(int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByCity(string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public OfferToListVM FiltrateOffersByNameAndCategoryIdAndCity(string offerName, int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit);
        public Offer GetOfferToDel(int offerId);
        public DateTime GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit();
    }
}
