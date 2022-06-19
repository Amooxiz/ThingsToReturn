using System.Security.Claims;

namespace ThingsToReturn.Interfaces
{
    public interface IOfferCategoryService
    {
        public CategoryToListVM GetCategoriesOfOffer(int offerId);
        public void AddOffersWithCategories(Offer Offer, IFormFile ImageFile, Address Address, Claim claim, IList<int> Categories);

    }
}
