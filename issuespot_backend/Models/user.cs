using issuespot_backend.Models.Base;
using issuespot_backend.Models.Enums;
using System.Text.Json.Serialization;

namespace issuespot_backend.Models
{
    public class User : BaseEntity
    {
        public String UserName { get; set; }

        public String EMail { get; set; }

        public Guid TeamId { get; set; }

        public Role Role { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}
