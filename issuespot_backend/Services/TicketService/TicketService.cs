using issuespot_backend.Models;

namespace issuespot_backend.Services.TicketService
{
    public class TicketService: ITicketService
    {
        public async Task CreateAsync(Ticket ticket) { }

        public async Task Update(Guid TicketId) { }

        public async Task<List<Ticket>> GetAllAsync() { }

        public async Task DeleteAsync(Ticket ticket) { }
    }
}
