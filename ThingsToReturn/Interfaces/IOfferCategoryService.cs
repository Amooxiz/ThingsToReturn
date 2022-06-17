namespace ThingsToReturn.Interfaces
{
    public interface IOfferCategoryService
    {
        public CategoryToListVM GetCategoriesOfOffer(int offerId);
        public void AddOffersWithCategories(Offer offer, IList<Category> categories);

    }
}
