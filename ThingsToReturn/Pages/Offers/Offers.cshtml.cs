using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    public class OffersModel : PageModel
    {
        private readonly ILogger<OffersModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;
        private readonly IOfferService _offerService;
        private readonly IAddressService _addressservice;
        public CategoryToListVM CategoryList { get; set; }
        public OfferToListVM OfferList { get; set; }
        public List<string> cities { get; set; }
        public FilterModel FilterChoices { get; set; }

        public OffersModel(ILogger<OffersModel> logger, ICategoryService categoryService,
            IOfferCategoryService offercategoryservice, IOfferService offerService, IAddressService addressService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerService = offerService;
            _addressservice = addressService;
        }
        public void OnGet()
        {
            OfferList = _offerService.GetAllOffers();
            CategoryList = _categoryService.GetAllCategories();
            cities = _addressservice.GetAllCities();
        }

        public IActionResult OnPostSelect()
        {
            CategoryList = _categoryService.GetAllCategories();
            cities = _addressservice.GetAllCities();

            if (ModelState.IsValid)
                OfferList = _offerService.FiltrateOffers(FilterChoices);
            return Page();
        }
    }
}
