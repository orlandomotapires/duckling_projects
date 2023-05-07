

namespace DucklingProject.MODEL;

public partial class TbManager
{
    public int IdManager { get; set; }

    public string ManagerName { get; set; } = null!;

    public virtual ICollection<TbProject> TbProjects { get; set; } = new List<TbProject>();
}
