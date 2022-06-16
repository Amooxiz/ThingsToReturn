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

        public DeleteOfferModel(ILogger<DeleteOfferModel> logger, IOfferService offerService)
        {
            _offerService = offerService;
        }
        public void OnGet(int id)
        {
            Offer = _offerService.GetOfferToDel(id);
        }   

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
