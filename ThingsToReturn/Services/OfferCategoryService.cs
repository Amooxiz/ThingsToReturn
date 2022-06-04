namespace ThingsToReturn.Services
{
    public class OfferCategoryService : IOfferCategoryService
    {
        private readonly IOfferCategoryRepository _offerCategoryRepository;
        public OfferCategoryService(IOfferCategoryRepository offerCategoryRepository)
        {
            _offerCategoryRepository = offerCategoryRepository;
        }
    }
}
