using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public partial class frmCadInstrutor : Form
    {
        public frmCadInstrutor()
        {
            InitializeComponent();
        }

        private void txtNomeCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskDataNascCadInstrutor.Enabled = true;
                mskDataNascCadInstrutor.Focus();
            }
        }

        private void mskDataNascCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCargoCadInstrutor.Enabled=true;
                txtCargoCadInstrutor.Focus();
            }
        }

        private void txtCargoCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboEspecialidadeCadInstrutor.Enabled = true;
                comboEspecialidadeCadInstrutor.Focus();
            }
        }

        private void comboEspecialidadeCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmailCadInstrutor.Enabled = true;
                txtEmailCadInstrutor.Focus();
            }
        }

        private void txtEmailCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenhaCadInstrutor.Enabled = true;
                txtSenhaCadInstrutor.Focus();
            }
        }

        private void txtSenhaCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboNivelCadInstrutor.Enabled = true;
                comboNivelCadInstrutor.Focus();
            }
        }


        private void comboNivelCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskTelefoneCadInstrutor.Enabled = true;
                mskTelefoneCadInstrutor.Focus();
            }
        }

        private void mskTelefoneCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdDataAdmiCadInstrutor.Enabled = true;
                mkdDataAdmiCadInstrutor.Focus();
            }
        }

        private void mkdDataAdmiCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboStatusCadInstrutor.Enabled = true;
                comboStatusCadInstrutor.Focus();
            }
        }

        private void comboStatusCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtFaceCadInstrutor.Enabled = true;
                txtFaceCadInstrutor.Focus();
            }
        }

        private void txtFaceCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtInstaCadInstrutor.Enabled = true;
                txtInstaCadInstrutor.Focus();
            }
        }

        private void txtInstaCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLinkeCadInstrutor.Enabled = true;
                txtLinkeCadInstrutor.Focus();
            }
        }

        private void txtLinkeCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtWhatsCadInstrutor.Enabled = true;
                txtWhatsCadInstrutor.Focus();
            }
        }

        private void txtWhatsCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnMaisCadInstrutor.Enabled = true;
                btnMaisCadInstrutor.Focus();
            }
        }

        private void btnMaisCadInstrutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "Selecione uma foto:";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg;*.png";
                ofdFoto.CheckPathExists = true; //Checar se o caminho existe
                ofdFoto.CheckFileExists = true;//Checar se o arquivo existe
                ofdFoto.RestoreDirectory = true;//Restaurar ao diretório inicial

                DialogResult dr = ofdFoto.ShowDialog();
                pctCadInstrutor.Image = Image.FromFile(ofdFoto.FileName);
                variaveis.fotoInstrutor = "funcionario/" + Regex.Replace(txtNomeCadInstrutor.Text, @"\s", "").ToLower() + ".png";

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoInstrutor = "S";
                        variaveis.caminhoFotoInstrutor = ofdFoto.FileName;

                    }
                    catch (SecurityException ex) 
                    {
                        MessageBox.Show("Erro de segurança - Fale com o Admin.\n Mensagem: " + ex.Message + "\n Detalhe: " +  ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Você não tem permissão. \n Mensagem: " + ex.Message);
                    }
                }
                btnSalvarCadInstrutor.Enabled = true;
                btnSalvarCadInstrutor.Focus();
            }
            catch 
            {
                btnSalvarCadInstrutor.Enabled = true;
                btnSalvarCadInstrutor.Focus();
            }
        }
    }
}
