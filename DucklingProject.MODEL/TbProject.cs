namespace DucklingProject.MODEL;
public partial class TbProject
{
    public int IdProject { get; set; }

    public int IdManager { get; set; }

    public int IdStatus { get; set; }

    public string ProjectName { get; set; } = null!;

    public string ProjectDescription { get; set; } = null!;

    public string DtStart { get; set; } = null!;

    public string? DtFinish { get; set; }

    public virtual TbManager IdManagerNavigation { get; set; } = null!;

    public virtual TbStatus IdStatusNavigation { get; set; } = null!;
}
