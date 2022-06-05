using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IOfferCategoryService _offcatservice;

        public OfferService(IOfferRepository offerRepository, IOfferCategoryService offcatservice)
        {
            _offerRepository = offerRepository;
            _offcatservice = offcatservice;
        }

        public OfferToListVM GetAllOffers()
        {
            var offers = _offerRepository.GetAllOffers();
            var offersmodel = offers.ToModel();


        }

        public void AddOffer(Offer offer)
        {
            _offerRepository.AddOffer(offer);
        }
    }
}
