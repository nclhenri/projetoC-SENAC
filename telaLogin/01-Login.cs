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
    public partial class Form1 : Form
    {
        int mostrar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pctFechar_MouseEnter(object sender, EventArgs e)
        {
            //Qaundo o mouse passar por cima dele 
            pctFechar.Size = new Size(44, 44); //Nova Medida
            pctFechar.Location = new Point(446, 10); // Nova Posição
        }

        private void pctFechar_MouseLeave(object sender, EventArgs e)
        {
            //Qaundo o mouse sair de cima dele 
            pctFechar.Size = new Size(40, 40); //volta medida
            pctFechar.Location = new Point(448, 10); // Volta Posição
        }

        private void pctMostrar_Click(object sender, EventArgs e)
        {
            if (mostrar == 0)
            {
                txtSenha.PasswordChar = '\0';
                pctMostrar.Image = Properties.Resources.esconder;
                mostrar = 1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pctMostrar.Image = Properties.Resources.mostrar; //ao click ela vai mostrar o olho diferente
                mostrar = 0;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtEmail.Text;
            new frmMenuPrincipal().Show();
            Hide();
        }

    }
}
