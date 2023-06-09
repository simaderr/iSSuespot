namespace issuespot_backend.Models
{
    public class Comment
    {
        public Guid TicketId { get; set; }

        public Guid UserId { get; set; }

        public String Text { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
