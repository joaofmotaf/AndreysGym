namespace AndreysGym.Forms
{
    partial class FrmSobre
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
            pnlSobre = new Panel();
            btnGostosos = new Button();
            lblMembrosDoGrupo = new Label();
            lblMembros = new Label();
            pnlSobre.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSobre
            // 
            pnlSobre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSobre.Controls.Add(btnGostosos);
            pnlSobre.Controls.Add(lblMembrosDoGrupo);
            pnlSobre.Controls.Add(lblMembros);
            pnlSobre.Location = new Point(10, 9);
            pnlSobre.Margin = new Padding(3, 2, 3, 2);
            pnlSobre.MaximumSize = new Size(274, 131);
            pnlSobre.MinimumSize = new Size(274, 131);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(274, 131);
            pnlSobre.TabIndex = 0;
            // 
            // btnGostosos
            // 
            btnGostosos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGostosos.Location = new Point(76, 94);
            btnGostosos.Margin = new Padding(3, 2, 3, 2);
            btnGostosos.Name = "btnGostosos";
            btnGostosos.Size = new Size(184, 22);
            btnGostosos.TabIndex = 16;
            btnGostosos.Text = "UAU! Quantos Gostosos!";
            btnGostosos.UseVisualStyleBackColor = true;
            btnGostosos.Click += btnGostosos_Click;
            // 
            // lblMembrosDoGrupo
            // 
            lblMembrosDoGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMembrosDoGrupo.AutoSize = true;
            lblMembrosDoGrupo.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblMembrosDoGrupo.Location = new Point(3, 0);
            lblMembrosDoGrupo.Name = "lblMembrosDoGrupo";
            lblMembrosDoGrupo.Size = new Size(242, 32);
            lblMembrosDoGrupo.TabIndex = 9;
            lblMembrosDoGrupo.Text = "Membros Do Grupo";
            // 
            // lblMembros
            // 
            lblMembros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMembros.AutoSize = true;
            lblMembros.Location = new Point(3, 32);
            lblMembros.Name = "lblMembros";
            lblMembros.Size = new Size(167, 60);
            lblMembros.TabIndex = 12;
            lblMembros.Text = "● Andrey Cassius Ramos Mota\r\n● Caio Souza Silva\r\n● João Filipe Mota Ferreira\r\n● Maria Clara Alves de Freitas";
            // 
            // FrmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 151);
            ControlBox = false;
            Controls.Add(pnlSobre);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(313, 190);
            MinimumSize = new Size(313, 190);
            Name = "FrmSobre";
            Text = "Sobre Nós";
            pnlSobre.ResumeLayout(false);
            pnlSobre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSobre;
        private Label lblMembrosDoGrupo;
        private Label lblMembros;
        private Button btnGostosos;
    }
}