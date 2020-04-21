namespace TallSys
{
    partial class ReporteEntradas
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
            this.crEntradas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crEntradas
            // 
            this.crEntradas.ActiveViewIndex = -1;
            this.crEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crEntradas.Location = new System.Drawing.Point(0, 0);
            this.crEntradas.Name = "crEntradas";
            this.crEntradas.ShowLogo = false;
            this.crEntradas.Size = new System.Drawing.Size(1353, 657);
            this.crEntradas.TabIndex = 0;
            this.crEntradas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // ReporteEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 657);
            this.Controls.Add(this.crEntradas);
            this.Name = "ReporteEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEntradas";
            this.Load += new System.EventHandler(this.ReporteEntradas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crEntradas;
    }
}