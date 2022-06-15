using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferCategoryService : IOfferCategoryService
    {
        private readonly IOfferCategoryRepository _offerCategoryRepository;
        public OfferCategoryService(IOfferCategoryRepository offerCategoryRepository)
            => _offerCategoryRepository = offerCategoryRepository;

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
