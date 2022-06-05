namespace ThingsToReturn.Interfaces
{
    public interface IOfferCategoryRepository
    {
        public IQueryable<OfferCategory> GetCategoriesOfOffer(int offerId);
    }
}
