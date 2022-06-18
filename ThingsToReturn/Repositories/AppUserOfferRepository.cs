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

        public void RemoveFollowOffer(AppUserOffer appUserOffer)
        {
            _context.AppUserOffer.Remove(appUserOffer);
            _context.SaveChanges();
        }

        public AppUserOffer GetFollowOffer(string userId, int offerId)
        {
            return _context.AppUserOffer.Find(userId, offerId);
        }
    }
}
