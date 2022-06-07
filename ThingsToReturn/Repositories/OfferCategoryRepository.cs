using Microsoft.EntityFrameworkCore;
using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class OfferCategoryRepository : IOfferCategoryRepository
    {
        private readonly ThingsContext _context;
        public OfferCategoryRepository(ThingsContext context) => _context = context;

        public IQueryable<OfferCategory> GetCategoriesOfOffer(int offerId) => _context.OfferCategories.Where(x => x.OfferId == offerId).Include(x => x.Category);

        public IQueryable<OfferCategory> GetCategoryOffers(int categoryId) => _context.OfferCategories.Where(x => x.CategoryId == categoryId).Include(x => x.Offer);
    }
}
