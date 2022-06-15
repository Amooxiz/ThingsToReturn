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

        public void CancelReservation(int offerId)
        {
            var offer = _context.Offers.Find(offerId);
            offer.BookingId = null;
            _context.SaveChanges();
        }

        public IQueryable<Offer> FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return _context.Offers
                .Where(x => (x.CreatedDate >= createdDateDownLimit && x.CreatedDate <= createdDateUpLimit) &&
                (x.ExpirationDate >= expirationDateDownLimit && x.ExpirationDate <= expirationDateUpLimit) && x.Name.Contains(offerName)); 
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
                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && offers.Name.Contains(offerName) &&
                   (offers.CreatedDate >= createdDateDownLimit && offers.CreatedDate <= createdDateUpLimit) &&
                   (offers.ExpirationDate >= expirationDateDownLimit && offers.ExpirationDate <= expirationDateUpLimit)
                   select offers;
        }

        public IQueryable<Offer> FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return _context.Offers
                .Where(x => (x.CreatedDate >= createdDateDownLimit && x.CreatedDate <= createdDateUpLimit) && (x.ExpirationDate >= expirationDateDownLimit && x.ExpirationDate <= expirationDateUpLimit));
        }
        public IQueryable<Offer> FiltrateOffersByNameAndCategoryIdAndCity(string offerName, int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return from offers in _context.Offers
                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && offers.Name.Contains(offerName) && offers.Address.City.Contains(city) &&
                   (offers.CreatedDate >= createdDateDownLimit && offers.CreatedDate <= createdDateUpLimit) &&
                   (offers.ExpirationDate >= expirationDateDownLimit && offers.ExpirationDate <= expirationDateUpLimit)
                   select offers;
        }

        public IQueryable<Offer> FiltrateOffersByCity(string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return _context.Offers
                .Where(x => (x.CreatedDate >= createdDateDownLimit && x.CreatedDate <= createdDateUpLimit) &&
                (x.ExpirationDate >= expirationDateDownLimit && x.ExpirationDate <= expirationDateUpLimit) && x.Address.City.Contains(city));
        }

        public IQueryable<Offer> FiltrateOffersByCategoryIdAndCity(int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return from offers in _context.Offers
                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && offers.Address.City.Contains(city) &&
                   (offers.CreatedDate >= createdDateDownLimit && offers.CreatedDate <= createdDateUpLimit) &&
                   (offers.ExpirationDate >= expirationDateDownLimit && offers.ExpirationDate <= expirationDateUpLimit)
                   select offers;
        }

        public IQueryable<Offer> FiltrateOffersByNameAndCity(string offerName, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            return _context.Offers
                .Where(x => (x.CreatedDate >= createdDateDownLimit && x.CreatedDate <= createdDateUpLimit) &&
                (x.ExpirationDate >= expirationDateDownLimit && x.ExpirationDate <= expirationDateUpLimit) &&
                x.Address.City.Contains(city) && x.Name.Contains(offerName));
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
