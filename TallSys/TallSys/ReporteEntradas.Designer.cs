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
            this.crvEntradas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvEntradas
            // 
            this.crvEntradas.ActiveViewIndex = -1;
            this.crvEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEntradas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEntradas.Location = new System.Drawing.Point(0, 0);
            this.crvEntradas.Name = "crvEntradas";
            this.crvEntradas.ShowLogo = false;
            this.crvEntradas.Size = new System.Drawing.Size(1353, 657);
            this.crvEntradas.TabIndex = 0;
            this.crvEntradas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // ReporteEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 657);
            this.Controls.Add(this.crvEntradas);
            this.Name = "ReporteEntradas";
            this.Text = "ReporteEntradas";
            this.Load += new System.EventHandler(this.ReporteEntradas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEntradas;
    }
}