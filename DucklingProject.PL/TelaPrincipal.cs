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
            ts.Location = new Point(0, 0);
            ts.Show();
        }

        private void deleteproject_button_Click(object sender, EventArgs e)
        {
            ProjectRepository pr = new ProjectRepository();
            foreach (ListViewItem item in projects_listview.Items)
            {
                if (item.Checked)
                {
                    pr.DeleteByName(item.Text);
                    MessageBox.Show("Project: " + item.Text + " sucessfully deleted!");
                }
            }

        }

        private void updateproject_button_Click(object sender, EventArgs e)
        {
            ModalUpdateProject ts = new ModalUpdateProject();
            ts.Location = new Point(0, 0);
            ts.Show();
        }

        public void projectsLog()
        {
            projects_listview.Items.Clear();
            ProjectRepository pr = new ProjectRepository();
            ManagerRepository mr = new ManagerRepository();
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

                if (logItem.IdManager != null)
                {
                    var managerName = mr.GetById(logItem.IdManager);
                    lvi.SubItems.Add(managerName.ManagerName);
                }
                else
                {
                    lvi.SubItems.Add("---");
                }

                if (!projects_listview.Items.Contains(lvi))
                {
                    projects_listview.Items.Add(lvi);
                }
              
            }

            projects_listview.Dock = DockStyle.Fill;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            projectsLog();
        }

        private void ProjectsLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            projectsLog();
        }

        private void delete_label_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}