namespace ThingsToReturn.Interfaces
{
    public interface ICategoryRepository
    {
        public IQueryable<Category> GetAllCategories();
    }
}
