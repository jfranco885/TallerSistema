﻿namespace TallSys
{
    partial class MtoCambioPiezas
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
            this.label2 = new System.Windows.Forms.Label();
            this.edtid = new System.Windows.Forms.TextBox();
            this.edtRepuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtDetalleServicio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código Cambio";
            // 
            // edtid
            // 
            this.edtid.Location = new System.Drawing.Point(375, 138);
            this.edtid.Name = "edtid";
            this.edtid.Size = new System.Drawing.Size(270, 20);
            this.edtid.TabIndex = 17;
            // 
            // edtRepuesto
            // 
            this.edtRepuesto.Location = new System.Drawing.Point(375, 190);
            this.edtRepuesto.Name = "edtRepuesto";
            this.edtRepuesto.Size = new System.Drawing.Size(270, 20);
            this.edtRepuesto.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id Detalle Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre Repuesto";
            // 
            // edtDetalleServicio
            // 
            this.edtDetalleServicio.FormattingEnabled = true;
            this.edtDetalleServicio.Location = new System.Drawing.Point(375, 237);
            this.edtDetalleServicio.Name = "edtDetalleServicio";
            this.edtDetalleServicio.Size = new System.Drawing.Size(270, 21);
            this.edtDetalleServicio.TabIndex = 21;
            // 
            // MtoCambioPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 474);
            this.Controls.Add(this.edtDetalleServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtRepuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtid);
            this.Controls.Add(this.label2);
            this.Name = "MtoCambioPiezas";
            this.Text = "MtoCambioPiezas";
            this.Load += new System.EventHandler(this.MtoCambioPiezas_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtid, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edtRepuesto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.edtDetalleServicio, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtid;
        private System.Windows.Forms.TextBox edtRepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox edtDetalleServicio;
    }
}