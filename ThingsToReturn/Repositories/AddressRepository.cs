using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ThingsContext _context;
        public AddressRepository(ThingsContext context) => _context = context;
    }
}
