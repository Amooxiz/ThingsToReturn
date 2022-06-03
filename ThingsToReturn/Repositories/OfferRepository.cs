using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ThingsContext _context;
        public OfferRepository(ThingsContext context)
        {
            _context = context;
        }

        public IQueryable<Offer> GetAllOffers()
        {
            return _context.Offers;
        }

        public void AddOffer(Offer offer)
        {
            _context.Offers.Add(offer);
        }
    }
}
