using issuespot_backend.Models;

namespace issuespot_backend.Services.TicketService
{
    public interface ITicketService
    {
        Task CreateAsync(Ticket ticket);

        Task Update(Guid TicketId);

        Task<List<Ticket>> GetAllAsync();

        Task DeleteAsync(Ticket ticket);
    }
}
