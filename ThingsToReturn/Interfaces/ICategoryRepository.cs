namespace ThingsToReturn.Interfaces
{
    public interface ICategoryRepository
    {
        public IQueryable<Category> GetAllCategories();
        public IQueryable<Category> GetCategoriesByIdList(IList<int> Categories);
    }
}
