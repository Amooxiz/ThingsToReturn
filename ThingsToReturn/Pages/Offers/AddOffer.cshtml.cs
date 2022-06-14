using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class AddOfferModel : PageModel
    {
        private readonly ILogger<AddOfferModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;
        private readonly IOfferService _offerService;

        public IFormFile ImageFile { get; set; }
        public List<int> Categories { get; set; }
        public Offer Offer { get; set; }
        public CategoryToListVM CategoryList { get; set; }

        public AddOfferModel(ILogger<AddOfferModel> logger, ICategoryService categoryService,
            IOfferCategoryService offercategoryservice, IOfferService offerService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerService = offerService;
        }
        public void OnGet()
        {
            CategoryList = _categoryService.GetAllCategories();

        }

        public IActionResult OnPost()
        {
            CategoryList = _categoryService.GetAllCategories();
            return Page();
        }
    }
}
