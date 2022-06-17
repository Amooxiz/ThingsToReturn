namespace ThingsToReturn.Interfaces
{
    public interface IAppUserService
    {
        public AddressVM GetAddress(string userId);
        public AppUser GetUser(string userId);

    }
}
