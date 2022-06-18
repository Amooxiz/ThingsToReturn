using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class ConfirmFollowOfferModel : PageModel
    {
        private readonly IOfferService _offerService;
        private readonly IAppUserOfferService _appuserOfferService;

        public Offer Offer { get; set; }

        public ConfirmFollowOfferModel(IOfferService offerService, IAppUserOfferService appUserOfferService)
        {
            _offerService = offerService;
            _appuserOfferService = appUserOfferService;
        }
        public void OnGet(int id)
        {
            if (id != 0)
            {
                Offer = _offerService.GetOffer(id);
            }
        }   

        public IActionResult OnPost()
        {
            var offer = _offerService.GetOffer(Offer.Id);
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (Offer.Id != 0)
            {
                _appuserOfferService.AddFollowOffer(claim?.Value, offer);
            }

            return RedirectToPage("/Offers/Offers");
        }
    }
}
