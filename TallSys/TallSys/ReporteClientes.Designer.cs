namespace TallSys
{
    partial class ReporteClientes
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
            this.crclientes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crclientes
            // 
            this.crclientes.ActiveViewIndex = -1;
            this.crclientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crclientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crclientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crclientes.Location = new System.Drawing.Point(0, 0);
            this.crclientes.Name = "crclientes";
            this.crclientes.ShowLogo = false;
            this.crclientes.Size = new System.Drawing.Size(1281, 670);
            this.crclientes.TabIndex = 0;
            this.crclientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 670);
            this.Controls.Add(this.crclientes);
            this.Name = "ReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteClientes";
            this.Load += new System.EventHandler(this.ReporteClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crclientes;
    }
}