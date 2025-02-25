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
            btnDesativar = new Button();
            lstPlanos = new ListBox();
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
            pnlCadastroPlano.Controls.Add(btnDesativar);
            pnlCadastroPlano.Controls.Add(lstPlanos);
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
            pnlCadastroPlano.Location = new Point(18, 18);
            pnlCadastroPlano.Name = "pnlCadastroPlano";
            pnlCadastroPlano.Size = new Size(770, 422);
            pnlCadastroPlano.TabIndex = 0;
            // 
            // btnDesativar
            // 
            btnDesativar.Location = new Point(530, 283);
            btnDesativar.Name = "btnDesativar";
            btnDesativar.Size = new Size(103, 23);
            btnDesativar.TabIndex = 12;
            btnDesativar.Text = "Desativar";
            btnDesativar.UseVisualStyleBackColor = true;
            btnDesativar.Click += btnExcluir_Click;
            // 
            // lstPlanos
            // 
            lstPlanos.FormattingEnabled = true;
            lstPlanos.ItemHeight = 15;
            lstPlanos.Location = new Point(118, 3);
            lstPlanos.Name = "lstPlanos";
            lstPlanos.Size = new Size(515, 274);
            lstPlanos.TabIndex = 11;
            lstPlanos.SelectedIndexChanged += lstPlanos_SelectedIndexChanged;
            // 
            // lblPeriodicidade
            // 
            lblPeriodicidade.AutoSize = true;
            lblPeriodicidade.Location = new Point(132, 364);
            lblPeriodicidade.Name = "lblPeriodicidade";
            lblPeriodicidade.Size = new Size(82, 15);
            lblPeriodicidade.TabIndex = 10;
            lblPeriodicidade.Text = "Periodicidade:";
            // 
            // cmbPeriodicidade
            // 
            cmbPeriodicidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodicidade.FormattingEnabled = true;
            cmbPeriodicidade.Location = new Point(220, 361);
            cmbPeriodicidade.Margin = new Padding(3, 2, 3, 2);
            cmbPeriodicidade.Name = "cmbPeriodicidade";
            cmbPeriodicidade.Size = new Size(304, 23);
            cmbPeriodicidade.TabIndex = 9;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(220, 390);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(0, 15);
            lblAviso.TabIndex = 8;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.Location = new Point(174, 337);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preco:";
            // 
            // lblTotalDias
            // 
            lblTotalDias.AutoSize = true;
            lblTotalDias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDias.Location = new Point(122, 311);
            lblTotalDias.Name = "lblTotalDias";
            lblTotalDias.Size = new Size(92, 15);
            lblTotalDias.TabIndex = 6;
            lblTotalDias.Text = "Dias p/ Semana:";
            // 
            // lblNomePlano
            // 
            lblNomePlano.AutoSize = true;
            lblNomePlano.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomePlano.Location = new Point(121, 287);
            lblNomePlano.Name = "lblNomePlano";
            lblNomePlano.Size = new Size(93, 15);
            lblNomePlano.TabIndex = 5;
            lblNomePlano.Text = "Nome do Plano:";
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(220, 335);
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(304, 23);
            nudValor.TabIndex = 4;
            // 
            // nudTotalDias
            // 
            nudTotalDias.Location = new Point(220, 309);
            nudTotalDias.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nudTotalDias.Name = "nudTotalDias";
            nudTotalDias.Size = new Size(304, 23);
            nudTotalDias.TabIndex = 3;
            // 
            // txtNomePlano
            // 
            txtNomePlano.Location = new Point(220, 283);
            txtNomePlano.Name = "txtNomePlano";
            txtNomePlano.Size = new Size(304, 23);
            txtNomePlano.TabIndex = 2;
            // 
            // btnCadastrarPlano
            // 
            btnCadastrarPlano.Location = new Point(442, 387);
            btnCadastrarPlano.Name = "btnCadastrarPlano";
            btnCadastrarPlano.Size = new Size(82, 22);
            btnCadastrarPlano.TabIndex = 0;
            btnCadastrarPlano.Text = "Cadastrar";
            btnCadastrarPlano.UseVisualStyleBackColor = true;
            btnCadastrarPlano.Click += btnCadastrarPlano_Click;
            // 
            // FrmCadastroPlano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCadastroPlano);
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
        private ListBox lstPlanos;
        private Button btnDesativar;
    }
}