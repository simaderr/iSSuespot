using issuespot_backend.Models.Base;

namespace issuespot_backend.Models
{
    public class Project: BaseEntity
    {
        public String Name { get; set; }
        
        public Guid TeamId { get; set; }
    }
}
