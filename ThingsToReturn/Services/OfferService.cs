using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public OfferToListVM GetAllOffers()
        {
            var offers = _offerRepository.GetAllOffers();
            var offersmodel = offers.ToModel();

            var result = new OfferToListVM
            {
                Offers = offersmodel.ToList()
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
