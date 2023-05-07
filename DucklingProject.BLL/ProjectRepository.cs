using DucklingProject.MODEL;
using DucklingProject.DAL.DBContext;

namespace DucklingProject.BLL
{
    public class ProjectRepository
    {
        public void Add(TbProject _project)
        {
            using (var dbContext = new DbSet())
            {
                dbContext.Add(_project);
                dbContext.SaveChanges();
            }
        }

        public List<TbProject> GetAll()
        {
            using (var dbContext = new DbSet())
            {
                var all_projects = dbContext.TbProjects.ToList();
                return all_projects;
            }
        }

        public TbProject GetById(int id)
        {
            using (var dbContext = new DbSet())
            {
                var project = dbContext.TbProjects.Single(p => p.IdProject == id);
                return project;
            }
        }

        public TbProject GetByName(string projectName)
        {
            using (var dbContext = new DbSet())
            {
                var project = dbContext.TbProjects.Single(p => p.ProjectName == projectName);
                return project;
            }
        }
    }
}
