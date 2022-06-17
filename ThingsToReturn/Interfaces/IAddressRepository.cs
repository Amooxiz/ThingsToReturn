namespace ThingsToReturn.Interfaces
{
    public interface IAddressRepository
    {
        public IQueryable<string> GetAllCities();
    }
}
