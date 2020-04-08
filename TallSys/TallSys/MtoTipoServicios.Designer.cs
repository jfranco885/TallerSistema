namespace TallSys
{
    partial class MtoTipoServicios
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
            this.edtServicio = new System.Windows.Forms.TextBox();
            this.edtPrecio = new System.Windows.Forms.TextBox();
            this.edtTiempo = new System.Windows.Forms.TextBox();
            this.edtDescripcion = new System.Windows.Forms.TextBox();
            this.edtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(239, 60);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(580, 48);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(799, 246);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(799, 204);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(799, 165);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(799, 126);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // edtBuscar
            // 
            this.edtBuscar.Location = new System.Drawing.Point(352, 57);
            this.groupBox1.Controls.SetChildIndex(this.btnSalir, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtUsuario, 0);
            // 
            // edtServicio
            // 
            this.edtServicio.Location = new System.Drawing.Point(171, 156);
            this.edtServicio.Name = "edtServicio";
            this.edtServicio.Size = new System.Drawing.Size(226, 20);
            this.edtServicio.TabIndex = 27;
            this.edtServicio.TextChanged += new System.EventHandler(this.edtServicio_TextChanged);
            // 
            // edtPrecio
            // 
            this.edtPrecio.Location = new System.Drawing.Point(171, 189);
            this.edtPrecio.Name = "edtPrecio";
            this.edtPrecio.Size = new System.Drawing.Size(226, 20);
            this.edtPrecio.TabIndex = 26;
            this.edtPrecio.TextChanged += new System.EventHandler(this.edtPrecio_TextChanged);
            // 
            // edtTiempo
            // 
            this.edtTiempo.Location = new System.Drawing.Point(171, 223);
            this.edtTiempo.Name = "edtTiempo";
            this.edtTiempo.Size = new System.Drawing.Size(226, 20);
            this.edtTiempo.TabIndex = 25;
            this.edtTiempo.TextChanged += new System.EventHandler(this.edtTiempo_TextChanged);
            // 
            // edtDescripcion
            // 
            this.edtDescripcion.Location = new System.Drawing.Point(444, 160);
            this.edtDescripcion.Multiline = true;
            this.edtDescripcion.Name = "edtDescripcion";
            this.edtDescripcion.Size = new System.Drawing.Size(317, 54);
            this.edtDescripcion.TabIndex = 24;
            this.edtDescripcion.TextChanged += new System.EventHandler(this.edtDescripcion_TextChanged);
            // 
            // edtId
            // 
            this.edtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtId.Location = new System.Drawing.Point(171, 130);
            this.edtId.Name = "edtId";
            this.edtId.Size = new System.Drawing.Size(226, 20);
            this.edtId.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tiempo en horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "por Id";
            // 
            // edtFecha
            // 
            this.edtFecha.Location = new System.Drawing.Point(523, 226);
            this.edtFecha.Name = "edtFecha";
            this.edtFecha.Size = new System.Drawing.Size(226, 20);
            this.edtFecha.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fecha Creación";
            // 
            // MtoTipoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.edtFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtServicio);
            this.Controls.Add(this.edtPrecio);
            this.Controls.Add(this.edtTiempo);
            this.Controls.Add(this.edtDescripcion);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MtoTipoServicios";
            this.Text = "MtoTipoServicios";
            this.Load += new System.EventHandler(this.MtoTipoServicios_Load);
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
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.edtId, 0);
            this.Controls.SetChildIndex(this.edtDescripcion, 0);
            this.Controls.SetChildIndex(this.edtTiempo, 0);
            this.Controls.SetChildIndex(this.edtPrecio, 0);
            this.Controls.SetChildIndex(this.edtServicio, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.edtFecha, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtServicio;
        private System.Windows.Forms.TextBox edtPrecio;
        private System.Windows.Forms.TextBox edtTiempo;
        private System.Windows.Forms.TextBox edtDescripcion;
        private System.Windows.Forms.TextBox edtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtFecha;
        private System.Windows.Forms.Label label8;
    }
}