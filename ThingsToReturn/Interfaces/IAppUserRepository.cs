namespace ThingsToReturn.Interfaces
{
    public interface IAppUserRepository
    {
        public Address GetAddress(string userId);
        public AppUser GetUser(string userId);
        public IQueryable<AppUser> GetInterestedUsers(int offerId)
    }
}
