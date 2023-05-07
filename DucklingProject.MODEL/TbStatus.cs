namespace DucklingProject.MODEL;
public partial class TbStatus
{
    public int IdStatus { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<TbProject> TbProjects { get; set; } = new List<TbProject>();
}
