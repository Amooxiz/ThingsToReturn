namespace ThingsToReturn.Interfaces
{
    public interface IOfferRepository
    {
        public void ReserveOffer(string bookingUserId, int offerId);
        public void CancelReservation(int offerId);
        public IQueryable<Offer> Get20LatestOffers();
        public IQueryable<Offer> GetAllOffers();
        public IQueryable<Offer> GetUsersOffers(string userId);
        public IQueryable<Offer> GetNotUsersOffers(string userId);
        public IQueryable<Offer> GetFollowedOffers(string userId);
        public void AddOffer(Offer offer);
        public IQueryable<Offer> FiltrateOffersBySearchTerm(string searchTerm);
        public IQueryable<Offer> FiltrateOffersByCategoryId(int? categoryId);
        public IQueryable<Offer> FiltrateOffersBySearchTermAndCategoryId(string searchTerm, int? categoryId);
        public IQueryable<Offer> FiltrateOffersBySearchTermAndCity(string searchTerm, string city);
        public IQueryable<Offer> FiltrateOffersByCategoryIdAndCity(int? categoryId, string city);
        public IQueryable<Offer> FiltrateOffersByCity(string city);
        public IQueryable<Offer> FiltrateOffersBySearchTermAndCategoryIdAndCity(string searchTerm, int? categoryId, string city);
        public Offer GetOffer(int offerId);
        public void RemoveOffer(Offer offer);
        public DateTime GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit();
    }
}
