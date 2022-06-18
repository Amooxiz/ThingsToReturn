using ThingsToReturn.Data;
namespace ThingsToReturn.Repositories
{
    public class AppUserOfferRepository : IAppUserOfferRepository
    {
        private readonly ThingsContext _context;
        public AppUserOfferRepository(ThingsContext context) => _context = context;

        public void AddFollowOffer(AppUserOffer appUserOffer)
        {
            _context.AppUserOffer.Add(appUserOffer);
            _context.SaveChanges();
        }
    }
}
