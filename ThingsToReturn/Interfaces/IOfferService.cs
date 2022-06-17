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
        public OfferToListVM FiltrateOffers(FilterModel filterModel);
        public OfferToListVM GetOffersByCategoryId(int categoryId);
        public Offer GetOfferToDel(int offerId);
        public DateTime GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit();
    }
}
