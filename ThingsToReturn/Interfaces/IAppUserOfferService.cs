namespace ThingsToReturn.Interfaces
{
    public interface IAppUserOfferService
    {
        public void AddFollowOffer(string userId, Offer offer);
        public void RemoveFollowOffer(string userId, Offer offer);
        public AppUserOffer GetFollowOffer(string userId, Offer offer)
    }
}
