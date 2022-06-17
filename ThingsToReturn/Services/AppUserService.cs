
using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        public AppUserService(IAppUserRepository appUserRepository) => _appUserRepository = appUserRepository;

        public AddressVM GetAddress(string userId)
        {
            return _appUserRepository.GetAddress(userId).ToModel();
        }

        public AppUser GetUser(string userId)
        {
            return _appUserRepository.GetUser(userId);
        }
    }
}
