using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThingsToReturn.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;

        public IndexModel(ILogger<IndexModel> logger, ICategoryService categoryService, IOfferCategoryService offercategoryservice)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
        }

        public void OnGet()
        {
        }
    }
}