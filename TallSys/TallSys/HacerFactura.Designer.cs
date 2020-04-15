namespace TallSys
{
    partial class HacerFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listarPorEncabezadoFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFactura = new TallSys.DataSetFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listarPorEncabezadoFacturaTableAdapter = new TallSys.DataSetFacturaTableAdapters.listarPorEncabezadoFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listarPorEncabezadoFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // listarPorEncabezadoFacturaBindingSource
            // 
            this.listarPorEncabezadoFacturaBindingSource.DataMember = "listarPorEncabezadoFactura";
            this.listarPorEncabezadoFacturaBindingSource.DataSource = this.DataSetFactura;
            // 
            // DataSetFactura
            // 
            this.DataSetFactura.DataSetName = "DataSetFactura";
            this.DataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listarPorEncabezadoFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TallSys.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // listarPorEncabezadoFacturaTableAdapter
            // 
            this.listarPorEncabezadoFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // HacerFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HacerFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HacerFactura";
            this.Load += new System.EventHandler(this.HacerFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarPorEncabezadoFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource listarPorEncabezadoFacturaBindingSource;
        private DataSetFactura DataSetFactura;
        private DataSetFacturaTableAdapters.listarPorEncabezadoFacturaTableAdapter listarPorEncabezadoFacturaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}