using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public partial class frmInstrutor : Form
    {
        public frmInstrutor()
        {
            InitializeComponent();
        }

        private void frmInstrutor_Load(object sender, EventArgs e)
        {
            banco.dgInstrutor = dgvInstrutor;
            banco.CarregarInstrutor();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeInstrutor = txtNome.Text;
            banco.CarregarInstrutorNome();

            if (txtNome.Text == "")
            {
                chbStatus.Enabled = true;
            }
            else { chbStatus.Enabled = false; }
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStatus.Checked == true)
            {
                banco.CarregarInstrutorStatus();
                txtNome.Enabled = false;
            }
            else
            {
                banco.CarregarInstrutor();
                txtNome.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadInstrutor().Show();
            Hide();
        }
    }
}
