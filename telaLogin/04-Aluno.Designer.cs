﻿namespace telaLogin
{
    partial class frmAluno
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
            this.pnlAluno = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.pnlAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAluno
            // 
            this.pnlAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.pnlAluno.Controls.Add(this.btnExcluir);
            this.pnlAluno.Controls.Add(this.btnAlterar);
            this.pnlAluno.Controls.Add(this.btnCadastrar);
            this.pnlAluno.Controls.Add(this.dgvAluno);
            this.pnlAluno.Controls.Add(this.pctFechar);
            this.pnlAluno.Controls.Add(this.lblAtivo);
            this.pnlAluno.Controls.Add(this.chbStatus);
            this.pnlAluno.Controls.Add(this.lblStatus);
            this.pnlAluno.Controls.Add(this.txtNome);
            this.pnlAluno.Controls.Add(this.lblNome);
            this.pnlAluno.Controls.Add(this.lblAluno);
            this.pnlAluno.Location = new System.Drawing.Point(6, 5);
            this.pnlAluno.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAluno.Name = "pnlAluno";
            this.pnlAluno.Size = new System.Drawing.Size(1203, 616);
            this.pnlAluno.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(869, 517);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(184, 42);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(570, 517);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(184, 42);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(268, 517);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(184, 42);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dgvAluno
            // 
            this.dgvAluno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(268, 135);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(785, 376);
            this.dgvAluno.TabIndex = 7;
            // 
            // pctFechar
            // 
            this.pctFechar.Image = global::telaLogin.Properties.Resources.fechar;
            this.pctFechar.Location = new System.Drawing.Point(1014, 91);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(39, 38);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFechar.TabIndex = 6;
            this.pctFechar.TabStop = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblAtivo.Location = new System.Drawing.Point(931, 101);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(67, 21);
            this.lblAtivo.TabIndex = 5;
            this.lblAtivo.Text = "ATIVO?";
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Location = new System.Drawing.Point(910, 105);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(15, 14);
            this.chbStatus.TabIndex = 4;
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblStatus.Location = new System.Drawing.Point(827, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 21);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "STATUS:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(332, 94);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(489, 30);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblNome.Location = new System.Drawing.Point(264, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME:";
            // 
            // lblAluno
            // 
            this.lblAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblAluno.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(1, 0);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAluno.Size = new System.Drawing.Size(117, 616);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "A\r\nL\r\nU\r\nN\r\nO\r\nS";
            this.lblAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1214, 626);
            this.Controls.Add(this.pnlAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAluno";
            this.Text = "Form3";
            this.pnlAluno.ResumeLayout(false);
            this.pnlAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAluno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAluno;
    }
}