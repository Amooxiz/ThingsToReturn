using Microsoft.AspNetCore.Identity;

namespace ThingsToReturn.Models
{
    public class AppUser : IdentityUser
    {
        public Address Address { get; set; }
        public ICollection<Offer>? MyOffers { get; set; }
        public ICollection<AppUserOffer>? AppUserOffers { get; set; }

    }
}
