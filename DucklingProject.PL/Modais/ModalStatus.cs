using DucklingProject.BLL;
using DucklingProject.MODEL;
using Microsoft.VisualBasic;
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
    public partial class ModalStatus : Form
    {
        public ModalStatus()
        {
            InitializeComponent();
        }

        private void criaStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                TbStatus status = new TbStatus();
                StatusRepository statusRepository = new StatusRepository();

                status.Status = inserirStatusBox.Text;
                statusRepository.Add(status);

                MessageBox.Show("Status inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
