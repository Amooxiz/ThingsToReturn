using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class FolloweOffersModel : PageModel
    {
        private readonly ILogger<FolloweOffersModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;
        private readonly IOfferService _offerService;
        private readonly IAddressService _addressservice;
     
        public OfferToListVM OfferList { get; set; }
      

        public FolloweOffersModel(ILogger<FolloweOffersModel> logger, ICategoryService categoryService,
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
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            OfferList = _offerService.GetFollowedOffers(claims);
        }

        public IActionResult OnPostSelect()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            OfferList = _offerService.GetFollowedOffers(claims);
            return Page();
        }
    }
}
