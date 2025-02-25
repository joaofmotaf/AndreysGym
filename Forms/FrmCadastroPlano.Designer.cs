namespace AndreysGym.Forms
{
    partial class FrmCadastroPlano
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
            pnlCadastroPlano = new Panel();
            lblPeriodicidade = new Label();
            cmbPeriodicidade = new ComboBox();
            lblAviso = new Label();
            lblPreco = new Label();
            lblTotalDias = new Label();
            lblNomePlano = new Label();
            nudValor = new NumericUpDown();
            nudTotalDias = new NumericUpDown();
            txtNomePlano = new TextBox();
            btnCadastrarPlano = new Button();
            pnlCadastroPlano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalDias).BeginInit();
            SuspendLayout();
            // 
            // pnlCadastroPlano
            // 
            pnlCadastroPlano.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroPlano.Controls.Add(lblPeriodicidade);
            pnlCadastroPlano.Controls.Add(cmbPeriodicidade);
            pnlCadastroPlano.Controls.Add(lblAviso);
            pnlCadastroPlano.Controls.Add(lblPreco);
            pnlCadastroPlano.Controls.Add(lblTotalDias);
            pnlCadastroPlano.Controls.Add(lblNomePlano);
            pnlCadastroPlano.Controls.Add(nudValor);
            pnlCadastroPlano.Controls.Add(nudTotalDias);
            pnlCadastroPlano.Controls.Add(txtNomePlano);
            pnlCadastroPlano.Controls.Add(btnCadastrarPlano);
            pnlCadastroPlano.Location = new Point(21, 24);
            pnlCadastroPlano.Margin = new Padding(3, 4, 3, 4);
            pnlCadastroPlano.Name = "pnlCadastroPlano";
            pnlCadastroPlano.Size = new Size(880, 563);
            pnlCadastroPlano.TabIndex = 0;
            // 
            // lblPeriodicidade
            // 
            lblPeriodicidade.AutoSize = true;
            lblPeriodicidade.Location = new Point(27, 128);
            lblPeriodicidade.Name = "lblPeriodicidade";
            lblPeriodicidade.Size = new Size(103, 20);
            lblPeriodicidade.TabIndex = 10;
            lblPeriodicidade.Text = "Periodicidade:";
            // 
            // cmbPeriodicidade
            // 
            cmbPeriodicidade.FormattingEnabled = true;
            cmbPeriodicidade.Location = new Point(135, 125);
            cmbPeriodicidade.Name = "cmbPeriodicidade";
            cmbPeriodicidade.Size = new Size(347, 28);
            cmbPeriodicidade.TabIndex = 9;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(135, 164);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(45, 20);
            lblAviso.TabIndex = 8;
            lblAviso.Text = "Aviso";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.Location = new Point(80, 91);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(49, 20);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preco:";
            // 
            // lblTotalDias
            // 
            lblTotalDias.AutoSize = true;
            lblTotalDias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDias.Location = new Point(13, 58);
            lblTotalDias.Name = "lblTotalDias";
            lblTotalDias.Size = new Size(117, 20);
            lblTotalDias.TabIndex = 6;
            lblTotalDias.Text = "Dias p/ Semana:";
            // 
            // lblNomePlano
            // 
            lblNomePlano.AutoSize = true;
            lblNomePlano.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomePlano.Location = new Point(13, 21);
            lblNomePlano.Name = "lblNomePlano";
            lblNomePlano.Size = new Size(116, 20);
            lblNomePlano.TabIndex = 5;
            lblNomePlano.Text = "Nome do Plano:";
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(135, 91);
            nudValor.Margin = new Padding(3, 4, 3, 4);
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(347, 27);
            nudValor.TabIndex = 4;
            // 
            // nudTotalDias
            // 
            nudTotalDias.Location = new Point(135, 56);
            nudTotalDias.Margin = new Padding(3, 4, 3, 4);
            nudTotalDias.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nudTotalDias.Name = "nudTotalDias";
            nudTotalDias.Size = new Size(347, 27);
            nudTotalDias.TabIndex = 3;
            // 
            // txtNomePlano
            // 
            txtNomePlano.Location = new Point(135, 21);
            txtNomePlano.Margin = new Padding(3, 4, 3, 4);
            txtNomePlano.Name = "txtNomePlano";
            txtNomePlano.Size = new Size(347, 27);
            txtNomePlano.TabIndex = 2;
            // 
            // btnCadastrarPlano
            // 
            btnCadastrarPlano.Location = new Point(388, 160);
            btnCadastrarPlano.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarPlano.Name = "btnCadastrarPlano";
            btnCadastrarPlano.Size = new Size(94, 29);
            btnCadastrarPlano.TabIndex = 0;
            btnCadastrarPlano.Text = "Cadastrar";
            btnCadastrarPlano.UseVisualStyleBackColor = true;
            btnCadastrarPlano.Click += btnCadastrarPlano_Click;
            // 
            // FrmCadastroPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlCadastroPlano);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCadastroPlano";
            Text = "Cadastrar Planos";
            pnlCadastroPlano.ResumeLayout(false);
            pnlCadastroPlano.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalDias).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel pnlCadastroPlano;
        private Button btnCadastrarPlano;
        private NumericUpDown nudValor;
        private NumericUpDown nudTotalDias;
        private TextBox txtNomePlano;
        private Label lblPreco;
        private Label lblTotalDias;
        private Label lblNomePlano;
        private Label lblAviso;
        private Label lblPeriodicidade;
        private ComboBox cmbPeriodicidade;
    }
}