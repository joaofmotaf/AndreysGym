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
            this.components = new System.ComponentModel.Container();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnProgramacoes = new System.Windows.Forms.Button();
            this.btnFrequencias = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnAvaliacoes = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.tlpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(AndreysGym.Entidades.Usuario);
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.AutoSize = true;
            this.tlpUsuarios.ColumnCount = 2;
            this.tlpPrincipal.SetColumnSpan(this.tlpUsuarios, 6);
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUsuarios.Controls.Add(this.dgvUsuarios, 1, 1);
            this.tlpUsuarios.Controls.Add(this.txtPesquisa, 0, 0);
            this.tlpUsuarios.Controls.Add(this.btnPesquisar, 1, 0);
            this.tlpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarios.Location = new System.Drawing.Point(15, 15);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 2;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsuarios.Size = new System.Drawing.Size(357, 252);
            this.tlpUsuarios.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.Credencial});
            this.tlpUsuarios.SetColumnSpan(this.dgvUsuarios, 2);
            this.dgvUsuarios.DataSource = this.usuarioBindingSource;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 32);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(351, 217);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 5F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 45F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.FillWeight = 15F;
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.FillWeight = 15F;
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // Credencial
            // 
            this.Credencial.DataPropertyName = "Credencial";
            this.Credencial.HeaderText = "Credencial";
            this.Credencial.Name = "Credencial";
            this.Credencial.ReadOnly = true;
            this.Credencial.Visible = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PlaceholderText = "Insira o nome do usuário...";
            this.txtPesquisa.Size = new System.Drawing.Size(279, 23);
            this.txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(288, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(66, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 6;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpPrincipal.Controls.Add(this.tlpUsuarios, 0, 0);
            this.tlpPrincipal.Controls.Add(this.btnProgramacoes, 0, 1);
            this.tlpPrincipal.Controls.Add(this.btnFrequencias, 1, 1);
            this.tlpPrincipal.Controls.Add(this.btnPagamentos, 2, 1);
            this.tlpPrincipal.Controls.Add(this.btnAvaliacoes, 3, 1);
            this.tlpPrincipal.Controls.Add(this.btnEditar, 4, 1);
            this.tlpPrincipal.Controls.Add(this.btnExcluir, 5, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(12);
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(387, 311);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // btnProgramacoes
            // 
            this.btnProgramacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProgramacoes.Location = new System.Drawing.Point(15, 273);
            this.btnProgramacoes.Name = "btnProgramacoes";
            this.btnProgramacoes.Size = new System.Drawing.Size(54, 23);
            this.btnProgramacoes.TabIndex = 0;
            this.btnProgramacoes.Text = "Programações";
            this.btnProgramacoes.UseVisualStyleBackColor = true;
            this.btnProgramacoes.Click += new System.EventHandler(this.btnProgramacoes_Click);
            // 
            // btnFrequencias
            // 
            this.btnFrequencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFrequencias.Location = new System.Drawing.Point(75, 273);
            this.btnFrequencias.Name = "btnFrequencias";
            this.btnFrequencias.Size = new System.Drawing.Size(54, 23);
            this.btnFrequencias.TabIndex = 1;
            this.btnFrequencias.Text = "Frequências";
            this.btnFrequencias.UseVisualStyleBackColor = true;
            this.btnFrequencias.Click += new System.EventHandler(this.btnFrequencias_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagamentos.Location = new System.Drawing.Point(135, 273);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(54, 23);
            this.btnPagamentos.TabIndex = 2;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // btnAvaliacoes
            // 
            this.btnAvaliacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAvaliacoes.Location = new System.Drawing.Point(195, 273);
            this.btnAvaliacoes.Name = "btnAvaliacoes";
            this.btnAvaliacoes.Size = new System.Drawing.Size(54, 23);
            this.btnAvaliacoes.TabIndex = 3;
            this.btnAvaliacoes.Text = "Avaliações";
            this.btnAvaliacoes.UseVisualStyleBackColor = true;
            this.btnAvaliacoes.Click += new System.EventHandler(this.btnAvaliacoes_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Location = new System.Drawing.Point(255, 273);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Location = new System.Drawing.Point(315, 273);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(57, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmGerenciamentoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 311);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "FrmGerenciamentoUsuario";
            this.Text = "FrmGerenciamentoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

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