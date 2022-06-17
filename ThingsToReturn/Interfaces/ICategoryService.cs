namespace ThingsToReturn.Interfaces
{
    public interface ICategoryService
    {
        public CategoryToListVM GetAllCategories();
        public IList<Category> GetCategoriesByIdList(IList<int> Categories);
    }
}
