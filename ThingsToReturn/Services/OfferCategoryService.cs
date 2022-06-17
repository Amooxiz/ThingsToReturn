using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferCategoryService : IOfferCategoryService
    {
        private readonly IOfferCategoryRepository _offerCategoryRepository;
        public OfferCategoryService(IOfferCategoryRepository offerCategoryRepository)
            => _offerCategoryRepository = offerCategoryRepository;

        public void AddOffersWithCategories(Offer offer, IList<Category> categories)
        {
            var offercats = categories.Select(c => new OfferCategory
            {

                Category = c,
                Offer = offer,
            }).ToList();
            _offerCategoryRepository.AddOffersWithCategories(offercats);
            
        }

        public CategoryToListVM GetCategoriesOfOffer(int offerId)
        {
            
            var categories = _offerCategoryRepository.GetCategoriesOfOffer(offerId).ToModel();

            var result = new CategoryToListVM
            {
                Categories = categories.ToList()
            };
            result.Count = result.Categories.Count;

            return result;

        }

    }
}
