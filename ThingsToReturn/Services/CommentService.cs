namespace ThingsToReturn.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository) => _commentRepository = commentRepository;
    }
}
