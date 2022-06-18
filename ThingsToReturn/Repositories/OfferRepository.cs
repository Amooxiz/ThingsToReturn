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

        public IQueryable<Offer> FiltrateOffersBySearchTerm(string searchTerm) => _context.Offers.Where(x => x.Name.Contains(searchTerm) || x.Description.Contains(searchTerm));

        public IQueryable<Offer> FiltrateOffersByCategoryId(int? categoryId) => from offers in _context.Offers
                                                                               where offers.OfferCategories.Any(c => c.CategoryId == categoryId)
                                                                               select offers;

        public IQueryable<Offer> FiltrateOffersBySearchTermAndCategoryId(string searchTerm, int? categoryId) => from offers in _context.Offers
                                                                                                               where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && (offers.Name.Contains(searchTerm) || offers.Description.Contains(searchTerm))
                                                                                                               select offers;
        public IQueryable<Offer> FiltrateOffersBySearchTermAndCategoryIdAndCity(string searchTerm, int? categoryId, string city) => from offers in _context.Offers
                                                                                                                                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && (offers.Name.Contains(searchTerm) || offers.Description.Contains(searchTerm)) &&
                                                                                                                                   offers.Address.City == city
                                                                                                                                   select offers;

        public IQueryable<Offer> FiltrateOffersByCity(string city) => _context.Offers.Where(x => x.Address.City == city);

        public IQueryable<Offer> FiltrateOffersByCategoryIdAndCity(int? categoryId, string city) => from offers in _context.Offers
                                                                                                   where offers.OfferCategories.Any(c => c.CategoryId == categoryId) && offers.Address.City == city
                                                                                                   select offers;

        public IQueryable<Offer> FiltrateOffersBySearchTermAndCity(string searchTerm, string city) => _context.Offers
            .Where(x => x.Address.City == city && (x.Name.Contains(searchTerm) || x.Description.Contains(searchTerm)));

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

        public IQueryable<Offer> GetUsersOffers(string userId)
        {
            return _context.Offers.Where(x => x.User.Id == userId);
        }
        public IQueryable<Offer> GetNotUsersOffers(string userId)
        {
            return _context.Offers.Where(x => x.User.Id != userId);
        }

        public Offer GetOffer(int offerId)
        {
            return _context.Offers.Find(offerId);
        }

        public void RemoveOffer(Offer offer)
        {
            _context.Offers.Remove(offer);
            _context.SaveChanges();
        }
    }
}
