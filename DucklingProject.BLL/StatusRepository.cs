using DucklingProject.MODEL;
using DucklingProject.DAL.DBContext;

namespace DucklingProject.BLL
{
    public class StatusRepository
    {
        int cont = 0;
        public void Add(TbStatus _status)
        {          
            using (var dbContext = new DbSet())
            {
                dbContext.Add(_status);
                dbContext.SaveChanges();
            }
        }
    }
}