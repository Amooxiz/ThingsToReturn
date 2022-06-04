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
            throw new NotImplementedException();
        }

        public void AddOffer(Offer offer)
        {
            _offerRepository.AddOffer(offer);
        }
    }
}
