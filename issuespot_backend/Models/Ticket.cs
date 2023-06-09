namespace issuespot_backend.Models
{
    public class Ticket
    {
        public Guid ProjectId { get; set; }

        public Guid UserID { get; set; }
        
        public Guid AssignedToUserID { get; set; }

        public String Title { get; set; }

        public DateTime CreationDate { get; set; }

        public String Status { get; set; }
    }
}
