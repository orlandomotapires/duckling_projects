using DucklingProject.MODEL;
using DucklingProject.DAL.DBContext;

namespace DucklingProject.BLL
{
    public class ManagerRepository
    {
        public void Add(TbManager _manager)
        {
            using (var dbContext = new DbSet())
            {
                dbContext.Add(_manager);
                dbContext.SaveChanges();
            }
        }

        public List<TbManager> GetAll()
        {
            using (var dbContext = new DbSet())
            {
                var all_managers = dbContext.TbManagers.ToList();
                return all_managers;
            }
        }

        public TbManager GetById(int id)
        {
            using (var dbContext = new DbSet())
            {
                var manager = dbContext.TbManagers.Single(p => p.IdManager == id);
                return manager;
            }
        }

        public TbManager GetByName(string name)
        {
            using (var dbContext = new DbSet())
            {
                var manager = dbContext.TbManagers.Single(p => p.ManagerName == name);
                return manager;
            }
        }
    }
}
