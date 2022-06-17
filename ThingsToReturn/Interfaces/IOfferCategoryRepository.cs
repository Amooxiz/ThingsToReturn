namespace ThingsToReturn.Interfaces
{
    public interface IOfferCategoryRepository
    {
        public IQueryable<OfferCategory> GetCategoriesOfOffer(int offerId);
        public void AddOffersWithCategories(IList<OfferCategory> offers);

    }
}
