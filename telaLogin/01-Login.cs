using MySql.Data.MySqlClient;
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
            variaveis.senha = txtSenha.Text;

            if (variaveis.usuario == "NICOLAS" && variaveis.senha == "1234")
            {
                variaveis.nivel = "NIVEL 1";
                new frmMenuPrincipal().Show();
                Hide();
            }
            else
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT nomeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario FROM tblfuncionarios WHERE emailFuncionario = @email AND senhaFuncionario = @senha AND statusFuncionario = @status";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        variaveis.usuario = reader.GetString(0);
                        variaveis.nivel = reader.GetString(3);
                        new frmMenuPrincipal().Show();
                        Hide() ;
                    }
                    else
                    {
                        MessageBox.Show("Acesso Negado!");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao logar." + err);
                }
            }
        }

    }
}
