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

        private void btnMaisCadInstrutor_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Erro de segurança - Fale com o Admin.\n Mensagem: " + ex.Message + "\n Detalhe: " + ex.StackTrace);
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

        private void btnSalvarCadInstrutor_Click(object sender, EventArgs e)
        {
            lblNomeCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            mskDataNascCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtCargoCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            comboEspecialidadeCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtEmailCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtSenhaCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            comboNivelCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            mskTelefoneCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            mkdDataAdmiCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            comboStatusCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtFaceCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtInstaCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtLinkeCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);
            txtWhatsCadInstrutor.ForeColor = Color.FromArgb(242, 183, 5);

            if (txtNomeCadInstrutor.Text.Length <= 5)
            {
                MessageBox.Show("O nome digitado não atende aos requisitos!");
                txtNomeCadInstrutor.Clear();
                txtNomeCadInstrutor.Focus();
                lblNomeCadInstrutor.ForeColor = Color.Red;
            }
            else if (mskDataNascCadInstrutor.MaskCompleted == false) 
            {
                MessageBox.Show("Favor colocar a data de nascimento completa!");
                mskDataNascCadInstrutor.Clear();
                mskDataNascCadInstrutor.Focus();
                lblDataNascCadInstrutor.ForeColor= Color.Red;
            }
            else if (txtCargoCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o cargo!");
                txtCargoCadInstrutor.Clear();
                txtCargoCadInstrutor.Focus();
                lblCargoCadInstrutor.ForeColor = Color.Red;
            }
            else if (comboEspecialidadeCadInstrutor.Text == "")
            {
                MessageBox.Show("Favor preencher a especialidade!");
                comboEspecialidadeCadInstrutor.SelectedIndex = -1;
                comboEspecialidadeCadInstrutor.Focus();
                lblEspecialidadeCadInstrutor.ForeColor = Color.Red;
            }
            else if (txtEmailCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o email!");
                txtEmailCadInstrutor.Clear();
                txtEmailCadInstrutor.Focus();
                lblEmailCadInstrutor.ForeColor = Color.Red;
            }
            else if (txtSenhaCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher a senha!");
                txtSenhaCadInstrutor.Clear();
                txtSenhaCadInstrutor.Focus();
                lblSenhaCadInstrutor.ForeColor = Color.Red;
            }
            else if (comboNivelCadInstrutor.Text == "")
            {
                MessageBox.Show("Favor preencher o nível!");
                comboNivelCadInstrutor.SelectedIndex = -1;
                comboNivelCadInstrutor.Focus();
                lblNivelCadInstrutor.ForeColor = Color.Red;
            }
            else if (mskTelefoneCadInstrutor.MaskCompleted == false)
            {
                MessageBox.Show("Favor preencher o telefone!");
                mskTelefoneCadInstrutor.Clear();
                mskTelefoneCadInstrutor.Focus();
                lblTelefoneCadInstrutor.ForeColor = Color.Red;
            }
            else if (mkdDataAdmiCadInstrutor.MaskCompleted == false)
            {
                MessageBox.Show("Favor preencher a data de admissão!");
                mkdDataAdmiCadInstrutor.Clear();
                mkdDataAdmiCadInstrutor.Focus();
                lblDataAdmiCadInstrutor.ForeColor = Color.Red;
            }
            else if (comboStatusCadInstrutor.Text == "")
            {
                MessageBox.Show("Favor preencher o status!");
                comboStatusCadInstrutor.SelectedIndex = -1;
                comboStatusCadInstrutor.Focus();
                lblStatusCadInstrutor.ForeColor = Color.Red;
            }
            else if (txtFaceCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o link do Facebook!");
                txtFaceCadInstrutor.Clear();
                txtFaceCadInstrutor.Focus();
                lblFaceCadInstrutor.ForeColor = Color.Red;
            }
            else if (txtInstaCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o link do Instagram!");
                txtInstaCadInstrutor.Clear();
                txtInstaCadInstrutor.Focus();
                lblInstaCadInstrutor.ForeColor = Color.Red;
            }
            else if (txtLinkeCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o link do Linkedin!");
                txtLinkeCadInstrutor.Clear();
                txtLinkeCadInstrutor.Focus();
                lblLinkeCadInstrutor.ForeColor = Color.Red;
            }
            else if (txtWhatsCadInstrutor.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher o link do WhatsApp!");
                txtWhatsCadInstrutor.Clear();
                txtWhatsCadInstrutor.Focus();
                lblWhatsCadInstrutor.ForeColor = Color.Red;
            }
            else
            {
                variaveis.nomeInstrutor = txtNomeCadInstrutor.Text;
                variaveis.altInstrutor = Regex.Replace(txtNomeCadInstrutor.Text, @"\s", "").ToLower();
                variaveis.dataNascInstrutor = DateTime.Parse(mskDataNascCadInstrutor.Text);
                variaveis.cargoInstrutor = txtCargoCadInstrutor.Text;
                variaveis.especialidadeInstrutor = comboEspecialidadeCadInstrutor.Text;
                variaveis.emailInstrutor = txtEmailCadInstrutor.Text;
                variaveis.senhaInstrutor = txtSenhaCadInstrutor.Text;
                variaveis.nivelInstrutor = comboNivelCadInstrutor.Text;
                variaveis.telefoneInstutor = mskTelefoneCadInstrutor.Text;
                variaveis.dataAdmInstrutor = DateTime.Parse(mkdDataAdmiCadInstrutor.Text);
                variaveis.statusInstrutor = comboStatusCadInstrutor.Text;
                variaveis.faceInstrutor = txtFaceCadInstrutor.Text;
                variaveis.instaInstrutor = txtInstaCadInstrutor.Text;
                variaveis.linkedinInstrutor = txtLinkeCadInstrutor.Text;
                variaveis.whatsInstrutor = txtWhatsCadInstrutor.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirFuncionario();
                    btnSalvarCadInstrutor.Enabled = false;
                    btnLimparCadInstrutor.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR") 
                {

                }
                btnLimparCadInstrutor.Enabled = false;
            }
        }
    }
}
