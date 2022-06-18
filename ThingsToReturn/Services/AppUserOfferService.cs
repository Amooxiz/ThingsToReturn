namespace ThingsToReturn.Services
{
    public class AppUserOfferService : IAppUserOfferService
    {
        private readonly IAppUserOfferRepository _appUserOfferRepository;
        private readonly IAppUserRepository _appUserRepository;
        public AppUserOfferService(IAppUserOfferRepository appUserOfferRepository, IAppUserRepository appUserRepository)
        {
            _appUserOfferRepository = appUserOfferRepository;
            _appUserRepository = appUserRepository;        
        }

        public void AddOffersWithCategories()
        {
            throw new NotImplementedException();
        }

        public void AddFollowOffer(string userId, Offer offer)
        {
            AppUser user = _appUserRepository.GetUser(userId);
            AppUserOffer appUserOffer = new AppUserOffer();
            appUserOffer.AppUser = user;
            appUserOffer.Offer = offer;
            _appUserOfferRepository.AddFollowOffer(appUserOffer);
        }
    }
}
