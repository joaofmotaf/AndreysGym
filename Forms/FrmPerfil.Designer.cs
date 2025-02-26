namespace AndreysGym.Forms
{
    partial class FrmPerfil
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblDataNascimento = new Label();
            txtConfirmarSenha = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            txtNome = new TextBox();
            mskCpf = new MaskedTextBox();
            txtEmail = new TextBox();
            txtNascimento = new TextBox();
            cmbPlano = new ComboBox();
            chkAdmin = new CheckBox();
            btnSalvar = new Button();
            lblPlano = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblNome, 0, 0);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCpf, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDataNascimento, 0, 3);
            tableLayoutPanel1.Controls.Add(txtConfirmarSenha, 1, 5);
            tableLayoutPanel1.Controls.Add(txtSenha, 1, 4);
            tableLayoutPanel1.Controls.Add(lblSenha, 0, 4);
            tableLayoutPanel1.Controls.Add(lblConfirmarSenha, 0, 5);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 0);
            tableLayoutPanel1.Controls.Add(mskCpf, 1, 2);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNascimento, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbPlano, 1, 6);
            tableLayoutPanel1.Controls.Add(chkAdmin, 1, 7);
            tableLayoutPanel1.Controls.Add(btnSalvar, 1, 8);
            tableLayoutPanel1.Controls.Add(lblPlano, 0, 6);
            tableLayoutPanel1.Location = new Point(14, 16);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(442, 327);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(87, 7);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(91, 42);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(104, 77);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.Right;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(49, 105);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(91, 40);
            lblDataNascimento.TabIndex = 3;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmarSenha.Location = new Point(146, 184);
            txtConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarSenha.MaxLength = 64;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(293, 27);
            txtConfirmarSenha.TabIndex = 11;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(146, 149);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.MaxLength = 64;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(293, 27);
            txtSenha.TabIndex = 10;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(41, 152);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(99, 20);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Alterar senha:";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(18, 187);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(122, 20);
            lblConfirmarSenha.TabIndex = 5;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(146, 4);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.MaxLength = 255;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(293, 27);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // mskCpf
            // 
            mskCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mskCpf.Location = new Point(146, 74);
            mskCpf.Margin = new Padding(3, 4, 3, 4);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.ReadOnly = true;
            mskCpf.Size = new Size(293, 27);
            mskCpf.SkipLiterals = false;
            mskCpf.TabIndex = 8;
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(146, 39);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 27);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNascimento
            // 
            txtNascimento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNascimento.Location = new Point(146, 111);
            txtNascimento.Margin = new Padding(3, 4, 3, 4);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.ReadOnly = true;
            txtNascimento.Size = new Size(293, 27);
            txtNascimento.TabIndex = 14;
            // 
            // cmbPlano
            // 
            cmbPlano.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbPlano.Enabled = false;
            cmbPlano.FormattingEnabled = true;
            cmbPlano.Location = new Point(146, 218);
            cmbPlano.Name = "cmbPlano";
            cmbPlano.Size = new Size(293, 28);
            cmbPlano.TabIndex = 15;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Enabled = false;
            chkAdmin.Location = new Point(146, 253);
            chkAdmin.Margin = new Padding(3, 4, 3, 4);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(126, 24);
            chkAdmin.TabIndex = 12;
            chkAdmin.Text = "Administrador";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.Location = new Point(359, 285);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 31);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblPlano
            // 
            lblPlano.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPlano.AutoSize = true;
            lblPlano.Location = new Point(3, 215);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(137, 34);
            lblPlano.TabIndex = 16;
            lblPlano.Text = "Plano:";
            lblPlano.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 359);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPerfil";
            Text = "Perfil do Usuário";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNome;
        private Button btnSalvar;
        private CheckBox chkAdmin;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblDataNascimento;
        private TextBox txtConfirmarSenha;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private TextBox txtNome;
        private MaskedTextBox mskCpf;
        private TextBox txtEmail;
        private TextBox txtNascimento;
        private ComboBox cmbPlano;
        private Label lblPlano;
    }
}