using DucklingProject.MODEL;
using DucklingProject.DAL.DBContext;

namespace DucklingProject.BLL
{
    public class StatusRepository
    {
        public void Add(TbStatus _status)
        {          
            using (var dbContext = new DbSet())
            {
                dbContext.Add(_status);
                dbContext.SaveChanges();
            }
        }

        public List<TbStatus> GetAll()
        {
            using (var dbContext = new DbSet())
            {
                var all_status = dbContext.TbStatuses.ToList();
                return all_status;
            }
        }
    }
}