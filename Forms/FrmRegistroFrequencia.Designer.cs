namespace AndreysGym.Forms
{
    partial class FrmRegistroFrequencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSucesso = new Label();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblSucesso);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 86);
            panel1.TabIndex = 0;
            // 
            // lblSucesso
            // 
            lblSucesso.AutoSize = true;
            lblSucesso.ForeColor = Color.Green;
            lblSucesso.Location = new Point(3, 65);
            lblSucesso.Name = "lblSucesso";
            lblSucesso.Size = new Size(99, 15);
            lblSucesso.TabIndex = 5;
            lblSucesso.Text = "Acesso permitido";
            lblSucesso.Visible = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(249, 61);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(51, 32);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(273, 23);
            txtSenha.TabIndex = 3;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(3, 35);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 6);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // FrmRegistroFrequencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 110);
            Controls.Add(panel1);
            Name = "FrmRegistroFrequencia";
            Text = "Registro de Frequência";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label lblSenha;
        private Label lblEmail;
        private Label lblSucesso;
    }
}
