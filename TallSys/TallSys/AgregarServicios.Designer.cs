﻿namespace TallSys
{
    partial class AgregarServicios
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.edtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cboxNave = new System.Windows.Forms.ComboBox();
            this.cboxTipoServicio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.edtIdVehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtIdServicioEncabezado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridServiciosAgregados = new System.Windows.Forms.DataGridView();
            this.edtidServicioDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiciosAgregados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboxEstado);
            this.groupBox4.Controls.Add(this.edtDescripcion);
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.Controls.Add(this.btnNuevo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cboxNave);
            this.groupBox4.Controls.Add(this.cboxTipoServicio);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(551, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 319);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Solicitud Servicio";
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Nave No I",
            "Nave No II"});
            this.cboxEstado.Location = new System.Drawing.Point(107, 237);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(235, 21);
            this.cboxEstado.TabIndex = 30;
            // 
            // edtDescripcion
            // 
            this.edtDescripcion.Location = new System.Drawing.Point(107, 123);
            this.edtDescripcion.Multiline = true;
            this.edtDescripcion.Name = "edtDescripcion";
            this.edtDescripcion.Size = new System.Drawing.Size(235, 82);
            this.edtDescripcion.TabIndex = 18;
            this.edtDescripcion.TextChanged += new System.EventHandler(this.edtDescripcion_TextChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(134, 277);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(246, 277);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Estado";
            // 
            // cboxNave
            // 
            this.cboxNave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNave.FormattingEnabled = true;
            this.cboxNave.Items.AddRange(new object[] {
            "Nave No I",
            "Nave No II"});
            this.cboxNave.Location = new System.Drawing.Point(107, 82);
            this.cboxNave.Name = "cboxNave";
            this.cboxNave.Size = new System.Drawing.Size(235, 21);
            this.cboxNave.TabIndex = 14;
            // 
            // cboxTipoServicio
            // 
            this.cboxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoServicio.FormattingEnabled = true;
            this.cboxTipoServicio.Items.AddRange(new object[] {
            "Lavado",
            "Cambio de Aceite"});
            this.cboxTipoServicio.Location = new System.Drawing.Point(107, 35);
            this.cboxTipoServicio.Name = "cboxTipoServicio";
            this.cboxTipoServicio.Size = new System.Drawing.Size(235, 21);
            this.cboxTipoServicio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Naves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Servicio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(787, 394);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(172, 36);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Asignar Empleados";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // edtIdVehiculo
            // 
            this.edtIdVehiculo.Location = new System.Drawing.Point(136, 172);
            this.edtIdVehiculo.Name = "edtIdVehiculo";
            this.edtIdVehiculo.Size = new System.Drawing.Size(140, 20);
            this.edtIdVehiculo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculo";
            // 
            // edtIdServicioEncabezado
            // 
            this.edtIdServicioEncabezado.Location = new System.Drawing.Point(136, 139);
            this.edtIdServicioEncabezado.Name = "edtIdServicioEncabezado";
            this.edtIdServicioEncabezado.Size = new System.Drawing.Size(140, 20);
            this.edtIdServicioEncabezado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IdServicio Encabezado";
            // 
            // dataGridServiciosAgregados
            // 
            this.dataGridServiciosAgregados.AllowUserToAddRows = false;
            this.dataGridServiciosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServiciosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServiciosAgregados.Location = new System.Drawing.Point(16, 229);
            this.dataGridServiciosAgregados.Name = "dataGridServiciosAgregados";
            this.dataGridServiciosAgregados.RowHeadersVisible = false;
            this.dataGridServiciosAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServiciosAgregados.Size = new System.Drawing.Size(520, 150);
            this.dataGridServiciosAgregados.TabIndex = 41;
            // 
            // edtidServicioDetalle
            // 
            this.edtidServicioDetalle.Location = new System.Drawing.Point(620, 403);
            this.edtidServicioDetalle.Name = "edtidServicioDetalle";
            this.edtidServicioDetalle.Size = new System.Drawing.Size(140, 20);
            this.edtidServicioDetalle.TabIndex = 42;
            this.edtidServicioDetalle.TextChanged += new System.EventHandler(this.edtidServicioDetalle_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "idServicio";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(300, 201);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 31;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // AgregarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.edtidServicioDetalle);
            this.Controls.Add(this.dataGridServiciosAgregados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtIdServicioEncabezado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.edtIdVehiculo);
            this.Controls.Add(this.label3);
            this.Name = "AgregarServicios";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.AgregarServicios_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edtIdVehiculo, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtIdServicioEncabezado, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.dataGridServiciosAgregados, 0);
            this.Controls.SetChildIndex(this.edtidServicioDetalle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnMostrar, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiciosAgregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboxNave;
        private System.Windows.Forms.ComboBox cboxTipoServicio;
        private System.Windows.Forms.TextBox edtIdVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox edtDescripcion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboxEstado;
        public System.Windows.Forms.TextBox edtIdServicioEncabezado;
        private System.Windows.Forms.TextBox edtidServicioDetalle;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridServiciosAgregados;
        private System.Windows.Forms.Button btnMostrar;
    }
}