namespace ThingsToReturn.Interfaces
{
    public interface ICategoryRepository
    {
        public IQueryable<Category> GetAllCategories();
        public void AddCategory(Category category);
    }
}
