namespace TallSys
{
    partial class ReporteEmpleados
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
            this.crEmpleados = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crEmpleados
            // 
            this.crEmpleados.ActiveViewIndex = -1;
            this.crEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.crEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crEmpleados.Location = new System.Drawing.Point(0, 0);
            this.crEmpleados.Name = "crEmpleados";
            this.crEmpleados.ShowLogo = false;
            this.crEmpleados.Size = new System.Drawing.Size(1536, 626);
            this.crEmpleados.TabIndex = 0;
            this.crEmpleados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            this.crEmpleados.Load += new System.EventHandler(this.crEmpleados_Load);
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 626);
            this.Controls.Add(this.crEmpleados);
            this.Name = "ReporteEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crEmpleados;
    }
}