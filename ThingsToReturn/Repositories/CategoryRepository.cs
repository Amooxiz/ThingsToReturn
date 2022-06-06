using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ThingsContext _context;
        public CategoryRepository(ThingsContext context) => _context = context;

        public IQueryable<Category> GetAllCategories() => _context.Categories;

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}
