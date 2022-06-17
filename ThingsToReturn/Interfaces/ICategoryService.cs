namespace ThingsToReturn.Interfaces
{
    public interface ICategoryService
    {
        public CategoryToListVM GetAllCategories();
        public CategoryToListVM GetCategoriesByIdList(IList<int> Categories);
    }
}
