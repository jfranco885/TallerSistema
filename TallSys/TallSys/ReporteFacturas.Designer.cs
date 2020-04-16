namespace TallSys
{
    partial class ReporteFacturas
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
            this.crfacturas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crfacturas
            // 
            this.crfacturas.ActiveViewIndex = -1;
            this.crfacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crfacturas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crfacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crfacturas.Location = new System.Drawing.Point(0, 0);
            this.crfacturas.Name = "crfacturas";
            this.crfacturas.ShowLogo = false;
            this.crfacturas.Size = new System.Drawing.Size(1406, 643);
            this.crfacturas.TabIndex = 0;
            this.crfacturas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            this.crfacturas.Load += new System.EventHandler(this.crfacturas_Load);
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 643);
            this.Controls.Add(this.crfacturas);
            this.Name = "ReporteFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteFacturas";
            this.Load += new System.EventHandler(this.ReporteFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crfacturas;
       // private ReportedeFacturas ReportedeFacturas1;
    }
}