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
    }
}
