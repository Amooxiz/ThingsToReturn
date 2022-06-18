using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class UnfollowOfferModel : PageModel
    {
        private readonly IOfferService _offerService;
        private readonly IAppUserOfferService _appUserOfferService;
        public Offer Offer { get; set; }

        public UnfollowOfferModel(IOfferService offerService, IAppUserOfferService appUserOfferService)
        {
            _offerService = offerService;
            _appUserOfferService = appUserOfferService;
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
           /* var offer = _offerService.GetOffer(Offer.Id);
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (Offer.Id != 0)
            {
                if (_appuserOfferService.IsFollowed(claim.Value, offer))
                {
                    TempData["followed"] = "xd";
                    return RedirectToPage("/Offers/Offers");
                }
                _appuserOfferService.AddFollowOffer(claim?.Value, offer);
            }*/

            return RedirectToPage("/Offers/UsersOffers");
        }
    }
}
