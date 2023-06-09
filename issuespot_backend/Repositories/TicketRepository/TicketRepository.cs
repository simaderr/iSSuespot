using issuespot_backend.Database;
using issuespot_backend.Models;
using issuespot_backend.Repositories.GenericRepository;

namespace issuespot_backend.Repositories.TicketRepository
{
    public class TicketRepository: GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(AppDbContext context) : base(context) { }
    }
}
