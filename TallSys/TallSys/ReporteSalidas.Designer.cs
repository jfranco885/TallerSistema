namespace TallSys
{
    partial class ReporteSalidas
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
            this.crSalidas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportedeSalidas1 = new TallSys.ReportedeSalidas();
            this.SuspendLayout();
            // 
            // crSalidas
            // 
            this.crSalidas.ActiveViewIndex = 0;
            this.crSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crSalidas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crSalidas.Location = new System.Drawing.Point(0, 0);
            this.crSalidas.Name = "crSalidas";
            this.crSalidas.ReportSource = this.ReportedeSalidas1;
            this.crSalidas.ShowLogo = false;
            this.crSalidas.Size = new System.Drawing.Size(1338, 690);
            this.crSalidas.TabIndex = 0;
            this.crSalidas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // ReporteSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 690);
            this.Controls.Add(this.crSalidas);
            this.Name = "ReporteSalidas";
            this.Text = "ReporteSalidas";
            this.Load += new System.EventHandler(this.ReporteSalidas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crSalidas;
        private ReportedeSalidas ReportedeSalidas1;
    }
}