using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public static class conexao
    {
        //string de conexão com o banco de dados
        public static string db = "SERVER=localhost;USER=root;DATABASE=dbvivabem";

        //reconhecer a biblioteca do MySQL
        public static MySqlConnection conn;
        //método para conectar o banco de dados
        public static void Conectar()
        {
            try
            {
                conn = new MySqlConnection(db);
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco de dados!");
            }
        }

        public static void Desconectar()
        {
            try 
            {
                conn = new MySqlConnection(db);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco de dados!");
            }
        }
    }
}

