namespace AndreysGym.Forms
{
    partial class FrmGerenciamentoUsuario
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
            components = new System.ComponentModel.Container();
            usuarioBindingSource = new BindingSource(components);
            tlpUsuarios = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataNascimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Credencial = new DataGridViewTextBoxColumn();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            tlpPrincipal = new TableLayoutPanel();
            btnProgramacoes = new Button();
            btnFrequencias = new Button();
            btnPagamentos = new Button();
            btnAvaliacoes = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            tlpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tlpPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Entidades.Usuario);
            // 
            // tlpUsuarios
            // 
            tlpUsuarios.AutoSize = true;
            tlpUsuarios.ColumnCount = 2;
            tlpPrincipal.SetColumnSpan(tlpUsuarios, 6);
            tlpUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpUsuarios.Controls.Add(dgvUsuarios, 1, 1);
            tlpUsuarios.Controls.Add(txtPesquisa, 0, 0);
            tlpUsuarios.Controls.Add(btnPesquisar, 1, 0);
            tlpUsuarios.Dock = DockStyle.Fill;
            tlpUsuarios.Location = new Point(15, 15);
            tlpUsuarios.Name = "tlpUsuarios";
            tlpUsuarios.RowCount = 2;
            tlpUsuarios.RowStyles.Add(new RowStyle());
            tlpUsuarios.RowStyles.Add(new RowStyle());
            tlpUsuarios.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpUsuarios.Size = new Size(357, 252);
            tlpUsuarios.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, dataNascimentoDataGridViewTextBoxColumn, cpfDataGridViewTextBoxColumn, Credencial });
            tlpUsuarios.SetColumnSpan(dgvUsuarios, 2);
            dgvUsuarios.DataSource = usuarioBindingSource;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 32);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(351, 217);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 5F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.FillWeight = 45F;
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            dataNascimentoDataGridViewTextBoxColumn.FillWeight = 15F;
            dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            cpfDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            cpfDataGridViewTextBoxColumn.FillWeight = 15F;
            cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            cpfDataGridViewTextBoxColumn.ReadOnly = true;
            cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // Credencial
            // 
            Credencial.DataPropertyName = "Credencial";
            Credencial.HeaderText = "Credencial";
            Credencial.Name = "Credencial";
            Credencial.ReadOnly = true;
            Credencial.Visible = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.Location = new Point(3, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Insira o nome do usuário...";
            txtPesquisa.Size = new Size(279, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPesquisar.Location = new Point(288, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(66, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 6;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpPrincipal.Controls.Add(tlpUsuarios, 0, 0);
            tlpPrincipal.Controls.Add(btnProgramacoes, 0, 1);
            tlpPrincipal.Controls.Add(btnFrequencias, 1, 1);
            tlpPrincipal.Controls.Add(btnPagamentos, 2, 1);
            tlpPrincipal.Controls.Add(btnAvaliacoes, 3, 1);
            tlpPrincipal.Controls.Add(btnEditar, 4, 1);
            tlpPrincipal.Controls.Add(btnExcluir, 5, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle());
            tlpPrincipal.Size = new Size(387, 311);
            tlpPrincipal.TabIndex = 1;
            // 
            // btnProgramacoes
            // 
            btnProgramacoes.Dock = DockStyle.Fill;
            btnProgramacoes.Enabled = false;
            btnProgramacoes.Location = new Point(15, 273);
            btnProgramacoes.Name = "btnProgramacoes";
            btnProgramacoes.Size = new Size(54, 23);
            btnProgramacoes.TabIndex = 0;
            btnProgramacoes.Text = "Programações";
            btnProgramacoes.UseVisualStyleBackColor = true;
            btnProgramacoes.Click += btnProgramacoes_Click;
            // 
            // btnFrequencias
            // 
            btnFrequencias.Dock = DockStyle.Fill;
            btnFrequencias.Enabled = false;
            btnFrequencias.Location = new Point(75, 273);
            btnFrequencias.Name = "btnFrequencias";
            btnFrequencias.Size = new Size(54, 23);
            btnFrequencias.TabIndex = 1;
            btnFrequencias.Text = "Frequências";
            btnFrequencias.UseVisualStyleBackColor = true;
            btnFrequencias.Click += btnFrequencias_Click;
            // 
            // btnPagamentos
            // 
            btnPagamentos.Dock = DockStyle.Fill;
            btnPagamentos.Enabled = false;
            btnPagamentos.Location = new Point(135, 273);
            btnPagamentos.Name = "btnPagamentos";
            btnPagamentos.Size = new Size(54, 23);
            btnPagamentos.TabIndex = 2;
            btnPagamentos.Text = "Pagamentos";
            btnPagamentos.UseVisualStyleBackColor = true;
            // 
            // btnAvaliacoes
            // 
            btnAvaliacoes.Dock = DockStyle.Fill;
            btnAvaliacoes.Enabled = false;
            btnAvaliacoes.Location = new Point(195, 273);
            btnAvaliacoes.Name = "btnAvaliacoes";
            btnAvaliacoes.Size = new Size(54, 23);
            btnAvaliacoes.TabIndex = 3;
            btnAvaliacoes.Text = "Avaliações";
            btnAvaliacoes.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(255, 273);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(54, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(315, 273);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(57, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmGerenciamentoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 311);
            Controls.Add(tlpPrincipal);
            Name = "FrmGerenciamentoUsuario";
            Text = "FrmGerenciamentoUsuario";
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            tlpUsuarios.ResumeLayout(false);
            tlpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource usuarioBindingSource;
        private TableLayoutPanel tlpUsuarios;
        private TextBox txtPesquisa;
        private TableLayoutPanel tlpPrincipal;
        private DataGridView dgvUsuarios;
        private Button btnPesquisar;
        private Button btnProgramacoes;
        private Button btnFrequencias;
        private Button btnPagamentos;
        private Button btnAvaliacoes;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Credencial;
    }
}