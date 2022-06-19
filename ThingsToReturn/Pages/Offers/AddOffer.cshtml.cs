using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

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
        private readonly IAppUserService _appUserService;

        public Address Address { get; set; }
        public IFormFile ImageFile { get; set; }
        public IList<int> Categories { get; set; }
        public Offer Offer { get; set; }
        public CategoryToListVM CategoryList { get; set; }

        public AddOfferModel(ILogger<AddOfferModel> logger, ICategoryService categoryService,
            IOfferCategoryService offercategoryservice, IOfferService offerService, IAppUserService appUserService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerService = offerService;
            _appUserService = appUserService;
        }
        public void OnGet()
        {
            CategoryList = _categoryService.GetAllCategories();

        }

        public IActionResult OnPost()
        {

            CategoryList = _categoryService.GetAllCategories();

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            _offercategoryservice.AddOffersWithCategories(Offer, ImageFile, Address, claim, Categories);

            return RedirectToPage("/Offers/Offers");
        }
    }
}
