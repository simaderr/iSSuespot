using issuespot_backend.Models;
using issuespot_backend.Repositories.GenericRepository;

namespace issuespot_backend.Repositories.TicketRepository
{
    public interface ITicketRepository: IGenericRepository<Ticket>
    {

    }
}
