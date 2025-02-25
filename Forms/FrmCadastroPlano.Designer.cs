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
            this.pnlCadastroPlano = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTotalDias = new System.Windows.Forms.Label();
            this.lblNomePlano = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.nudTotalDias = new System.Windows.Forms.NumericUpDown();
            this.txtbNomePlano = new System.Windows.Forms.TextBox();
            this.btnCadastrarPlano = new System.Windows.Forms.Button();
            this.pnlCadastroPlano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastroPlano
            // 
            this.pnlCadastroPlano.Controls.Add(this.lblValor);
            this.pnlCadastroPlano.Controls.Add(this.lblTotalDias);
            this.pnlCadastroPlano.Controls.Add(this.lblNomePlano);
            this.pnlCadastroPlano.Controls.Add(this.nudValor);
            this.pnlCadastroPlano.Controls.Add(this.nudTotalDias);
            this.pnlCadastroPlano.Controls.Add(this.txtbNomePlano);
            this.pnlCadastroPlano.Controls.Add(this.btnCadastrarPlano);
            this.pnlCadastroPlano.Location = new System.Drawing.Point(18, 18);
            this.pnlCadastroPlano.Name = "pnlCadastroPlano";
            this.pnlCadastroPlano.Size = new System.Drawing.Size(770, 430);
            this.pnlCadastroPlano.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(80, 144);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            this.lblValor.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalDias
            // 
            this.lblTotalDias.AutoSize = true;
            this.lblTotalDias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDias.Location = new System.Drawing.Point(27, 109);
            this.lblTotalDias.Name = "lblTotalDias";
            this.lblTotalDias.Size = new System.Drawing.Size(99, 20);
            this.lblTotalDias.TabIndex = 6;
            this.lblTotalDias.Text = "Total de Dias:";
            this.lblTotalDias.Click += new System.EventHandler(this.lblTotalDias_Click);
            // 
            // lblNomePlano
            // 
            this.lblNomePlano.AutoSize = true;
            this.lblNomePlano.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomePlano.Location = new System.Drawing.Point(10, 63);
            this.lblNomePlano.Name = "lblNomePlano";
            this.lblNomePlano.Size = new System.Drawing.Size(116, 20);
            this.lblNomePlano.TabIndex = 5;
            this.lblNomePlano.Text = "Nome do Plano:";
            this.lblNomePlano.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(132, 144);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(304, 23);
            this.nudValor.TabIndex = 4;
            // 
            // nudTotalDias
            // 
            this.nudTotalDias.Location = new System.Drawing.Point(132, 109);
            this.nudTotalDias.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudTotalDias.Name = "nudTotalDias";
            this.nudTotalDias.Size = new System.Drawing.Size(304, 23);
            this.nudTotalDias.TabIndex = 3;
            // 
            // txtbNomePlano
            // 
            this.txtbNomePlano.Location = new System.Drawing.Point(132, 64);
            this.txtbNomePlano.Name = "txtbNomePlano";
            this.txtbNomePlano.Size = new System.Drawing.Size(304, 23);
            this.txtbNomePlano.TabIndex = 2;
            this.txtbNomePlano.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCadastrarPlano
            // 
            this.btnCadastrarPlano.Location = new System.Drawing.Point(321, 192);
            this.btnCadastrarPlano.Name = "btnCadastrarPlano";
            this.btnCadastrarPlano.Size = new System.Drawing.Size(115, 46);
            this.btnCadastrarPlano.TabIndex = 0;
            this.btnCadastrarPlano.Text = "Cadastrar";
            this.btnCadastrarPlano.UseVisualStyleBackColor = true;
            this.btnCadastrarPlano.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCadastroPlano);
            this.Name = "FrmCadastroPlano";
            this.Text = "CadastroPlano";
            this.pnlCadastroPlano.ResumeLayout(false);
            this.pnlCadastroPlano.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCadastroPlano;
        private Button btnCadastrarPlano;
        private NumericUpDown nudValor;
        private NumericUpDown nudTotalDias;
        private TextBox txtbNomePlano;
        private Label lblValor;
        private Label lblTotalDias;
        private Label lblNomePlano;
    }
}