namespace ThingsToReturn.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public CategoryToListVM GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
