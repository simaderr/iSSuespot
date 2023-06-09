using issuespot_backend.Repositories.CommentRepository;
using issuespot_backend.Repositories.ProjectRepository;
using issuespot_backend.Repositories.TicketRepository;

namespace issuespot_backend.Repositories.UnicOfWork
{
    public interface IUnitOfWork
    {
        ICommentRepository CommentRepository { get; }   
        IProjectRepository ProjectRepository { get; }
        ITicketRepository TicketRepository { get; }
    }
}
