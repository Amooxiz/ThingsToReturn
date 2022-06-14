using Microsoft.EntityFrameworkCore;
using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ThingsContext _context;
        public OfferRepository(ThingsContext context) => _context = context;

        public IQueryable<Offer> GetAllOffers() => _context.Offers;
        public void AddOffer(Offer offer)
        {
            _context.Offers.Add(offer);
            _context.SaveChanges();
        }
        public IQueryable<Offer> Get20LatestOffers() => _context.Offers.OrderByDescending(x => x.CreatedDate).Take(20);

        public void ReserveOffer(string bookingUserId, int offerId)
        {
            var offer = _context.Offers.Find(offerId);
            offer.BookingId = bookingUserId;
            _context.SaveChanges();
        }

        public IQueryable<Offer> FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return _context.Offers
                .Where(x => (x.CreatedDate >= createdDateDownLimit && x.CreatedDate <= createdDateUpLimit) &&
                (x.ExpirationDate >= expirationDateDownLimit && x.ExpirationDate <= expirationDateUpLimit) && x.Name.StartsWith(offerName)); 
        }

        public IQueryable<Offer> FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return from offers in _context.Offers
                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) &&
                   (offers.CreatedDate >= createdDateDownLimit && offers.CreatedDate <= createdDateUpLimit) &&
                   (offers.ExpirationDate >= expirationDateDownLimit && offers.ExpirationDate <= expirationDateUpLimit)
                   select offers;
        }

        public IQueryable<Offer> FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return from offers in _context.Offers
                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && offers.Name.StartsWith(offerName) &&
                   (offers.CreatedDate >= createdDateDownLimit && offers.CreatedDate <= createdDateUpLimit) &&
                   (offers.ExpirationDate >= expirationDateDownLimit && offers.ExpirationDate <= expirationDateUpLimit)
                   select offers;
        }

        public IQueryable<Offer> FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return _context.Offers
                .Where(x => (x.CreatedDate >= createdDateDownLimit && x.CreatedDate <= createdDateUpLimit) && (x.ExpirationDate >= expirationDateDownLimit && x.ExpirationDate <= expirationDateUpLimit));
        }

        public DateTime GetCreatedDateDownLimit()
        {
            return _context.Offers.Select(x => x.CreatedDate).Min();
        }

        public DateTime GetCreatedDateUpLimit()
        {
            return _context.Offers.Select(x => x.CreatedDate).Max();
        }

        public DateTime GetExpirationDateDownLimit()
        {
            return _context.Offers.Select(x => x.ExpirationDate).Min();
        }

        public DateTime GetExpirationDateUpLimit()
        {
            return _context.Offers.Select(x => x.ExpirationDate).Max();
        }
    }
}
