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
                if(dbContext.TbProjects.ToList() != null)
                {
                    return dbContext.TbProjects.ToList();
                }
                else
                {
                    return new List<TbProject>();
                }
                
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
        public void Update(TbProject _projeto)
        {
            using (var dbContext = new DbSet())
            {
                var project = dbContext.TbProjects.Single(p => p.IdProject == _projeto.IdProject);
                project.IdProject = _projeto.IdProject;
                project.ProjectDescription = _projeto.ProjectDescription;
                project.DtStart = _projeto.DtStart;
                project.DtFinish = _projeto.DtFinish;
                project.ProjectName = _projeto.ProjectName;
                project.IdStatus = _projeto.IdStatus;
                dbContext.SaveChanges();
            }
        }

        public void DeleteByName(string nome)
        {
            using (var dbContext = new DbSet())
            {
                var project = dbContext.TbProjects.Single(p => p.ProjectName == nome);
                dbContext.Remove(project);
                dbContext.SaveChanges();
            }
        }
    }
}
