using issuespot_backend.Database;
using issuespot_backend.Repositories.CommentRepository;
using issuespot_backend.Repositories.ProjectRepository;
using issuespot_backend.Repositories.TicketRepository;

namespace issuespot_backend.Repositories.UnicOfWork
{
    public class UnitOfWork
    {
        public ICommentRepository CommentRepository { get; set; }
        public IProjectRepository ProjectRepository { get; set; }
        public ITicketRepository TicketRepository { get; set; }
        public AppDbContext _dbContext { get; set; }

        public UnitOfWork(ICommentRepository commentRepository, IProjectRepository projectRepository, ITicketRepository ticketRepository, AppDbContext dbContext)
        {
            CommentRepository = commentRepository;
            ProjectRepository = projectRepository;
            TicketRepository = ticketRepository;
            _dbContext = dbContext;
        }
    }
}
