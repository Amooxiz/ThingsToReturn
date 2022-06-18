
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

        public AppUserToListVM GetInterestedUsers(int offerId)
        {
            throw new NotImplementedException();
        }

        public AppUser GetUser(string userId)
        {
            return _appUserRepository.GetUser(userId);
        }

        public AppUserToListVM GetInterestedUsers(int offerId)
        {
            var users = _appUserRepository.GetInterestedUsers(offerId).ToModel();

            var result = new AppUserToListVM();

            result.AppUsers = users.ToList();
            result.Count = result.AppUsers.Count;

            return result;
        }
    }
}
