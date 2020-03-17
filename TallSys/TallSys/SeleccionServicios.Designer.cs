namespace TallSys
{
    partial class SeleccionServicios
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
            this.btnServEjecutandose = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServEjecutandose
            // 
            this.btnServEjecutandose.Image = global::TallSys.Properties.Resources.ejecuser;
            this.btnServEjecutandose.Location = new System.Drawing.Point(286, 80);
            this.btnServEjecutandose.Name = "btnServEjecutandose";
            this.btnServEjecutandose.Size = new System.Drawing.Size(172, 105);
            this.btnServEjecutandose.TabIndex = 1;
            this.btnServEjecutandose.Text = "Servicios en Ejecusión";
            this.btnServEjecutandose.UseVisualStyleBackColor = true;
            this.btnServEjecutandose.Click += new System.EventHandler(this.btnServEjecutandose_Click);
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.Image = global::TallSys.Properties.Resources.nservicio;
            this.btnNuevoServicio.Location = new System.Drawing.Point(83, 80);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(172, 105);
            this.btnNuevoServicio.TabIndex = 0;
            this.btnNuevoServicio.Text = "Nuevo Servicio";
            this.btnNuevoServicio.UseVisualStyleBackColor = true;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // SeleccionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 284);
            this.Controls.Add(this.btnServEjecutandose);
            this.Controls.Add(this.btnNuevoServicio);
            this.Name = "SeleccionServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionServicios";
            this.Load += new System.EventHandler(this.SeleccionServicios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoServicio;
        private System.Windows.Forms.Button btnServEjecutandose;
    }
}