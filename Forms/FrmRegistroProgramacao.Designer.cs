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
            pnlRegistroProgramacao = new Panel();
            lblTreino = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnExcluirExercicio = new Button();
            btnAdicionarExercicio = new Button();
            lblRepeticoes = new Label();
            lblSeries = new Label();
            lblNomeExercicio = new Label();
            numRepeticoes = new NumericUpDown();
            numSeries = new NumericUpDown();
            txtNomeExercicio = new TextBox();
            btnExcluirTreino = new Button();
            btnAdicionarTreino = new Button();
            lstExercicios = new ListView();
            Nome = new ColumnHeader();
            qtdSeries = new ColumnHeader();
            qtdRepeticoes = new ColumnHeader();
            treTreinos = new TreeView();
            label1 = new Label();
            pnlRegistroProgramacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRepeticoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeries).BeginInit();
            SuspendLayout();
            // 
            // pnlRegistroProgramacao
            // 
            pnlRegistroProgramacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRegistroProgramacao.Controls.Add(label1);
            pnlRegistroProgramacao.Controls.Add(lblTreino);
            pnlRegistroProgramacao.Controls.Add(btnCancelar);
            pnlRegistroProgramacao.Controls.Add(btnSalvar);
            pnlRegistroProgramacao.Controls.Add(btnExcluirExercicio);
            pnlRegistroProgramacao.Controls.Add(btnAdicionarExercicio);
            pnlRegistroProgramacao.Controls.Add(lblRepeticoes);
            pnlRegistroProgramacao.Controls.Add(lblSeries);
            pnlRegistroProgramacao.Controls.Add(lblNomeExercicio);
            pnlRegistroProgramacao.Controls.Add(numRepeticoes);
            pnlRegistroProgramacao.Controls.Add(numSeries);
            pnlRegistroProgramacao.Controls.Add(txtNomeExercicio);
            pnlRegistroProgramacao.Controls.Add(btnExcluirTreino);
            pnlRegistroProgramacao.Controls.Add(btnAdicionarTreino);
            pnlRegistroProgramacao.Controls.Add(lstExercicios);
            pnlRegistroProgramacao.Controls.Add(treTreinos);
            pnlRegistroProgramacao.Location = new Point(12, 12);
            pnlRegistroProgramacao.Name = "pnlRegistroProgramacao";
            pnlRegistroProgramacao.Size = new Size(716, 426);
            pnlRegistroProgramacao.TabIndex = 0;
            // 
            // lblTreino
            // 
            lblTreino.AutoSize = true;
            lblTreino.Location = new Point(215, 8);
            lblTreino.Name = "lblTreino";
            lblTreino.Size = new Size(154, 15);
            lblTreino.TabIndex = 14;
            lblTreino.Text = "Nenhum treino selecionado";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(638, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(557, 400);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluirExercicio
            // 
            btnExcluirExercicio.Location = new Point(638, 309);
            btnExcluirExercicio.Name = "btnExcluirExercicio";
            btnExcluirExercicio.Size = new Size(75, 23);
            btnExcluirExercicio.TabIndex = 11;
            btnExcluirExercicio.Text = "Excluir";
            btnExcluirExercicio.UseVisualStyleBackColor = true;
            btnExcluirExercicio.Click += btnExcluirExercicio_Click;
            // 
            // btnAdicionarExercicio
            // 
            btnAdicionarExercicio.Location = new Point(557, 311);
            btnAdicionarExercicio.Name = "btnAdicionarExercicio";
            btnAdicionarExercicio.Size = new Size(75, 23);
            btnAdicionarExercicio.TabIndex = 10;
            btnAdicionarExercicio.Text = "Adiconar";
            btnAdicionarExercicio.UseVisualStyleBackColor = true;
            btnAdicionarExercicio.Click += btnAdicionarExercicio_Click;
            // 
            // lblRepeticoes
            // 
            lblRepeticoes.AutoSize = true;
            lblRepeticoes.Location = new Point(464, 293);
            lblRepeticoes.Name = "lblRepeticoes";
            lblRepeticoes.Size = new Size(64, 15);
            lblRepeticoes.TabIndex = 9;
            lblRepeticoes.Text = "Repetições";
            // 
            // lblSeries
            // 
            lblSeries.AutoSize = true;
            lblSeries.Location = new Point(374, 293);
            lblSeries.Name = "lblSeries";
            lblSeries.Size = new Size(37, 15);
            lblSeries.TabIndex = 8;
            lblSeries.Text = "Séries";
            // 
            // lblNomeExercicio
            // 
            lblNomeExercicio.AutoSize = true;
            lblNomeExercicio.Location = new Point(215, 293);
            lblNomeExercicio.Name = "lblNomeExercicio";
            lblNomeExercicio.Size = new Size(106, 15);
            lblNomeExercicio.TabIndex = 7;
            lblNomeExercicio.Text = "Nome do exercício";
            // 
            // numRepeticoes
            // 
            numRepeticoes.Location = new Point(464, 311);
            numRepeticoes.Name = "numRepeticoes";
            numRepeticoes.Size = new Size(89, 23);
            numRepeticoes.TabIndex = 6;
            // 
            // numSeries
            // 
            numSeries.Location = new Point(374, 311);
            numSeries.Name = "numSeries";
            numSeries.Size = new Size(84, 23);
            numSeries.TabIndex = 5;
            // 
            // txtNomeExercicio
            // 
            txtNomeExercicio.Location = new Point(215, 311);
            txtNomeExercicio.Name = "txtNomeExercicio";
            txtNomeExercicio.PlaceholderText = "Nome do exercício";
            txtNomeExercicio.Size = new Size(153, 23);
            txtNomeExercicio.TabIndex = 4;
            // 
            // btnExcluirTreino
            // 
            btnExcluirTreino.Location = new Point(113, 400);
            btnExcluirTreino.Name = "btnExcluirTreino";
            btnExcluirTreino.Size = new Size(96, 23);
            btnExcluirTreino.TabIndex = 3;
            btnExcluirTreino.Text = "Excluir Treino";
            btnExcluirTreino.UseVisualStyleBackColor = true;
            btnExcluirTreino.Click += btnExcluirTreino_Click;
            // 
            // btnAdicionarTreino
            // 
            btnAdicionarTreino.Location = new Point(3, 400);
            btnAdicionarTreino.Name = "btnAdicionarTreino";
            btnAdicionarTreino.Size = new Size(104, 23);
            btnAdicionarTreino.TabIndex = 2;
            btnAdicionarTreino.Text = "Adicionar Treino";
            btnAdicionarTreino.UseVisualStyleBackColor = true;
            btnAdicionarTreino.Click += btnAdicionarTreino_Click;
            // 
            // lstExercicios
            // 
            lstExercicios.Columns.AddRange(new ColumnHeader[] { Nome, qtdSeries, qtdRepeticoes });
            lstExercicios.FullRowSelect = true;
            lstExercicios.GridLines = true;
            lstExercicios.Location = new Point(215, 26);
            lstExercicios.MultiSelect = false;
            lstExercicios.Name = "lstExercicios";
            lstExercicios.Size = new Size(498, 264);
            lstExercicios.TabIndex = 1;
            lstExercicios.UseCompatibleStateImageBehavior = false;
            lstExercicios.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 200;
            // 
            // qtdSeries
            // 
            qtdSeries.Text = "Séries";
            qtdSeries.Width = 90;
            // 
            // qtdRepeticoes
            // 
            qtdRepeticoes.Text = "Repetições";
            qtdRepeticoes.Width = 90;
            // 
            // treTreinos
            // 
            treTreinos.Location = new Point(3, 3);
            treTreinos.Name = "treTreinos";
            treTreinos.Size = new Size(206, 391);
            treTreinos.TabIndex = 0;
            treTreinos.AfterSelect += treTreinos_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 352);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // FrmRegistroProgramacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(pnlRegistroProgramacao);
            Name = "FrmRegistroProgramacao";
            Text = "Nova Programação";
            pnlRegistroProgramacao.ResumeLayout(false);
            pnlRegistroProgramacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRepeticoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeries).EndInit();
            ResumeLayout(false);
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
        private Label label1;
    }
}