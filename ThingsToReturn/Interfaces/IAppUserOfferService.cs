namespace ThingsToReturn.Interfaces
{
    public interface IAppUserOfferService
    {
        public void AddOffersWithCategories(Offer offer, IList<Category> categories);

    }
}
