using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ThingsToReturn.Pages
{
    [Authorize]
    [BindProperties]
    public class ReserveOfferModel : PageModel
    {
        private readonly IOfferService _offerService;
        private readonly IAppUserService _appUserService;
        public Offer Offer { get; set; }
        public Reservation Reservation { get; set; }
        public AppUserToListVM InterestedUsers { get; set; }
        public ReserveOfferModel(IOfferService offerService, IAppUserService appUserService)
        {
            _offerService = offerService;
            _appUserService = appUserService;
        }
        public void OnGet(int id)
        {


            if (id != 0)
            {
                Offer = _offerService.GetOffer(id);
                InterestedUsers = _appUserService.GetInterestedUsers(Offer.Id);
            }
            
        }   

        public IActionResult OnPostReserve()
        {
           
            _offerService.ReserveOffer(Reservation.UserId, Reservation.OfferId);
                 
            return RedirectToPage("/Offers/UsersOffers");
        }

        public IActionResult OnPostCancel()
        {
            
            _offerService.CancelReservation(Reservation.OfferId);
            
            return RedirectToPage("/Offers/UsersOffers");
        }
    }
}
