﻿namespace TallSys
{
    partial class MtoEmpleados
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
            this.edtDui = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtNombre = new System.Windows.Forms.TextBox();
            this.edtApellido = new System.Windows.Forms.TextBox();
            this.edtFecha = new System.Windows.Forms.TextBox();
            this.edtCelular = new System.Windows.Forms.TextBox();
            this.edtCorreo = new System.Windows.Forms.TextBox();
            this.edtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxEspecialidad = new System.Windows.Forms.ComboBox();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxServicioVehiculo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(257, 83);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            this.groupBox1.Controls.SetChildIndex(this.btnSalir, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtUsuario, 0);
            // 
            // edtDui
            // 
            this.edtDui.Location = new System.Drawing.Point(519, 109);
            this.edtDui.Name = "edtDui";
            this.edtDui.Size = new System.Drawing.Size(226, 20);
            this.edtDui.TabIndex = 45;
            this.edtDui.TextChanged += new System.EventHandler(this.edtDui_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "DUI";
            // 
            // edtNombre
            // 
            this.edtNombre.Location = new System.Drawing.Point(229, 143);
            this.edtNombre.Name = "edtNombre";
            this.edtNombre.Size = new System.Drawing.Size(226, 20);
            this.edtNombre.TabIndex = 43;
            this.edtNombre.TextChanged += new System.EventHandler(this.edtNombre_TextChanged);
            // 
            // edtApellido
            // 
            this.edtApellido.Location = new System.Drawing.Point(229, 178);
            this.edtApellido.Name = "edtApellido";
            this.edtApellido.Size = new System.Drawing.Size(226, 20);
            this.edtApellido.TabIndex = 42;
            this.edtApellido.TextChanged += new System.EventHandler(this.edtApellido_TextChanged);
            // 
            // edtFecha
            // 
            this.edtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFecha.Location = new System.Drawing.Point(519, 239);
            this.edtFecha.Name = "edtFecha";
            this.edtFecha.Size = new System.Drawing.Size(226, 20);
            this.edtFecha.TabIndex = 41;
            this.edtFecha.TextChanged += new System.EventHandler(this.edtFecha_TextChanged);
            // 
            // edtCelular
            // 
            this.edtCelular.Location = new System.Drawing.Point(519, 140);
            this.edtCelular.Name = "edtCelular";
            this.edtCelular.Size = new System.Drawing.Size(226, 20);
            this.edtCelular.TabIndex = 40;
            this.edtCelular.TextChanged += new System.EventHandler(this.edtCelular_TextChanged);
            // 
            // edtCorreo
            // 
            this.edtCorreo.Location = new System.Drawing.Point(519, 211);
            this.edtCorreo.Name = "edtCorreo";
            this.edtCorreo.Size = new System.Drawing.Size(226, 20);
            this.edtCorreo.TabIndex = 38;
            this.edtCorreo.TextChanged += new System.EventHandler(this.edtCorreo_TextChanged);
            // 
            // edtIdEmpleado
            // 
            this.edtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtIdEmpleado.Location = new System.Drawing.Point(229, 109);
            this.edtIdEmpleado.Name = "edtIdEmpleado";
            this.edtIdEmpleado.Size = new System.Drawing.Size(226, 20);
            this.edtIdEmpleado.TabIndex = 37;
            this.edtIdEmpleado.TextChanged += new System.EventHandler(this.edtIdEmpleado_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nombres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Celular";
            // 
            // cboxEspecialidad
            // 
            this.cboxEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEspecialidad.FormattingEnabled = true;
            this.cboxEspecialidad.Location = new System.Drawing.Point(229, 242);
            this.cboxEspecialidad.Name = "cboxEspecialidad";
            this.cboxEspecialidad.Size = new System.Drawing.Size(226, 21);
            this.cboxEspecialidad.TabIndex = 34;
            this.cboxEspecialidad.Click += new System.EventHandler(this.eventoEspecialidad);
            // 
            // cboxCargo
            // 
            this.cboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(229, 210);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(226, 21);
            this.cboxCargo.TabIndex = 33;
            this.cboxCargo.Click += new System.EventHandler(this.eventoCargo);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Por DUI";
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(519, 175);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(226, 21);
            this.cboxEstado.TabIndex = 49;
            this.cboxEstado.SelectedIndexChanged += new System.EventHandler(this.cboxEstado_SelectedIndexChanged);
            this.cboxEstado.Click += new System.EventHandler(this.eventoEstado);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Brindará servicio a vehículo";
            // 
            // cboxServicioVehiculo
            // 
            this.cboxServicioVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxServicioVehiculo.FormattingEnabled = true;
            this.cboxServicioVehiculo.Location = new System.Drawing.Point(519, 263);
            this.cboxServicioVehiculo.Name = "cboxServicioVehiculo";
            this.cboxServicioVehiculo.Size = new System.Drawing.Size(226, 21);
            this.cboxServicioVehiculo.TabIndex = 51;
            this.cboxServicioVehiculo.Click += new System.EventHandler(this.eventoSeraVehi);
            // 
            // MtoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.cboxServicioVehiculo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtDui);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.edtNombre);
            this.Controls.Add(this.edtApellido);
            this.Controls.Add(this.edtFecha);
            this.Controls.Add(this.edtCelular);
            this.Controls.Add(this.edtCorreo);
            this.Controls.Add(this.edtIdEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboxEspecialidad);
            this.Controls.Add(this.cboxCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "MtoEmpleados";
            this.Text = "MtoEmpleados";
            this.Load += new System.EventHandler(this.MtoEmpleados_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cboxCargo, 0);
            this.Controls.SetChildIndex(this.cboxEspecialidad, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.edtIdEmpleado, 0);
            this.Controls.SetChildIndex(this.edtCorreo, 0);
            this.Controls.SetChildIndex(this.edtCelular, 0);
            this.Controls.SetChildIndex(this.edtFecha, 0);
            this.Controls.SetChildIndex(this.edtApellido, 0);
            this.Controls.SetChildIndex(this.edtNombre, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.edtDui, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.cboxEstado, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cboxServicioVehiculo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtDui;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtNombre;
        private System.Windows.Forms.TextBox edtApellido;
        private System.Windows.Forms.TextBox edtFecha;
        private System.Windows.Forms.TextBox edtCelular;
        private System.Windows.Forms.TextBox edtCorreo;
        private System.Windows.Forms.TextBox edtIdEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxEspecialidad;
        private System.Windows.Forms.ComboBox cboxCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxServicioVehiculo;
    }
}