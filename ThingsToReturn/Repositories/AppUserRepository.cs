using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly ThingsContext _context;
        public AppUserRepository(ThingsContext context)
        {
            _context = context;
        }
    }
}
