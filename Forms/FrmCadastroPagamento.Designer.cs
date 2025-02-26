namespace AndreysGym.Forms
{
    partial class FrmCadastroPagamento
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
            panel1 = new Panel();
            cmbPeriodicidade = new ComboBox();
            cmbPlano = new ComboBox();
            txtPreco = new TextBox();
            lblPreco = new Label();
            lblPeriodicidade = new Label();
            lblPlano = new Label();
            btnCadastrar = new Button();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            lblCpf = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblData = new Label();
            mtbPagamento = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbPeriodicidade);
            panel1.Controls.Add(cmbPlano);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(lblPeriodicidade);
            panel1.Controls.Add(lblPlano);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblData);
            panel1.Controls.Add(mtbPagamento);
            panel1.Enabled = false;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // cmbPeriodicidade
            // 
            cmbPeriodicidade.Enabled = false;
            cmbPeriodicidade.FormattingEnabled = true;
            cmbPeriodicidade.Location = new Point(133, 141);
            cmbPeriodicidade.Margin = new Padding(3, 2, 3, 2);
            cmbPeriodicidade.Name = "cmbPeriodicidade";
            cmbPeriodicidade.Size = new Size(255, 23);
            cmbPeriodicidade.TabIndex = 17;
            // 
            // cmbPlano
            // 
            cmbPlano.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbPlano.Enabled = false;
            cmbPlano.FormattingEnabled = true;
            cmbPlano.Location = new Point(133, 117);
            cmbPlano.Margin = new Padding(3, 2, 3, 2);
            cmbPlano.Name = "cmbPlano";
            cmbPlano.Size = new Size(255, 23);
            cmbPlano.TabIndex = 16;
            // 
            // txtPreco
            // 
            txtPreco.Enabled = false;
            txtPreco.Location = new Point(133, 166);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(255, 23);
            txtPreco.TabIndex = 14;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(81, 166);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 13;
            lblPreco.Text = "Preço:";
            // 
            // lblPeriodicidade
            // 
            lblPeriodicidade.AutoSize = true;
            lblPeriodicidade.Location = new Point(40, 143);
            lblPeriodicidade.Name = "lblPeriodicidade";
            lblPeriodicidade.Size = new Size(79, 15);
            lblPeriodicidade.TabIndex = 12;
            lblPeriodicidade.Text = "Periodicidade";
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.Location = new Point(81, 119);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(40, 15);
            lblPlano.TabIndex = 9;
            lblPlano.Text = "Plano:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(312, 192);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Enabled = false;
            txtCpf.Location = new Point(133, 92);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(255, 23);
            txtCpf.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(133, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(81, 94);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(81, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(133, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(255, 23);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(81, 39);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(81, 194);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 1;
            lblData.Text = "Data:";
            // 
            // mtbPagamento
            // 
            mtbPagamento.Enabled = false;
            mtbPagamento.Location = new Point(133, 192);
            mtbPagamento.Mask = "00/00/0000 90:00:00";
            mtbPagamento.Name = "mtbPagamento";
            mtbPagamento.Size = new Size(116, 23);
            mtbPagamento.TabIndex = 0;
            mtbPagamento.ValidatingType = typeof(DateTime);
            mtbPagamento.MaskInputRejected += mtbPagamento_MaskInputRejected;
            // 
            // FrmCadastroPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmCadastroPagamento";
            Text = "CadastroPagamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblData;
        private MaskedTextBox mtbPagamento;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnCadastrar;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblPlano;
        private Label lblPreco;
        private Label lblPeriodicidade;
        private TextBox txtPreco;
        private ComboBox cmbPlano;
        private ComboBox cmbPeriodicidade;
    }
}