using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class OfferCategoryRepository : IOfferCategoryRepository
    {
        private readonly ThingsContext _context;
        public OfferCategoryRepository(ThingsContext context)
        {
            _context = context;
        }

        public IQueryable<OfferCategory> GetCategoriesOfOffer(int offerId)
        {
            return from offcat in _context.OfferCategories
                   where offcat.OfferId == offerId
                   select offcat;
        }
    }
}
