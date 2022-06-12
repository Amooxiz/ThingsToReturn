using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IOfferCategoryRepository _offerCategoryRepository;

        public OfferService(IOfferRepository offerRepository, IOfferCategoryRepository offerCategoryRepository)
        {
            _offerRepository = offerRepository;
            _offerCategoryRepository = offerCategoryRepository;
        }

        public OfferToListVM GetAllOffers()
        {
            var offers = _offerRepository.GetAllOffers().ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i ++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public void AddOffer(Offer offer)
        {
            _offerRepository.AddOffer(offer);
        }
    }
}
