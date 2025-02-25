namespace AndreysGym.Forms
{
    partial class FrmRegistroProgramacao
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
            this.pnlRegistroProgramacao = new System.Windows.Forms.Panel();
            this.lblTreino = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluirExercicio = new System.Windows.Forms.Button();
            this.btnAdicionarExercicio = new System.Windows.Forms.Button();
            this.lblRepeticoes = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblNomeExercicio = new System.Windows.Forms.Label();
            this.numRepeticoes = new System.Windows.Forms.NumericUpDown();
            this.numSeries = new System.Windows.Forms.NumericUpDown();
            this.txtNomeExercicio = new System.Windows.Forms.TextBox();
            this.btnExcluirTreino = new System.Windows.Forms.Button();
            this.btnAdicionarTreino = new System.Windows.Forms.Button();
            this.lstExercicios = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.qtdSeries = new System.Windows.Forms.ColumnHeader();
            this.qtdRepeticoes = new System.Windows.Forms.ColumnHeader();
            this.treTreinos = new System.Windows.Forms.TreeView();
            this.pnlRegistroProgramacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeticoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroProgramacao
            // 
            this.pnlRegistroProgramacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistroProgramacao.Controls.Add(this.lblTreino);
            this.pnlRegistroProgramacao.Controls.Add(this.btnCancelar);
            this.pnlRegistroProgramacao.Controls.Add(this.btnSalvar);
            this.pnlRegistroProgramacao.Controls.Add(this.btnExcluirExercicio);
            this.pnlRegistroProgramacao.Controls.Add(this.btnAdicionarExercicio);
            this.pnlRegistroProgramacao.Controls.Add(this.lblRepeticoes);
            this.pnlRegistroProgramacao.Controls.Add(this.lblSeries);
            this.pnlRegistroProgramacao.Controls.Add(this.lblNomeExercicio);
            this.pnlRegistroProgramacao.Controls.Add(this.numRepeticoes);
            this.pnlRegistroProgramacao.Controls.Add(this.numSeries);
            this.pnlRegistroProgramacao.Controls.Add(this.txtNomeExercicio);
            this.pnlRegistroProgramacao.Controls.Add(this.btnExcluirTreino);
            this.pnlRegistroProgramacao.Controls.Add(this.btnAdicionarTreino);
            this.pnlRegistroProgramacao.Controls.Add(this.lstExercicios);
            this.pnlRegistroProgramacao.Controls.Add(this.treTreinos);
            this.pnlRegistroProgramacao.Location = new System.Drawing.Point(12, 12);
            this.pnlRegistroProgramacao.Name = "pnlRegistroProgramacao";
            this.pnlRegistroProgramacao.Size = new System.Drawing.Size(716, 426);
            this.pnlRegistroProgramacao.TabIndex = 0;
            // 
            // lblTreino
            // 
            this.lblTreino.AutoSize = true;
            this.lblTreino.Location = new System.Drawing.Point(215, 8);
            this.lblTreino.Name = "lblTreino";
            this.lblTreino.Size = new System.Drawing.Size(154, 15);
            this.lblTreino.TabIndex = 14;
            this.lblTreino.Text = "Nenhum treino selecionado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(638, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(557, 400);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluirExercicio
            // 
            this.btnExcluirExercicio.Location = new System.Drawing.Point(638, 309);
            this.btnExcluirExercicio.Name = "btnExcluirExercicio";
            this.btnExcluirExercicio.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirExercicio.TabIndex = 11;
            this.btnExcluirExercicio.Text = "Excluir";
            this.btnExcluirExercicio.UseVisualStyleBackColor = true;
            this.btnExcluirExercicio.Click += new System.EventHandler(this.btnExcluirExercicio_Click);
            // 
            // btnAdicionarExercicio
            // 
            this.btnAdicionarExercicio.Location = new System.Drawing.Point(557, 311);
            this.btnAdicionarExercicio.Name = "btnAdicionarExercicio";
            this.btnAdicionarExercicio.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarExercicio.TabIndex = 10;
            this.btnAdicionarExercicio.Text = "Adiconar";
            this.btnAdicionarExercicio.UseVisualStyleBackColor = true;
            this.btnAdicionarExercicio.Click += new System.EventHandler(this.btnAdicionarExercicio_Click);
            // 
            // lblRepeticoes
            // 
            this.lblRepeticoes.AutoSize = true;
            this.lblRepeticoes.Location = new System.Drawing.Point(464, 293);
            this.lblRepeticoes.Name = "lblRepeticoes";
            this.lblRepeticoes.Size = new System.Drawing.Size(64, 15);
            this.lblRepeticoes.TabIndex = 9;
            this.lblRepeticoes.Text = "Repetições";
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(374, 293);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(37, 15);
            this.lblSeries.TabIndex = 8;
            this.lblSeries.Text = "Séries";
            // 
            // lblNomeExercicio
            // 
            this.lblNomeExercicio.AutoSize = true;
            this.lblNomeExercicio.Location = new System.Drawing.Point(215, 293);
            this.lblNomeExercicio.Name = "lblNomeExercicio";
            this.lblNomeExercicio.Size = new System.Drawing.Size(107, 15);
            this.lblNomeExercicio.TabIndex = 7;
            this.lblNomeExercicio.Text = "Nome do exercício";
            // 
            // numRepeticoes
            // 
            this.numRepeticoes.Location = new System.Drawing.Point(464, 311);
            this.numRepeticoes.Name = "numRepeticoes";
            this.numRepeticoes.Size = new System.Drawing.Size(89, 23);
            this.numRepeticoes.TabIndex = 6;
            // 
            // numSeries
            // 
            this.numSeries.Location = new System.Drawing.Point(374, 311);
            this.numSeries.Name = "numSeries";
            this.numSeries.Size = new System.Drawing.Size(84, 23);
            this.numSeries.TabIndex = 5;
            // 
            // txtNomeExercicio
            // 
            this.txtNomeExercicio.Location = new System.Drawing.Point(215, 311);
            this.txtNomeExercicio.Name = "txtNomeExercicio";
            this.txtNomeExercicio.PlaceholderText = "Nome do exercício";
            this.txtNomeExercicio.Size = new System.Drawing.Size(153, 23);
            this.txtNomeExercicio.TabIndex = 4;
            // 
            // btnExcluirTreino
            // 
            this.btnExcluirTreino.Location = new System.Drawing.Point(113, 400);
            this.btnExcluirTreino.Name = "btnExcluirTreino";
            this.btnExcluirTreino.Size = new System.Drawing.Size(96, 23);
            this.btnExcluirTreino.TabIndex = 3;
            this.btnExcluirTreino.Text = "Excluir Treino";
            this.btnExcluirTreino.UseVisualStyleBackColor = true;
            this.btnExcluirTreino.Click += new System.EventHandler(this.btnExcluirTreino_Click);
            // 
            // btnAdicionarTreino
            // 
            this.btnAdicionarTreino.Location = new System.Drawing.Point(3, 400);
            this.btnAdicionarTreino.Name = "btnAdicionarTreino";
            this.btnAdicionarTreino.Size = new System.Drawing.Size(104, 23);
            this.btnAdicionarTreino.TabIndex = 2;
            this.btnAdicionarTreino.Text = "Adicionar Treino";
            this.btnAdicionarTreino.UseVisualStyleBackColor = true;
            this.btnAdicionarTreino.Click += new System.EventHandler(this.btnAdicionarTreino_Click);
            // 
            // lstExercicios
            // 
            this.lstExercicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.qtdSeries,
            this.qtdRepeticoes});
            this.lstExercicios.FullRowSelect = true;
            this.lstExercicios.GridLines = true;
            this.lstExercicios.Location = new System.Drawing.Point(215, 26);
            this.lstExercicios.MultiSelect = false;
            this.lstExercicios.Name = "lstExercicios";
            this.lstExercicios.Size = new System.Drawing.Size(498, 264);
            this.lstExercicios.TabIndex = 1;
            this.lstExercicios.UseCompatibleStateImageBehavior = false;
            this.lstExercicios.View = System.Windows.Forms.View.Details;
            this.lstExercicios.SelectedIndexChanged += new System.EventHandler(this.lstExercicios_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // qtdSeries
            // 
            this.qtdSeries.Text = "Séries";
            this.qtdSeries.Width = 90;
            // 
            // qtdRepeticoes
            // 
            this.qtdRepeticoes.Text = "Repetições";
            this.qtdRepeticoes.Width = 90;
            // 
            // treTreinos
            // 
            this.treTreinos.Location = new System.Drawing.Point(3, 3);
            this.treTreinos.Name = "treTreinos";
            this.treTreinos.Size = new System.Drawing.Size(206, 391);
            this.treTreinos.TabIndex = 0;
            this.treTreinos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treTreinos_AfterSelect);
            // 
            // FrmRegistroProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.pnlRegistroProgramacao);
            this.Name = "FrmRegistroProgramacao";
            this.Text = "Nova Programação";
            this.pnlRegistroProgramacao.ResumeLayout(false);
            this.pnlRegistroProgramacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeticoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlRegistroProgramacao;
        private TreeView treTreinos;
        private Button btnExcluirTreino;
        private Button btnAdicionarTreino;
        private ListView lstExercicios;
        private ColumnHeader Nome;
        private ColumnHeader qtdSeries;
        private ColumnHeader qtdRepeticoes;
        private TextBox txtNomeExercicio;
        private Label lblRepeticoes;
        private Label lblSeries;
        private Label lblNomeExercicio;
        private NumericUpDown numRepeticoes;
        private NumericUpDown numSeries;
        private Button btnAdicionarExercicio;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnExcluirExercicio;
        private Label lblTreino;
    }
}