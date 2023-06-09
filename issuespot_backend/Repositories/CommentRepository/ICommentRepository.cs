using issuespot_backend.Models;
using issuespot_backend.Repositories.GenericRepository;

namespace issuespot_backend.Repositories.CommentRepository
{
    public interface ICommentRepository: IGenericRepository<Comment>
    {
    }
}
