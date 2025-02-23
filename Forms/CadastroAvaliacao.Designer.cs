namespace AndreysGym.Forms
{
    partial class CadastroAvaliacao
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
            pnlCadAvaliacao = new Panel();
            btnSalvar = new Button();
            nudAltura = new NumericUpDown();
            nudPeso = new NumericUpDown();
            nudMassaGorda = new NumericUpDown();
            nudMassaMagra = new NumericUpDown();
            nudIdade = new NumericUpDown();
            txtHistorico = new TextBox();
            txtProblemasSaude = new TextBox();
            txtMedicamentos = new TextBox();
            txtObjetivo = new TextBox();
            chkSedentismo = new CheckBox();
            lblAltura = new Label();
            lblPeso = new Label();
            lblMassaGorda = new Label();
            lblMassaMagra = new Label();
            lblHistorico = new Label();
            lblProblemasSaude = new Label();
            lblMedicamentos = new Label();
            lblObjetivo = new Label();
            lblIdade = new Label();
            pnlCadAvaliacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMassaGorda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMassaMagra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdade).BeginInit();
            SuspendLayout();
            // 
            // pnlCadAvaliacao
            // 
            pnlCadAvaliacao.Controls.Add(btnSalvar);
            pnlCadAvaliacao.Controls.Add(nudAltura);
            pnlCadAvaliacao.Controls.Add(nudPeso);
            pnlCadAvaliacao.Controls.Add(nudMassaGorda);
            pnlCadAvaliacao.Controls.Add(nudMassaMagra);
            pnlCadAvaliacao.Controls.Add(nudIdade);
            pnlCadAvaliacao.Controls.Add(txtHistorico);
            pnlCadAvaliacao.Controls.Add(txtProblemasSaude);
            pnlCadAvaliacao.Controls.Add(txtMedicamentos);
            pnlCadAvaliacao.Controls.Add(txtObjetivo);
            pnlCadAvaliacao.Controls.Add(chkSedentismo);
            pnlCadAvaliacao.Controls.Add(lblAltura);
            pnlCadAvaliacao.Controls.Add(lblPeso);
            pnlCadAvaliacao.Controls.Add(lblMassaGorda);
            pnlCadAvaliacao.Controls.Add(lblMassaMagra);
            pnlCadAvaliacao.Controls.Add(lblHistorico);
            pnlCadAvaliacao.Controls.Add(lblProblemasSaude);
            pnlCadAvaliacao.Controls.Add(lblMedicamentos);
            pnlCadAvaliacao.Controls.Add(lblObjetivo);
            pnlCadAvaliacao.Controls.Add(lblIdade);
            pnlCadAvaliacao.Location = new Point(6, 3);
            pnlCadAvaliacao.Name = "pnlCadAvaliacao";
            pnlCadAvaliacao.Size = new Size(772, 481);
            pnlCadAvaliacao.TabIndex = 0;
            pnlCadAvaliacao.Paint += pnlCadAvaliacao_Paint;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(309, 409);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(158, 42);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // nudAltura
            // 
            nudAltura.DecimalPlaces = 2;
            nudAltura.Location = new Point(190, 354);
            nudAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudAltura.Name = "nudAltura";
            nudAltura.Size = new Size(112, 27);
            nudAltura.TabIndex = 23;
            // 
            // nudPeso
            // 
            nudPeso.DecimalPlaces = 2;
            nudPeso.Location = new Point(190, 322);
            nudPeso.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(112, 27);
            nudPeso.TabIndex = 22;
            // 
            // nudMassaGorda
            // 
            nudMassaGorda.DecimalPlaces = 2;
            nudMassaGorda.Location = new Point(190, 287);
            nudMassaGorda.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMassaGorda.Name = "nudMassaGorda";
            nudMassaGorda.Size = new Size(112, 27);
            nudMassaGorda.TabIndex = 21;
            // 
            // nudMassaMagra
            // 
            nudMassaMagra.DecimalPlaces = 2;
            nudMassaMagra.Location = new Point(190, 254);
            nudMassaMagra.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMassaMagra.Name = "nudMassaMagra";
            nudMassaMagra.Size = new Size(112, 27);
            nudMassaMagra.TabIndex = 20;
            // 
            // nudIdade
            // 
            nudIdade.Location = new Point(190, 30);
            nudIdade.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudIdade.Name = "nudIdade";
            nudIdade.Size = new Size(112, 27);
            nudIdade.TabIndex = 19;
            // 
            // txtHistorico
            // 
            txtHistorico.Location = new Point(190, 207);
            txtHistorico.Name = "txtHistorico";
            txtHistorico.Size = new Size(277, 27);
            txtHistorico.TabIndex = 17;
            // 
            // txtProblemasSaude
            // 
            txtProblemasSaude.Location = new Point(190, 174);
            txtProblemasSaude.Name = "txtProblemasSaude";
            txtProblemasSaude.Size = new Size(277, 27);
            txtProblemasSaude.TabIndex = 16;
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.Location = new Point(190, 96);
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new Size(277, 27);
            txtMedicamentos.TabIndex = 15;
            // 
            // txtObjetivo
            // 
            txtObjetivo.Location = new Point(190, 63);
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.Size = new Size(277, 27);
            txtObjetivo.TabIndex = 14;
            // 
            // chkSedentismo
            // 
            chkSedentismo.AutoSize = true;
            chkSedentismo.Location = new Point(34, 144);
            chkSedentismo.Name = "chkSedentismo";
            chkSedentismo.Size = new Size(122, 24);
            chkSedentismo.TabIndex = 12;
            chkSedentismo.Text = "Sedentarismo";
            chkSedentismo.TextAlign = ContentAlignment.TopCenter;
            chkSedentismo.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(34, 361);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(86, 20);
            lblAltura.TabIndex = 10;
            lblAltura.Text = "Altura (cm):";
            lblAltura.Click += label11_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(34, 328);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(72, 20);
            lblPeso.TabIndex = 9;
            lblPeso.Text = "Peso (kg):";
            lblPeso.Click += label10_Click;
            // 
            // lblMassaGorda
            // 
            lblMassaGorda.AutoSize = true;
            lblMassaGorda.Location = new Point(34, 294);
            lblMassaGorda.Name = "lblMassaGorda";
            lblMassaGorda.Size = new Size(128, 20);
            lblMassaGorda.TabIndex = 8;
            lblMassaGorda.Text = "Massa Gorda (kg):";
            lblMassaGorda.Click += label9_Click;
            // 
            // lblMassaMagra
            // 
            lblMassaMagra.AutoSize = true;
            lblMassaMagra.Location = new Point(34, 261);
            lblMassaMagra.Name = "lblMassaMagra";
            lblMassaMagra.Size = new Size(130, 20);
            lblMassaMagra.TabIndex = 7;
            lblMassaMagra.Text = "Massa Magra (kg):";
            lblMassaMagra.Click += label8_Click;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Location = new Point(34, 214);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(128, 20);
            lblHistorico.TabIndex = 6;
            lblHistorico.Text = "Historico Familiar:";
            // 
            // lblProblemasSaude
            // 
            lblProblemasSaude.AutoSize = true;
            lblProblemasSaude.Location = new Point(34, 181);
            lblProblemasSaude.Name = "lblProblemasSaude";
            lblProblemasSaude.Size = new Size(150, 20);
            lblProblemasSaude.TabIndex = 5;
            lblProblemasSaude.Text = "Problemas De Saúde:";
            lblProblemasSaude.Click += label6_Click;
            // 
            // lblMedicamentos
            // 
            lblMedicamentos.AutoSize = true;
            lblMedicamentos.Location = new Point(34, 103);
            lblMedicamentos.Name = "lblMedicamentos";
            lblMedicamentos.Size = new Size(110, 20);
            lblMedicamentos.TabIndex = 4;
            lblMedicamentos.Text = "Medicamentos:";
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Location = new Point(34, 70);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(69, 20);
            lblObjetivo.TabIndex = 3;
            lblObjetivo.Text = "Objetivo:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(34, 37);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(50, 20);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade:";
            lblIdade.Click += label3_Click;
            // 
            // CadastroAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 488);
            Controls.Add(pnlCadAvaliacao);
            Name = "CadastroAvaliacao";
            Text = "CadastroAvaliacao";
            Load += CadastroAvaliacao_Load;
            pnlCadAvaliacao.ResumeLayout(false);
            pnlCadAvaliacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMassaGorda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMassaMagra).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadAvaliacao;
        private Label label11;
        private Label label10;
        private Label lblMassaGorda;
        private Label lblMassaMagra;
        private Label lblHistorico;
        private Label lblProblemasSaude;
        private Label lblMedicamentos;
        private Label lblObjetivo;
        private Label lblIdade;
        private Label lblPeso;
        private Button btnSalvar;
        private Label lblAltura;
        private CheckBox chkSedentismo;
        private TextBox txtHistorico;
        private TextBox txtProblemasSaude;
        private TextBox txtMedicamentos;
        private TextBox txtObjetivo;
        private NumericUpDown nudAltura;
        private NumericUpDown nudPeso;
        private NumericUpDown nudMassaGorda;
        private NumericUpDown nudMassaMagra;
        private NumericUpDown nudIdade;
    }
}