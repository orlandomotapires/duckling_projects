using DucklingProject.BLL;

namespace DucklingProject.PL
{
    public partial class ModalProjetos : Form
    {
        public ModalProjetos()
        {
            InitializeComponent();
        }

        private void description_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addStatus_Click(object sender, EventArgs e)
        {
            ModalStatus ms = new ModalStatus();
            ms.Show();
        }

        private void criarManager_Click(object sender, EventArgs e)
        {
            ModalManager ms = new ModalManager();
            ms.Show();
        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void managersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRepository mr = new ManagerRepository();

            mr.GetAll().ForEach(tm =>
            {
                if (!managersComboBox.Items.Contains(tm.ManagerName))
                {
                    managersComboBox.Items.Add(tm.ManagerName);
                }
            });
        }

        private void statusBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StatusRepository sr = new StatusRepository();

            sr.GetAll().ForEach(ts =>
            {
                if (!statusBox.Items.Contains(ts.Status))
                {
                    statusBox.Items.Add(ts.Status);
                }
            });
        }
    }
}
