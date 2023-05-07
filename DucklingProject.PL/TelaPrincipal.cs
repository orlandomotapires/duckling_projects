using DucklingProject.BLL;
using DucklingProject.MODEL;

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
            ModalProjetos ts = new ModalProjetos();
            ts.newproject_label.Text = "Create project";
            ts.Show();


            TbProject project = new TbProject();
            project.DtStart = ts.name_label.Text;
        }

        private void deleteproject_button_Click(object sender, EventArgs e)
        {          

        }
    }
}