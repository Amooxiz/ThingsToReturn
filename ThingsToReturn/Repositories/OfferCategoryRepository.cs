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
    }
}
