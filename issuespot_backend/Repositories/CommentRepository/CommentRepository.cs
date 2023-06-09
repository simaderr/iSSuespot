using issuespot_backend.Database;
using issuespot_backend.Models;
using issuespot_backend.Repositories.GenericRepository;

namespace issuespot_backend.Repositories.CommentRepository
{
    public class CommentRepository: GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext context) : base(context) { } 
    }
}
