namespace ThingsToReturn.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        public AppUserService(IAppUserRepository appUserRepository) => _appUserRepository = appUserRepository;
    }
}
