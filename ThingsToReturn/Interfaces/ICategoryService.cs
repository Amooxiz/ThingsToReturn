namespace ThingsToReturn.Interfaces
{
    public interface ICategoryService
    {
        public CategoryToListVM GetAllCategories();
        public void AddCategory(Category category);
    }
}
