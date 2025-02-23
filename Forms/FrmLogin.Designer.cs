using System.Runtime.CompilerServices;

namespace AndreysGym.Forms
{
    partial class FrmLogin
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
            pnlLogin = new Panel();
            lblInvalido = new Label();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLogin.Controls.Add(lblInvalido);
            pnlLogin.Controls.Add(btnEntrar);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(txtEmail);
            pnlLogin.Controls.Add(lblSenha);
            pnlLogin.Controls.Add(lblEmail);
            pnlLogin.Location = new Point(14, 16);
            pnlLogin.Margin = new Padding(3, 4, 3, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(374, 115);
            pnlLogin.TabIndex = 0;
            // 
            // lblInvalido
            // 
            lblInvalido.AutoSize = true;
            lblInvalido.ForeColor = Color.Red;
            lblInvalido.Location = new Point(3, 87);
            lblInvalido.Name = "lblInvalido";
            lblInvalido.Size = new Size(147, 20);
            lblInvalido.TabIndex = 5;
            lblInvalido.Text = "Credenciais Inválidas";
            lblInvalido.Visible = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(285, 81);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(86, 31);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(58, 43);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(311, 27);
            txtSenha.TabIndex = 3;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 4);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 27);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(3, 47);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 8);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 147);
            ControlBox = false;
            Controls.Add(pnlLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            ShowInTaskbar = false;
            Text = "Login";
            Load += FrmLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label lblSenha;
        private Label lblEmail;
        private Label lblInvalido;
    }
}
