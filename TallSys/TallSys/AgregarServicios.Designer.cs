namespace TallSys
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
            this.label12 = new System.Windows.Forms.Label();
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
            this.edtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtIdServicioEncabezado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridServiciosAgregados = new System.Windows.Forms.DataGridView();
            this.edtidServicioDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtNombreCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtAsignacion = new System.Windows.Forms.TextBox();
            this.edtDui = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edtCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiciosAgregados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            this.txtUsuario.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.edtCantidad);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cboxEstado);
            this.groupBox4.Controls.Add(this.edtDescripcion);
            this.groupBox4.Controls.Add(this.btnGenerar);
            this.groupBox4.Controls.Add(this.btnNuevo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cboxNave);
            this.groupBox4.Controls.Add(this.cboxTipoServicio);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(551, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 319);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Solicitud Servicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tipo Servicio";
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
            this.cboxEstado.Click += new System.EventHandler(this.eventoEstado);
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
            this.cboxNave.Location = new System.Drawing.Point(107, 88);
            this.cboxNave.Name = "cboxNave";
            this.cboxNave.Size = new System.Drawing.Size(235, 21);
            this.cboxNave.TabIndex = 14;
            this.cboxNave.Click += new System.EventHandler(this.evento);
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
            this.cboxTipoServicio.Click += new System.EventHandler(this.eventoTipo);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 91);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnAsignarMecanico_Click);
            // 
            // edtPlacaVehiculo
            // 
            this.edtPlacaVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtPlacaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPlacaVehiculo.Location = new System.Drawing.Point(145, 56);
            this.edtPlacaVehiculo.Name = "edtPlacaVehiculo";
            this.edtPlacaVehiculo.Size = new System.Drawing.Size(193, 20);
            this.edtPlacaVehiculo.TabIndex = 7;
            this.edtPlacaVehiculo.TextChanged += new System.EventHandler(this.edtPlacaVehiculo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa Vehiculo";
            // 
            // edtIdServicioEncabezado
            // 
            this.edtIdServicioEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtIdServicioEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtIdServicioEncabezado.Location = new System.Drawing.Point(145, 23);
            this.edtIdServicioEncabezado.Name = "edtIdServicioEncabezado";
            this.edtIdServicioEncabezado.Size = new System.Drawing.Size(140, 20);
            this.edtIdServicioEncabezado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-123, 32);
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
            this.dataGridServiciosAgregados.ReadOnly = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Servicios agregados";
            // 
            // edtNombreCliente
            // 
            this.edtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNombreCliente.Location = new System.Drawing.Point(145, 108);
            this.edtNombreCliente.Name = "edtNombreCliente";
            this.edtNombreCliente.Size = new System.Drawing.Size(193, 20);
            this.edtNombreCliente.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cliente";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(370, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(370, 82);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.edtAsignacion);
            this.groupBox2.Controls.Add(this.edtDui);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.edtNombreCliente);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.edtPlacaVehiculo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.edtIdServicioEncabezado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 161);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encabezado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Asignación Vehículo Cliente";
            // 
            // edtAsignacion
            // 
            this.edtAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtAsignacion.Location = new System.Drawing.Point(183, 132);
            this.edtAsignacion.Name = "edtAsignacion";
            this.edtAsignacion.Size = new System.Drawing.Size(155, 20);
            this.edtAsignacion.TabIndex = 51;
            // 
            // edtDui
            // 
            this.edtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDui.Location = new System.Drawing.Point(145, 82);
            this.edtDui.Name = "edtDui";
            this.edtDui.Size = new System.Drawing.Size(193, 20);
            this.edtDui.TabIndex = 49;
            this.edtDui.TextChanged += new System.EventHandler(this.edtDui_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Dui Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Id Encabezado";
            // 
            // edtCantidad
            // 
            this.edtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCantidad.Location = new System.Drawing.Point(107, 62);
            this.edtCantidad.Name = "edtCantidad";
            this.edtCantidad.Size = new System.Drawing.Size(235, 20);
            this.edtCantidad.TabIndex = 52;
            this.edtCantidad.TextChanged += new System.EventHandler(this.edtCantidad_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Cantidad";
            // 
            // AgregarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtidServicioDetalle);
            this.Controls.Add(this.dataGridServiciosAgregados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Name = "AgregarServicios";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.AgregarServicios_Load);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.dataGridServiciosAgregados, 0);
            this.Controls.SetChildIndex(this.edtidServicioDetalle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiciosAgregados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboxNave;
        private System.Windows.Forms.ComboBox cboxTipoServicio;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox edtPlacaVehiculo;
        public System.Windows.Forms.TextBox edtNombreCliente;
        public System.Windows.Forms.TextBox edtDui;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox edtAsignacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox edtCantidad;
    }
}