namespace ThingsToReturn.Interfaces
{
    public interface IAppUserOfferRepository
    {
        public void AddFollowOffer(AppUserOffer appUserOffer);
        public void RemoveFollowOffer(AppUserOffer appUserOffer);
        public AppUserOffer GetFollowOffer(string userId, int offerId);
        public bool IsFollowed(string userId, int offerId);
    }
}
