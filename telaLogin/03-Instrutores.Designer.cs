namespace telaLogin
{
    partial class frmInstrutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInstrutor = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvInstrutor = new System.Windows.Forms.DataGridView();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInstrutor = new System.Windows.Forms.Label();
            this.pnlInstrutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInstrutor
            // 
            this.pnlInstrutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.pnlInstrutor.Controls.Add(this.btnExcluir);
            this.pnlInstrutor.Controls.Add(this.btnAlterar);
            this.pnlInstrutor.Controls.Add(this.btnCadastrar);
            this.pnlInstrutor.Controls.Add(this.dgvInstrutor);
            this.pnlInstrutor.Controls.Add(this.pctFechar);
            this.pnlInstrutor.Controls.Add(this.lblAtivo);
            this.pnlInstrutor.Controls.Add(this.chbStatus);
            this.pnlInstrutor.Controls.Add(this.lblStatus);
            this.pnlInstrutor.Controls.Add(this.txtNome);
            this.pnlInstrutor.Controls.Add(this.lblNome);
            this.pnlInstrutor.Controls.Add(this.lblInstrutor);
            this.pnlInstrutor.Location = new System.Drawing.Point(4, 5);
            this.pnlInstrutor.Margin = new System.Windows.Forms.Padding(5);
            this.pnlInstrutor.Name = "pnlInstrutor";
            this.pnlInstrutor.Size = new System.Drawing.Size(1203, 616);
            this.pnlInstrutor.TabIndex = 0;
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
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvInstrutor
            // 
            this.dgvInstrutor.AllowUserToAddRows = false;
            this.dgvInstrutor.AllowUserToDeleteRows = false;
            this.dgvInstrutor.AllowUserToResizeColumns = false;
            this.dgvInstrutor.AllowUserToResizeRows = false;
            this.dgvInstrutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.dgvInstrutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstrutor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstrutor.Location = new System.Drawing.Point(268, 135);
            this.dgvInstrutor.Name = "dgvInstrutor";
            this.dgvInstrutor.ReadOnly = true;
            this.dgvInstrutor.RowHeadersVisible = false;
            this.dgvInstrutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstrutor.Size = new System.Drawing.Size(785, 376);
            this.dgvInstrutor.TabIndex = 7;
            this.dgvInstrutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstrutor_CellClick);
            this.dgvInstrutor.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInstrutor_ColumnHeaderMouseClick);
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
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
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
            this.chbStatus.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
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
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
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
            // lblInstrutor
            // 
            this.lblInstrutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.lblInstrutor.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrutor.Location = new System.Drawing.Point(1, 0);
            this.lblInstrutor.Name = "lblInstrutor";
            this.lblInstrutor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInstrutor.Size = new System.Drawing.Size(117, 616);
            this.lblInstrutor.TabIndex = 0;
            this.lblInstrutor.Text = "I\r\nN\r\nS\r\nT\r\nR\r\nU\r\nT\r\nO\r\nR\r\nE\r\nS";
            this.lblInstrutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInstrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1214, 626);
            this.Controls.Add(this.pnlInstrutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstrutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmInstrutor_Load);
            this.pnlInstrutor.ResumeLayout(false);
            this.pnlInstrutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInstrutor;
        private System.Windows.Forms.Label lblInstrutor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvInstrutor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}