using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DucklingProject.MODEL;
using DucklingProject.BLL;

namespace DucklingProject.PL.Modais
{
    public partial class ModalUpdateProject : Form
    {
       
        public ModalUpdateProject()
        {
            InitializeComponent();
        }

        int id = -1;
        private void search_button_Click(object sender, EventArgs e)
        {
            ProjectRepository pr = new ProjectRepository();
            ManagerRepository mr = new ManagerRepository();
            StatusRepository sr = new StatusRepository();
            TbProject searched;

            searched = pr.GetByName(name_textbox.Text);

            managersComboBox.Text = mr.GetById(searched.IdManager).ManagerName;
            statusBox.Text = sr.GetById(searched.IdStatus).Status;
            description_textbox.Text = searched.ProjectDescription;
            finishdate_picker.Text = searched.DtFinish;
            dateTimePicker1.Text = searched.DtStart;
            id = searched.IdProject;
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

        private void update_button_Click(object sender, EventArgs e)
        {
            try{
                ProjectRepository pr = new ProjectRepository();
                ManagerRepository mr = new ManagerRepository();
                StatusRepository sr = new StatusRepository();

                TbProject update = new TbProject();

                update.IdProject = id;
                update.ProjectName = name_textbox.Text;
                update.IdManager = mr.GetByName(managersComboBox.Text).IdManager;
                update.IdStatus = sr.GetByName(statusBox.Text).IdStatus;
                update.ProjectDescription = description_textbox.Text;
                update.DtFinish = finishdate_picker.Text;
                update.DtStart = dateTimePicker1.Text;
                pr.Update(update);
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
