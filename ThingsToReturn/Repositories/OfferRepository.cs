using Microsoft.EntityFrameworkCore;
using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ThingsContext _context;
        public OfferRepository(ThingsContext context) => _context = context;

        public IQueryable<Offer> GetAllOffers() => _context.Offers.Include(o => o.OfferCategories);
        public void AddOffer(Offer offer) => _context.Offers.Add(offer);
        public IQueryable<Offer> Get20LatestOffers() => _context.Offers.OrderByDescending(x => x.CreatedDate).Take(20);

        public void ReserveOffer(string bookingUserId, int offerId)
        {
            var offer = _context.Offers.Find(offerId);
            offer.BookingId = bookingUserId;
            _context.SaveChanges();
        }

        public IQueryable<Offer> FiltrateOffers(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            throw new NotImplementedException();
        }
    }
}
