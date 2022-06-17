namespace ThingsToReturn.Services
{
    public class AppUserOfferService : IAppUserOfferService
    {
        private readonly IAppUserOfferRepository _appUserOfferRepository;
        public AppUserOfferService(IAppUserOfferRepository appUserOfferRepository) 
            => _appUserOfferRepository = appUserOfferRepository;

        public void AddOffersWithCategories()
        {
            throw new NotImplementedException();
        }
    }
}
