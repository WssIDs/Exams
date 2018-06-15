using System;

namespace questions.DAL
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public string message { get; set; }
    }
}
