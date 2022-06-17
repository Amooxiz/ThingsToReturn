using Microsoft.EntityFrameworkCore;
using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly ThingsContext _context;
        public AppUserRepository(ThingsContext context) => _context = context;

        public Address GetAddress(string userId)
        {
            return _context.AppUsers.Find(userId).Address;
        }

        public AppUser GetUser(string userId)
        {
           return _context.AppUsers.Find(userId);
        }

        public IQueryable<AppUser> GetInterestedUsers(int offerId)
        {
            return from appUsers in _context.AppUsers
                   where appUsers.AppUserOffers.Any(c => c.OfferId == offerId)
                   select appUsers;
        }
    }
}
