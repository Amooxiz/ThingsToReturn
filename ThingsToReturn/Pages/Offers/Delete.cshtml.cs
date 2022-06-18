using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class DeleteOfferModel : PageModel
    {
        private readonly IOfferService _offerService;
        public Offer Offer { get; set; }

        public DeleteOfferModel(IOfferService offerService)
        {
            _offerService = offerService;
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
            if(Offer.Id != 0)
                _offerService.RemoveOffer(Offer);
             
            return RedirectToPage("/Offers/UsersOffers");
        }
    }
}
