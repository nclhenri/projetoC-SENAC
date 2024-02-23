namespace telaLogin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.pctMostrar = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pctSenha = new System.Windows.Forms.PictureBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.pnlSenha);
            this.pnlLogin.Controls.Add(this.pnlEmail);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.pctFechar);
            this.pnlLogin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(488, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(500, 500);
            this.pnlLogin.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.btnEntrar.Location = new System.Drawing.Point(100, 350);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(300, 50);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.Color.White;
            this.pnlSenha.Controls.Add(this.pctMostrar);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Controls.Add(this.pctSenha);
            this.pnlSenha.Location = new System.Drawing.Point(79, 237);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(340, 50);
            this.pnlSenha.TabIndex = 5;
            // 
            // pctMostrar
            // 
            this.pctMostrar.Location = new System.Drawing.Point(320, 35);
            this.pctMostrar.Name = "pctMostrar";
            this.pctMostrar.Size = new System.Drawing.Size(20, 15);
            this.pctMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMostrar.TabIndex = 2;
            this.pctMostrar.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtSenha.Location = new System.Drawing.Point(48, 10);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(289, 27);
            this.txtSenha.TabIndex = 1;
            // 
            // pctSenha
            // 
            this.pctSenha.Image = global::telaLogin.Properties.Resources.senha;
            this.pctSenha.Location = new System.Drawing.Point(5, 5);
            this.pctSenha.Name = "pctSenha";
            this.pctSenha.Size = new System.Drawing.Size(40, 40);
            this.pctSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSenha.TabIndex = 0;
            this.pctSenha.TabStop = false;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.pctEmail);
            this.pnlEmail.Location = new System.Drawing.Point(79, 167);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(340, 50);
            this.pnlEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtEmail.Location = new System.Drawing.Point(48, 10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 27);
            this.txtEmail.TabIndex = 1;
            
            // 
            // pctEmail
            // 
            this.pctEmail.Image = global::telaLogin.Properties.Resources.email;
            this.pctEmail.Location = new System.Drawing.Point(5, 5);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(40, 40);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmail.TabIndex = 0;
            this.pctEmail.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.lblLogin.Location = new System.Drawing.Point(158, 70);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(186, 71);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // pctFechar
            // 
            this.pctFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFechar.Image = global::telaLogin.Properties.Resources.fechar;
            this.pctFechar.Location = new System.Drawing.Point(448, 12);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(40, 40);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFechar.TabIndex = 2;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::telaLogin.Properties.Resources.logoVivaBem;
            this.pctLogo.Location = new System.Drawing.Point(38, 167);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(400, 166);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 3;
            this.pctLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 500);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.PictureBox pctMostrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pctSenha;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pctFechar;
    }
}