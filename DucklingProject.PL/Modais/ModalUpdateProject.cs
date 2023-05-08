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
            try
            {
                ProjectRepository pr = new ProjectRepository();
                ManagerRepository mr = new ManagerRepository();
                StatusRepository sr = new StatusRepository();
                TbProject searched;

                searched = pr.GetByName(name_textbox.Text);

                manager_combobox.Text = mr.GetById(searched.IdManager).ManagerName;
                status_combobox.Text = sr.GetById(searched.IdStatus).Status;
                description_textbox.Text = searched.ProjectDescription;
                finishdate_picker.Text = searched.DtFinish;
                startdate_picker.Text = searched.DtStart;
                id = searched.IdProject;

                MessageBox.Show("Project found! Data retrived");
            }catch (Exception ex)
            {
                MessageBox.Show("Project not found, check the name!");
            }
        }

        private void statusBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StatusRepository sr = new StatusRepository();

            sr.GetAll().ForEach(ts =>
            {
                if (!status_combobox.Items.Contains(ts.Status))
                {
                    status_combobox.Items.Add(ts.Status);
                }
            });
        }

        private void managersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ManagerRepository mr = new ManagerRepository();

            mr.GetAll().ForEach(tm =>
            {
                if (!manager_combobox.Items.Contains(tm.ManagerName))
                {
                    manager_combobox.Items.Add(tm.ManagerName);
                }
            });

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectRepository pr = new ProjectRepository();
                ManagerRepository mr = new ManagerRepository();
                StatusRepository sr = new StatusRepository();

                TbProject update = new TbProject();

                update.IdProject = id;
                update.ProjectName = name_textbox.Text;
                update.IdManager = mr.GetByName(manager_combobox.Text).IdManager;
                update.IdStatus = sr.GetByName(status_combobox.Text).IdStatus;
                update.ProjectDescription = description_textbox.Text;
                update.DtFinish = finishdate_picker.Text;
                update.DtStart = startdate_picker.Text;
                pr.Update(update);

                MessageBox.Show("Project updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stausadd_button_Click(object sender, EventArgs e)
        {
            ModalStatus ms = new ModalStatus();
            ms.Show();
        }

        private void manageradd_button_Click_1(object sender, EventArgs e)
        {
            ModalManager ms = new ModalManager();
            ms.Show();
        }
    }
}
