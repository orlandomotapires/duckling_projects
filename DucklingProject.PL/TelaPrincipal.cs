using DucklingProject.BLL;
using DucklingProject.MODEL;
using DucklingProject.PL.Modais;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DucklingProject.PL
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void createproject_button_Click(object sender, EventArgs e)
        {
            ModalCreateProject ts = new ModalCreateProject();
            ts.Show();
        }

        private void deleteproject_button_Click(object sender, EventArgs e)
        {

        }

        private void updateproject_button_Click(object sender, EventArgs e)
        {
            ModalUpdateProject ts = new ModalUpdateProject();
            ts.Show();
        }

        public void projectsLog()
        {
            ProjectsLog.Items.Clear();
            ProjectRepository pr = new ProjectRepository();
            List<TbProject> log = pr.GetAll();

            foreach (TbProject logItem in log)
            {
                ListViewItem lvi = new ListViewItem(logItem.ProjectName);

                if (logItem.DtStart != null)
                {
                    lvi.SubItems.Add(logItem.DtStart);
                }
                else
                {
                    lvi.SubItems.Add("---");
                }

                if (logItem.DtFinish != null)
                {
                    lvi.SubItems.Add(logItem.DtFinish);
                }
                else
                {
                    lvi.SubItems.Add("---");
                }

                if (!ProjectsLog.Items.Contains(lvi))
                {
                    ProjectsLog.Items.Add(lvi);
                }

            }

            ProjectsLog.Dock = DockStyle.Fill;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            projectsLog();
        }

        private void ProjectsLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            projectsLog();
        }
    }
}