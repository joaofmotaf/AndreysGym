namespace AndreysGym.Forms
{
    partial class FrmCadastro
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
            tlpCadastro = new TableLayoutPanel();
            lblNome = new Label();
            btnCadastrar = new Button();
            chkAdmin = new CheckBox();
            lblEmail = new Label();
            lblCpf = new Label();
            lblDataNascimento = new Label();
            txtConfirmarSenha = new TextBox();
            datNascimento = new DateTimePicker();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            txtNome = new TextBox();
            mskCpf = new MaskedTextBox();
            txtEmail = new TextBox();
            lblAviso = new Label();
            cmbPlano = new ComboBox();
            lblPlano = new Label();
            tlpCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCadastro
            // 
            tlpCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCadastro.ColumnCount = 2;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCadastro.Controls.Add(lblNome, 0, 0);
            tlpCadastro.Controls.Add(chkAdmin, 1, 6);
            tlpCadastro.Controls.Add(lblEmail, 0, 1);
            tlpCadastro.Controls.Add(lblCpf, 0, 2);
            tlpCadastro.Controls.Add(lblDataNascimento, 0, 3);
            tlpCadastro.Controls.Add(txtConfirmarSenha, 1, 5);
            tlpCadastro.Controls.Add(datNascimento, 1, 3);
            tlpCadastro.Controls.Add(txtSenha, 1, 4);
            tlpCadastro.Controls.Add(lblSenha, 0, 4);
            tlpCadastro.Controls.Add(lblConfirmarSenha, 0, 5);
            tlpCadastro.Controls.Add(txtNome, 1, 0);
            tlpCadastro.Controls.Add(mskCpf, 1, 2);
            tlpCadastro.Controls.Add(txtEmail, 1, 1);
            tlpCadastro.Controls.Add(btnCadastrar, 1, 8);
            tlpCadastro.Controls.Add(cmbPlano, 1, 7);
            tlpCadastro.Controls.Add(lblAviso, 0, 8);
            tlpCadastro.Controls.Add(lblPlano, 0, 7);
            tlpCadastro.Location = new Point(12, 12);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.RowCount = 9;
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle());
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCadastro.Size = new Size(393, 314);
            tlpCadastro.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(79, 7);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrar.Enabled = false;
            btnCadastrar.Location = new Point(320, 231);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(70, 23);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new Point(128, 177);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(102, 19);
            chkAdmin.TabIndex = 12;
            chkAdmin.Text = "Administrador";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(83, 36);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(91, 65);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.Right;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(5, 94);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(117, 15);
            lblDataNascimento.TabIndex = 3;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmarSenha.Location = new Point(128, 148);
            txtConfirmarSenha.MaxLength = 64;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(262, 23);
            txtConfirmarSenha.TabIndex = 11;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // datNascimento
            // 
            datNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datNascimento.CustomFormat = "dd/MM/yyyy";
            datNascimento.Format = DateTimePickerFormat.Short;
            datNascimento.Location = new Point(128, 90);
            datNascimento.MaxDate = new DateTime(2025, 2, 23, 0, 0, 0, 0);
            datNascimento.Name = "datNascimento";
            datNascimento.Size = new Size(262, 23);
            datNascimento.TabIndex = 9;
            datNascimento.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(128, 119);
            txtSenha.MaxLength = 64;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(262, 23);
            txtSenha.TabIndex = 10;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(80, 123);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(23, 152);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(99, 15);
            lblConfirmarSenha.TabIndex = 5;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(128, 3);
            txtNome.MaxLength = 255;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(262, 23);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // mskCpf
            // 
            mskCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mskCpf.Location = new Point(128, 61);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(262, 23);
            mskCpf.SkipLiterals = false;
            mskCpf.TabIndex = 8;
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCpf.TextChanged += mskCpf_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(128, 32);
            txtEmail.MaxLength = 255;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblAviso
            // 
            lblAviso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = Color.Green;
            lblAviso.Location = new Point(15, 228);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(107, 30);
            lblAviso.TabIndex = 14;
            lblAviso.Text = "Cadastro efetuado com sucesso";
            lblAviso.Visible = false;
            // 
            // cmbPlano
            // 
            cmbPlano.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlano.FormattingEnabled = true;
            cmbPlano.Location = new Point(128, 202);
            cmbPlano.Name = "cmbPlano";
            cmbPlano.Size = new Size(262, 23);
            cmbPlano.TabIndex = 15;
            // 
            // lblPlano
            // 
            lblPlano.Anchor = AnchorStyles.Right;
            lblPlano.AutoSize = true;
            lblPlano.Location = new Point(82, 206);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(40, 15);
            lblPlano.TabIndex = 16;
            lblPlano.Text = "Plano:";
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 338);
            Controls.Add(tlpCadastro);
            Name = "FrmCadastro";
            Text = "Cadastrar Usuário";
            tlpCadastro.ResumeLayout(false);
            tlpCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCadastro;
        private Label lblNome;
        private Button btnCadastrar;
        private CheckBox chkAdmin;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblDataNascimento;
        private TextBox txtConfirmarSenha;
        private DateTimePicker datNascimento;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private TextBox txtNome;
        private MaskedTextBox mskCpf;
        private TextBox txtEmail;
        private Label lblAviso;
        private ComboBox cmbPlano;
        private Label lblPlano;
    }
}