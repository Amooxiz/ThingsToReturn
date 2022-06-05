using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThingsToReturn.Pages
{
    public class TestingModel : PageModel
    {
        private readonly ILogger<TestingModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;
        private readonly IOfferService _offerService;
        public CategoryToListVM CategoryList { get; set; }
        public OfferToListVM OfferList { get; set; }

        public TestingModel(ILogger<TestingModel> logger, ICategoryService categoryService,
            IOfferCategoryService offercategoryservice, IOfferService offerService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerService = offerService;
        }
        public void OnGet()
        {
            OfferList = _offerService.GetAllOffers();
        }
    }
}
