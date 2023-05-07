using DucklingProject.BLL;
using DucklingProject.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DucklingProject.PL
{
    public partial class ModalManager : Form
    {
        public ModalManager()
        {
            InitializeComponent();
        }

        private void criaManagerButton_Click(object sender, EventArgs e)
        {
            try
            {
                TbManager new_manager = new TbManager();
                ManagerRepository managerRepository = new ManagerRepository();

                new_manager.ManagerName = managerNameBox.Text;
                managerRepository.Add(new_manager);

                MessageBox.Show("Manager inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
