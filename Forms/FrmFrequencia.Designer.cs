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
            this.pnlFrequencia = new System.Windows.Forms.Panel();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.mntFrequencia = new System.Windows.Forms.MonthCalendar();
            this.pnlFrequencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrequencia
            // 
            this.pnlFrequencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrequencia.Controls.Add(this.lblDetalhes);
            this.pnlFrequencia.Controls.Add(this.mntFrequencia);
            this.pnlFrequencia.Location = new System.Drawing.Point(10, 9);
            this.pnlFrequencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFrequencia.Name = "pnlFrequencia";
            this.pnlFrequencia.Size = new System.Drawing.Size(679, 320);
            this.pnlFrequencia.TabIndex = 0;
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(246, 7);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(110, 15);
            this.lblDetalhes.TabIndex = 1;
            this.lblDetalhes.Text = "Selecione uma data";
            // 
            // mntFrequencia
            // 
            this.mntFrequencia.Location = new System.Drawing.Point(8, 7);
            this.mntFrequencia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mntFrequencia.Name = "mntFrequencia";
            this.mntFrequencia.TabIndex = 0;
            this.mntFrequencia.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntFrequencia_DateSelected);
            // 
            // FrmFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pnlFrequencia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmFrequencia";
            this.Text = "FrmFrequencia";
            this.pnlFrequencia.ResumeLayout(false);
            this.pnlFrequencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlFrequencia;
        private MonthCalendar mntFrequencia;
        private Label lblDetalhes;
    }
}