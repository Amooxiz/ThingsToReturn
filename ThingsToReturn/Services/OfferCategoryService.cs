using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferCategoryService : IOfferCategoryService
    {
        private readonly IOfferCategoryRepository _offerCategoryRepository;
        public OfferCategoryService(IOfferCategoryRepository offerCategoryRepository)
        {
            _offerCategoryRepository = offerCategoryRepository;
        }

        public CategoryToListVM GetCategoriesOfOffer(int offerId)
        {
            var categories1 = _offerCategoryRepository.GetCategoriesOfOffer(offerId);
            var categories = categories1.ToModel();

            var result = new CategoryToListVM();
            result.Categories = categories.ToList();
            result.Count = result.Categories.Count();

            return result;

        }

    }
}
