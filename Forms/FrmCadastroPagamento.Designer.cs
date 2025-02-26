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
            txtPreco = new TextBox();
            lblPreco = new Label();
            lblPeriodicidade = new Label();
            txtPeriodicidade = new TextBox();
            txtPlano = new TextBox();
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
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(lblPeriodicidade);
            panel1.Controls.Add(txtPeriodicidade);
            panel1.Controls.Add(txtPlano);
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
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 568);
            panel1.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Enabled = false;
            txtPreco.Location = new Point(152, 226);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(291, 27);
            txtPreco.TabIndex = 14;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(93, 226);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(49, 20);
            lblPreco.TabIndex = 13;
            lblPreco.Text = "Preço:";
            // 
            // lblPeriodicidade
            // 
            lblPeriodicidade.AutoSize = true;
            lblPeriodicidade.Location = new Point(46, 196);
            lblPeriodicidade.Name = "lblPeriodicidade";
            lblPeriodicidade.Size = new Size(100, 20);
            lblPeriodicidade.TabIndex = 12;
            lblPeriodicidade.Text = "Periodicidade";
            // 
            // txtPeriodicidade
            // 
            txtPeriodicidade.Enabled = false;
            txtPeriodicidade.Location = new Point(152, 193);
            txtPeriodicidade.Name = "txtPeriodicidade";
            txtPeriodicidade.Size = new Size(291, 27);
            txtPeriodicidade.TabIndex = 11;
            // 
            // txtPlano
            // 
            txtPlano.Enabled = false;
            txtPlano.Location = new Point(152, 160);
            txtPlano.Name = "txtPlano";
            txtPlano.Size = new Size(291, 27);
            txtPlano.TabIndex = 10;
            // 
            // lblPlano
            // 
            lblPlano.AutoSize = true;
            lblPlano.Location = new Point(93, 167);
            lblPlano.Name = "lblPlano";
            lblPlano.Size = new Size(49, 20);
            lblPlano.TabIndex = 9;
            lblPlano.Text = "Plano:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(357, 260);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 31);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Enabled = false;
            txtCpf.Location = new Point(152, 122);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(291, 27);
            txtCpf.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(152, 84);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 27);
            txtEmail.TabIndex = 6;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(93, 125);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 20);
            lblCpf.TabIndex = 5;
            lblCpf.Text = "CPF:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(93, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(152, 49);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(291, 27);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(93, 52);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(93, 263);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 20);
            lblData.TabIndex = 1;
            lblData.Text = "Data:";
            // 
            // mtbPagamento
            // 
            mtbPagamento.Enabled = false;
            mtbPagamento.Location = new Point(152, 260);
            mtbPagamento.Margin = new Padding(3, 4, 3, 4);
            mtbPagamento.Mask = "00/00/0000 90:00:00";
            mtbPagamento.Name = "mtbPagamento";
            mtbPagamento.Size = new Size(132, 27);
            mtbPagamento.TabIndex = 0;
            mtbPagamento.ValidatingType = typeof(DateTime);
            // 
            // FrmCadastroPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtPlano;
        private Label lblPreco;
        private Label lblPeriodicidade;
        private TextBox txtPeriodicidade;
        private TextBox txtPreco;
    }
}