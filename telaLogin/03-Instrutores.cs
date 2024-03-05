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
            variaveis.funcao = "CADASTRAR";

            new frmCadInstrutor().Show();
            Hide();
        }

        private void dgvInstrutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codInstrutor = Convert.ToInt32(dgvInstrutor[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvInstrutor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvInstrutor.Sort(dgvInstrutor.Columns[1], ListSortDirection.Ascending);
            dgvInstrutor.ClearSelection();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadInstrutor().Show();
            Hide() ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir? Essa ação não poderá ser desfeita!", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarFuncionario();
                    banco.CarregarInstrutor();
                    dgvInstrutor.ClearSelection() ;
                }
                else
                {
                    dgvInstrutor.ClearSelection();
                }
            }
        }
    }
}
