﻿namespace TallSys
{
    partial class MtoVehiculos
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxModelo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtPlaca = new System.Windows.Forms.TextBox();
            this.edtFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtId = new System.Windows.Forms.TextBox();
            this.btnCrearMarca = new System.Windows.Forms.Button();
            this.btnCrearModelo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(254, 66);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(581, 50);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // edtBuscar
            // 
            this.edtBuscar.Location = new System.Drawing.Point(353, 59);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "por placa";
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(353, 139);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(222, 21);
            this.cboxMarca.TabIndex = 21;
            this.cboxMarca.Click += new System.EventHandler(this.eventocboxMarca);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Marca";
            // 
            // cboxModelo
            // 
            this.cboxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModelo.FormattingEnabled = true;
            this.cboxModelo.Location = new System.Drawing.Point(353, 175);
            this.cboxModelo.Name = "cboxModelo";
            this.cboxModelo.Size = new System.Drawing.Size(222, 21);
            this.cboxModelo.TabIndex = 23;
            this.cboxModelo.Click += new System.EventHandler(this.eventocboxModelo);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Placa";
            // 
            // edtPlaca
            // 
            this.edtPlaca.Location = new System.Drawing.Point(353, 214);
            this.edtPlaca.Name = "edtPlaca";
            this.edtPlaca.Size = new System.Drawing.Size(222, 20);
            this.edtPlaca.TabIndex = 25;
            this.edtPlaca.TextChanged += new System.EventHandler(this.edtPlaca_TextChanged);
            // 
            // edtFecha
            // 
            this.edtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFecha.Location = new System.Drawing.Point(353, 252);
            this.edtFecha.Name = "edtFecha";
            this.edtFecha.Size = new System.Drawing.Size(222, 20);
            this.edtFecha.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha Creación";
            // 
            // edtId
            // 
            this.edtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtId.Location = new System.Drawing.Point(353, 105);
            this.edtId.Name = "edtId";
            this.edtId.Size = new System.Drawing.Size(222, 20);
            this.edtId.TabIndex = 28;
            // 
            // btnCrearMarca
            // 
            this.btnCrearMarca.Location = new System.Drawing.Point(581, 134);
            this.btnCrearMarca.Name = "btnCrearMarca";
            this.btnCrearMarca.Size = new System.Drawing.Size(75, 29);
            this.btnCrearMarca.TabIndex = 42;
            this.btnCrearMarca.Text = "Crear";
            this.btnCrearMarca.UseVisualStyleBackColor = true;
            this.btnCrearMarca.Click += new System.EventHandler(this.btnCrearMarca_Click);
            // 
            // btnCrearModelo
            // 
            this.btnCrearModelo.Location = new System.Drawing.Point(581, 170);
            this.btnCrearModelo.Name = "btnCrearModelo";
            this.btnCrearModelo.Size = new System.Drawing.Size(75, 29);
            this.btnCrearModelo.TabIndex = 43;
            this.btnCrearModelo.Text = "Crear";
            this.btnCrearModelo.UseVisualStyleBackColor = true;
            this.btnCrearModelo.Click += new System.EventHandler(this.btnCrearModelo_Click);
            // 
            // MtoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.btnCrearModelo);
            this.Controls.Add(this.btnCrearMarca);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.edtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtPlaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MtoVehiculos";
            this.Text = "MtoVehiculos";
            this.Load += new System.EventHandler(this.MtoVehiculos_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cboxMarca, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cboxModelo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.edtPlaca, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.edtFecha, 0);
            this.Controls.SetChildIndex(this.edtId, 0);
            this.Controls.SetChildIndex(this.btnCrearMarca, 0);
            this.Controls.SetChildIndex(this.btnCrearModelo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtPlaca;
        private System.Windows.Forms.TextBox edtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtId;
        private System.Windows.Forms.Button btnCrearMarca;
        private System.Windows.Forms.Button btnCrearModelo;
    }
}