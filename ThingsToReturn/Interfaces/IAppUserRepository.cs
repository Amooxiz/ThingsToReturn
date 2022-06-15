namespace ThingsToReturn.Interfaces
{
    public interface IAppUserRepository
    {
        public Address GetAddress(string userId);
    }
}
