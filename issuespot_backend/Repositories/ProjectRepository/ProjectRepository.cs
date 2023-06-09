using issuespot_backend.Database;
using issuespot_backend.Models;
using issuespot_backend.Repositories.GenericRepository;

namespace issuespot_backend.Repositories.ProjectRepository
{
    public class ProjectRepository: GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context) { }
    }
}
