using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telaLogin
{
    public static class variaveis
    {
        //Geral
        public static int linhaSelecionada;
        public static string funcao;
        //Geral
        //FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/img";
        public static string usuarioFtp = "vivabem";
        public static string senhaFtp = "123";
        //FTP

        //Login 
        public static string usuario, senha, nivel;
        // /Login

        //Menu
        public static int QuantidadeInstrutor, QuantidadeAluno, QuantidadeGrupoMuscular, QuantidadeMatricula, QuantidadePlano, QuantidadeTreino, QuantidadeValores, QuantidadeValoresPorPlano, QuantidadeExercicio, codContato;
        public static double somaGeral, somaPlano;
        // /Menu

        //Instrutor
        public static int codInstrutor;
        public static string nomeInstrutor, statusInstrutor, altInstrutor, cargoInstrutor, especialidadeInstrutor, emailInstrutor, senhaInstrutor, nivelInstrutor, telefoneInstutor, faceInstrutor, instaInstrutor, linkedinInstrutor, whatsInstrutor, fotoInstrutor, atFotoInstrutor, caminhoFotoInstrutor;
        public static DateTime dataNascInstrutor, dataAdmInstrutor;
        //Instrutor
    }
}
