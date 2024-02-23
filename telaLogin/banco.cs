using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public static class banco
    {

        public static DataGridView dgSomaPlanos, dgContato, dgInstrutor;

        //-------------------------------------FOTO----------------------------------------

        //Validação da classe FTP
        private static bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Converter a Imagem em Byte
        public static byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpclient = new WebClient();
            ftpclient.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            byte[] imageToByte = ftpclient.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        //Converter a imagem de Byte para IMG
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        //-------------------------------------FOTO----------------------------------------



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

        public static void InserirFuncionario() 
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblfuncionarios(nomeFuncionario, altFuncionario, dataNascFuncionario, cargoFuncionario, especialidadeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, telefoneFuncionario, dataAdmissaoFuncionario, statusFuncionario,linkFaceFuncionario, linkInstaFuncionario, linkLinkedinFuncionario, linkWhatsFuncionario, fotoFuncionario) VALUES (@nome, @alt, @dataNasc, @cargo, @especialidade, @email, @senha, @nivel, @telefone, @dataAdmissao, @status, @linkFace, @linkInsta, @linkLinkedin, @linkWhats, @foto)";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeInstrutor);
                cmd.Parameters.AddWithValue("@alt", variaveis.altInstrutor);
                cmd.Parameters.AddWithValue("@dataNasc", variaveis.dataNascInstrutor);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoInstrutor);
                cmd.Parameters.AddWithValue("@especialidade", variaveis.especialidadeInstrutor);
                cmd.Parameters.AddWithValue("@email", variaveis.emailInstrutor);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaInstrutor);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelInstrutor);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneInstutor);
                cmd.Parameters.AddWithValue("@dataAdmissao", variaveis.dataAdmInstrutor);
                cmd.Parameters.AddWithValue("@status", variaveis.statusInstrutor);
                cmd.Parameters.AddWithValue("@linkFace", variaveis.faceInstrutor);
                cmd.Parameters.AddWithValue("@linkInsta", variaveis.faceInstrutor);
                cmd.Parameters.AddWithValue("@linkLinkedin", variaveis.linkedinInstrutor);
                cmd.Parameters.AddWithValue("@linkWhats", variaveis.whatsInstrutor);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoInstrutor);
                //fim parâmetros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário cadastrado com sucesso!", "CADASTRO FUNCIONÁRIO");
                conexao.Desconectar();

                //Inserir a foto na pasta ftp
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoInstrutor))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoInstrutor); // nome da pasta aonde ira ser armazenado as fotos (de acordo com o projeto (funcionario))
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoInstrutor, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch 
                        {
                            MessageBox.Show("Foto não selecionada ou existente.", "FOTO");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void CarregarDadosFuncionarios()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutor);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeInstrutor = reader.GetString(1);
                    variaveis.dataNascInstrutor = reader.GetDateTime(3);
                    variaveis.cargoInstrutor = reader.GetString(4);
                    variaveis.especialidadeInstrutor = reader.GetString(5);
                    variaveis.emailInstrutor = reader.GetString(6);
                    variaveis.senhaInstrutor = reader.GetString(7);
                    variaveis.nivelInstrutor = reader.GetString(8);
                    variaveis.telefoneInstutor = reader.GetString(9);
                    variaveis.dataAdmInstrutor = reader.GetDateTime(10);
                    variaveis.statusInstrutor = reader.GetString(11);
                    variaveis.fotoInstrutor = reader.GetString(12);
                    variaveis.fotoInstrutor = variaveis.fotoInstrutor.Remove(0, 12);
                    variaveis.faceInstrutor = reader.GetString(13);
                    variaveis.instaInstrutor = reader.GetString(14);
                    variaveis.linkedinInstrutor = reader.GetString(15);
                    variaveis.whatsInstrutor = reader.GetString(16);
                }
                conexao.Desconectar();
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao carregar os dados do funcionário!! \n\n" + erro);
            }
        }

        public static void AlterarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string inserir = "UPDATE tblfuncionarios SET nomeFuncionario=@nome,altFuncionario=@alt,dataNascFuncionario=@dataNasc,cargoFuncionario=@cargo,especialidadeFuncionario=@especialidade,emailFuncionario=@email,senhaFuncionario=@senha,nivelFuncionario=@nivel,telefoneFuncionario=@telefone,dataAdmissaoFuncionario=@dataAdmissao,statusFuncionario=@status,linkFaceFuncionario=@linkFace,linkInstaFuncionario=@linkInsta,linkLinkedinFuncionario=@linkLinkedin,linkWhatsFuncionario=@linkWhats WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeInstrutor);
                cmd.Parameters.AddWithValue("@alt", variaveis.altInstrutor);
                cmd.Parameters.AddWithValue("@dataNasc", variaveis.dataNascInstrutor);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoInstrutor);
                cmd.Parameters.AddWithValue("@especialidade", variaveis.especialidadeInstrutor);
                cmd.Parameters.AddWithValue("@email", variaveis.emailInstrutor);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaInstrutor);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelInstrutor);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneInstutor);
                cmd.Parameters.AddWithValue("@dataAdmissao", variaveis.dataAdmInstrutor);
                cmd.Parameters.AddWithValue("@status", variaveis.statusInstrutor);
                cmd.Parameters.AddWithValue("@linkFace", variaveis.faceInstrutor);
                cmd.Parameters.AddWithValue("@linkInsta", variaveis.faceInstrutor);
                cmd.Parameters.AddWithValue("@linkLinkedin", variaveis.linkedinInstrutor);
                cmd.Parameters.AddWithValue("@linkWhats", variaveis.whatsInstrutor);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutor);
                //fim parâmetros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário alterado com sucesso!", "ALTERAÇÃO DO FUNCIONÁRIO");
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void AlterarFotoFuncionario()
        {

            try
            {
                conexao.Conectar();
                string inserir = "UPDATE tblfuncionarios SET fotoFuncionario = @foto WHERE idFuncionario=@codigo";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoInstrutor);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codInstrutor);
                //fim parâmetros

                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoInstrutor))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoInstrutor); // nome da pasta aonde ira ser armazenado as fotos (de acordo com o projeto (funcionario))
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoInstrutor, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não selecionada ou existente.", "FOTO");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar a foto do Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }
    }
}
