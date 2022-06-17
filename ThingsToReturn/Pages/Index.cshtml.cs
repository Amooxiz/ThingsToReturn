using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThingsToReturn.Pages
{

    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;
        private readonly IOfferService _offerservice;

        public CategoryToListVM Categories { get; set; }
        [HiddenInput]
        public int CategoryId { get; set; }
        public OfferToListVM OfferList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICategoryService categoryService, IOfferCategoryService offercategoryservice, IOfferService offerService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerservice = offerService;
        }

        public void OnGet()
        {
            Categories = _categoryService.GetAllCategories();
            OfferList = _offerservice.GetAllOffers();
        }

        public IActionResult OnPostSelect()
        {
            Categories = _categoryService.GetAllCategories();
            OfferList = _offerservice.GetOffersByCategoryId(CategoryId);
            return Page();
        }
    }
}