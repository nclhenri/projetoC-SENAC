using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public static class banco
    {

        public static DataGridView dgSomaPlanos, dgContato, dgInstrutor;
        public static void CarregarQuantidadeInstrutor()
        {
            try 
            {
                conexao.Conectar();
                string selecionar = "SELECT SUM(qtdeFuncionario) FROM vnumfuncespecativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.QuantidadeInstrutor = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }   
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a quantidade de instrutores!\n\n" + erro);
            }
        }

        public static void CarregarQuantidadeAluno()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnumalunosativos";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.QuantidadeAluno = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a quantidade de instrutores!\n\n" + erro);
            }
        }

        public static void CarregarQuantidadePlano()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnumplanoativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.QuantidadePlano = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a quantidade de instrutores!\n\n" + erro);
            }
        }

        public static void CarregarQuantidadeTreino()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnumtreinoativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.QuantidadeTreino = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a quantidade de instrutores!\n\n" + erro);
            }
        }

        public static void CarregarQuantidadeMatricula()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vnummatriculaativa";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.QuantidadeMatricula = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a quantidade de instrutores!\n\n" + erro);
            }
        }

        public static void CarregarQuantidadeExercicio()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT COUNT(grupoMuscularExercicio) FROM vnumgrupoexercativo";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.QuantidadeExercicio = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a quantidade de instrutores!\n\n" + erro);
            }
        }

        public static void CarregarSomaPlanos()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM vsomavaloresporplano";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgSomaPlanos.DataSource = dt;
                dgSomaPlanos.Columns[1].DefaultCellStyle.Format = "C2";

                dgSomaPlanos.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a soma de valores dos planos!\n\n" + erro);
            }
        }

        public static void CarregarContato()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcontato WHERE statusContato <> 'RESPONDIDO'";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;
                dgContato.Columns[0].Visible = false;
                dgContato.Columns[1].HeaderText = "Nome";
                dgContato.Columns[2].HeaderText = "E-mail";
                dgContato.Columns[3].HeaderText = "Telefone";
                dgContato.Columns[4].HeaderText = "Mensagem";
                dgContato.Columns[5].Visible = false;
                dgContato.Columns[6].Visible = false;
                dgContato.Columns[7].Visible = false;

                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os e-mails!\n\n" + erro);
            }
        }

        public static void AlterarStatusEmail()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblcontato SET statusContato='RESPONDIDO' WHERE idContato =" + variaveis.codContato;
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;
                

                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os e-mails!\n\n" + erro);
            }
        }

        public static void CarregarInstrutor()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios ORDER BY nomeFuncionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgInstrutor.DataSource = dt;
                dgInstrutor.Columns[0].Visible = false;
                dgInstrutor.Columns[1].HeaderText = "Nome";
                dgInstrutor.Columns[2].Visible = false;
                dgInstrutor.Columns[3].HeaderText = "Data Nascimento";
                dgInstrutor.Columns[4].HeaderText = "Cargo";
                dgInstrutor.Columns[5].HeaderText = "Especialidade";
                dgInstrutor.Columns[6].HeaderText = "E-mail";
                dgInstrutor.Columns[7].Visible = false;
                dgInstrutor.Columns[8].HeaderText = "Nível";
                dgInstrutor.Columns[9].HeaderText = "Telefone";
                dgInstrutor.Columns[10].HeaderText = "Data Admissão";
                dgInstrutor.Columns[11].HeaderText = "Status";
                dgInstrutor.Columns[12].HeaderText = "Foto";
                dgInstrutor.Columns[13].Visible = false;
                dgInstrutor.Columns[14].Visible = false;
                dgInstrutor.Columns[15].Visible = false;
                dgInstrutor.Columns[16].Visible = false;

                dgInstrutor.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os instrutores!\n\n" + erro);
            }
        }

        public static void CarregarInstrutorNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE nomeFuncionario LIKE '%"+variaveis.nomeInstrutor+"%' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgInstrutor.DataSource = dt;
                dgInstrutor.Columns[0].Visible = false;
                dgInstrutor.Columns[1].HeaderText = "Nome";
                dgInstrutor.Columns[2].Visible = false;
                dgInstrutor.Columns[3].HeaderText = "Data Nascimento";
                dgInstrutor.Columns[4].HeaderText = "Cargo";
                dgInstrutor.Columns[5].HeaderText = "Especialidade";
                dgInstrutor.Columns[6].HeaderText = "E-mail";
                dgInstrutor.Columns[7].Visible = false;
                dgInstrutor.Columns[8].HeaderText = "Nível";
                dgInstrutor.Columns[9].HeaderText = "Telefone";
                dgInstrutor.Columns[10].HeaderText = "Data Admissão";
                dgInstrutor.Columns[11].HeaderText = "Status";
                dgInstrutor.Columns[12].HeaderText = "Foto";
                dgInstrutor.Columns[13].Visible = false;
                dgInstrutor.Columns[14].Visible = false;
                dgInstrutor.Columns[15].Visible = false;
                dgInstrutor.Columns[16].Visible = false;

                dgInstrutor.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os instrutores!\n\n" + erro);
            }
        }

        public static void CarregarInstrutorStatus()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE statusFuncionario = 'ATIVO' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgInstrutor.DataSource = dt;
                dgInstrutor.Columns[0].Visible = false;
                dgInstrutor.Columns[1].HeaderText = "Nome";
                dgInstrutor.Columns[2].Visible = false;
                dgInstrutor.Columns[3].HeaderText = "Data Nascimento";
                dgInstrutor.Columns[4].HeaderText = "Cargo";
                dgInstrutor.Columns[5].HeaderText = "Especialidade";
                dgInstrutor.Columns[6].HeaderText = "E-mail";
                dgInstrutor.Columns[7].Visible = false;
                dgInstrutor.Columns[8].HeaderText = "Nível";
                dgInstrutor.Columns[9].HeaderText = "Telefone";
                dgInstrutor.Columns[10].HeaderText = "Data Admissão";
                dgInstrutor.Columns[11].HeaderText = "Status";
                dgInstrutor.Columns[12].HeaderText = "Foto";
                dgInstrutor.Columns[13].Visible = false;
                dgInstrutor.Columns[14].Visible = false;
                dgInstrutor.Columns[15].Visible = false;
                dgInstrutor.Columns[16].Visible = false;

                dgInstrutor.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os instrutores!\n\n" + erro);
            }
        }
    }
}
