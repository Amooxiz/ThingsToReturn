namespace ThingsToReturn.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentReceiverId { get; set; }
        public string CommentSenderId { get; set; }
        public AppUser CommentReceiver { get; set; }
        public AppUser CommentSender { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }

    }
}
