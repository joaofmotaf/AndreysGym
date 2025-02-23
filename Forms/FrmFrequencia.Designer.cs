namespace AndreysGym.Forms
{
    partial class FrmFrequencia
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
            pnlFrequencia = new Panel();
            mntFrequencia = new MonthCalendar();
            lblDetalhes = new Label();
            pnlFrequencia.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFrequencia
            // 
            pnlFrequencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFrequencia.Controls.Add(lblDetalhes);
            pnlFrequencia.Controls.Add(mntFrequencia);
            pnlFrequencia.Location = new Point(10, 9);
            pnlFrequencia.Margin = new Padding(3, 2, 3, 2);
            pnlFrequencia.Name = "pnlFrequencia";
            pnlFrequencia.Size = new Size(679, 320);
            pnlFrequencia.TabIndex = 0;
            // 
            // mntFrequencia
            // 
            mntFrequencia.Location = new Point(8, 7);
            mntFrequencia.Margin = new Padding(8, 7, 8, 7);
            mntFrequencia.Name = "mntFrequencia";
            mntFrequencia.TabIndex = 0;
            mntFrequencia.DateSelected += mntFrequencia_DateSelected;
            // 
            // lblDetalhes
            // 
            lblDetalhes.AutoSize = true;
            lblDetalhes.Location = new Point(264, 95);
            lblDetalhes.Name = "lblDetalhes";
            lblDetalhes.Size = new Size(38, 15);
            lblDetalhes.TabIndex = 1;
            lblDetalhes.Text = "label1";
            // 
            // FrmFrequencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pnlFrequencia);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmFrequencia";
            Text = "FrmFrequencia";
            pnlFrequencia.ResumeLayout(false);
            pnlFrequencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFrequencia;
        private MonthCalendar mntFrequencia;
        private Label lblDetalhes;
    }
}