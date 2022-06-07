namespace ThingsToReturn.Interfaces
{
    public interface ICommentRepository
    {
        public IQueryable<Comment> GetReceiverComments(string receiverId);
    }
}
