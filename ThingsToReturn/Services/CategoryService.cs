using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public CategoryToListVM GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories().ToModel();
            var result = new CategoryToListVM();
            
            result.Categories = categories.ToList();
            result.Count = result.Categories.Count;

            return result;
        }

        public IList<Category> GetCategoriesByIdList(IList<int> Categories)
        {
            return _categoryRepository.GetCategoriesByIdList(Categories).ToList();
        }
    }
}
