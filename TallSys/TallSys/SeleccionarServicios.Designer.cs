namespace TallSys
{
    partial class SeleccionarServicios
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
            this.dataGridServicios = new System.Windows.Forms.DataGridView();
            this.d = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtTipoServicio = new System.Windows.Forms.Label();
            this.txtCodigoTipoServ = new System.Windows.Forms.Label();
            this.txtIdServicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtDescuento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncabezado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(790, 11);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            this.txtUsuario.Text = "";
            // 
            // dataGridServicios
            // 
            this.dataGridServicios.AllowUserToAddRows = false;
            this.dataGridServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicios.Location = new System.Drawing.Point(12, 228);
            this.dataGridServicios.Name = "dataGridServicios";
            this.dataGridServicios.ReadOnly = true;
            this.dataGridServicios.RowHeadersVisible = false;
            this.dataGridServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServicios.Size = new System.Drawing.Size(940, 223);
            this.dataGridServicios.TabIndex = 3;
            this.dataGridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnviarDatos);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(39, 133);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(105, 13);
            this.d.TabIndex = 16;
            this.d.Text = "Código Tipo Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Servicio";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(39, 95);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 14;
            this.label.Text = "idServicio";
            // 
            // txtTipoServicio
            // 
            this.txtTipoServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoServicio.Location = new System.Drawing.Point(161, 182);
            this.txtTipoServicio.Name = "txtTipoServicio";
            this.txtTipoServicio.Size = new System.Drawing.Size(232, 23);
            this.txtTipoServicio.TabIndex = 13;
            this.txtTipoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoTipoServ
            // 
            this.txtCodigoTipoServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoTipoServ.Location = new System.Drawing.Point(161, 133);
            this.txtCodigoTipoServ.Name = "txtCodigoTipoServ";
            this.txtCodigoTipoServ.Size = new System.Drawing.Size(232, 23);
            this.txtCodigoTipoServ.TabIndex = 12;
            this.txtCodigoTipoServ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdServicio.Location = new System.Drawing.Point(161, 85);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(232, 23);
            this.txtIdServicio.TabIndex = 11;
            this.txtIdServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(543, 132);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 23);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descuento";
            // 
            // edtDescuento
            // 
            this.edtDescuento.Location = new System.Drawing.Point(543, 182);
            this.edtDescuento.Name = "edtDescuento";
            this.edtDescuento.Size = new System.Drawing.Size(232, 20);
            this.edtDescuento.TabIndex = 20;
            this.edtDescuento.TextChanged += new System.EventHandler(this.edtDescuento_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(819, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 47);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(543, 85);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(232, 23);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "idEncabezado Servicio";
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEncabezado.Location = new System.Drawing.Point(137, 55);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.Size = new System.Drawing.Size(149, 23);
            this.txtEncabezado.TabIndex = 24;
            this.txtEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeleccionarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncabezado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.edtDescuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTipoServicio);
            this.Controls.Add(this.txtCodigoTipoServ);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.dataGridServicios);
            this.Name = "SeleccionarServicios";
            this.Text = "SeleccionarServicios";
            this.Load += new System.EventHandler(this.SeleccionarServicios_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridServicios, 0);
            this.Controls.SetChildIndex(this.txtIdServicio, 0);
            this.Controls.SetChildIndex(this.txtCodigoTipoServ, 0);
            this.Controls.SetChildIndex(this.txtTipoServicio, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.d, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtDescuento, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEncabezado, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.DataGridView dataGridServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label txtTipoServicio;
        public System.Windows.Forms.Label txtCodigoTipoServ;
        public System.Windows.Forms.Label txtIdServicio;
        public System.Windows.Forms.Label txtPrecio;
        public System.Windows.Forms.TextBox edtDescuento;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label txtEncabezado;
    }
}