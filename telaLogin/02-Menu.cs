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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            lblUsuario.Text = variaveis.usuario;
            lblData.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                Close();
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            banco.CarregarQuantidadeInstrutor();
            lblNumInstrutor.Text = variaveis.QuantidadeInstrutor.ToString();

            banco.CarregarQuantidadeAluno();
            lblNumAluno.Text = variaveis.QuantidadeAluno.ToString();

            banco.CarregarQuantidadePlano();
            lblNumPlano.Text = variaveis.QuantidadePlano.ToString();

            banco.CarregarQuantidadeTreino();
            lblNumTreino.Text = variaveis.QuantidadeTreino.ToString();

            banco.CarregarQuantidadeMatricula();
            lblNumMatricula.Text = variaveis.QuantidadeMatricula.ToString();

            banco.CarregarQuantidadeExercicio();
            lblExercicio.Text = variaveis.QuantidadeExercicio.ToString();

            banco.dgSomaPlanos = dgvValorPlanos;
            banco.CarregarSomaPlanos();

            banco.dgContato = dgvContato;
            banco.CarregarContato();
        }

        private void dgvValorPlanos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Analisar qual coluna estamos formatando e se ela está com informação
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                // verificar se no registro existe a palavra plano
                string valor = e.Value.ToString();
                if (valor.Contains("Plano"))
                {
                    //Remover a palavra 'Plano' e o espaço do valor
                    valor = valor.Replace("Plano ", "");
                    //Definir o valor da variável na célula da Grid
                    e.Value = valor;
                    //Entender que a célula foi formatada e aplicar
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvContato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var resposta = MessageBox.Show("O E-MAIL foi RESPONDIDO?", "E-MAIL", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
                if (variaveis.linhaSelecionada >= 0)
                {
                    variaveis.codContato = Convert.ToInt32(dgvContato[0, variaveis.linhaSelecionada].Value);
                    banco.AlterarStatusEmail();
                    banco.dgContato = dgvContato;
                    banco.CarregarContato();
                }
            }
        }

        private void btnInstrutor_Click(object sender, EventArgs e)
        {
            new frmInstrutor().Show();
            Hide();
        }
    }
}
