using ThingsToReturn.Data;

namespace ThingsToReturn.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ThingsContext _context;
        public CommentRepository(ThingsContext context) => _context = context;

        public IQueryable<Comment> GetReceiverComments(string receiverId) => _context.Comments.Where(x => x.CommentReceiverId == receiverId);

    }
}
