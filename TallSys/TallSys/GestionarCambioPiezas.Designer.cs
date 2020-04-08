namespace TallSys
{
    partial class GestionarCambioPiezas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtRepuesto = new System.Windows.Forms.TextBox();
            this.edtidCambio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridRepuesto = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.edtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(616, 12);
            // 
            // edtServicio
            // 
            this.edtServicio.Location = new System.Drawing.Point(39, 73);
            this.edtServicio.Name = "edtServicio";
            this.edtServicio.Size = new System.Drawing.Size(161, 20);
            this.edtServicio.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Id Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre Repuesto";
            // 
            // edtRepuesto
            // 
            this.edtRepuesto.Location = new System.Drawing.Point(229, 170);
            this.edtRepuesto.Name = "edtRepuesto";
            this.edtRepuesto.Size = new System.Drawing.Size(270, 20);
            this.edtRepuesto.TabIndex = 28;
            this.edtRepuesto.TextChanged += new System.EventHandler(this.edtRepuesto_TextChanged);
            // 
            // edtidCambio
            // 
            this.edtidCambio.Location = new System.Drawing.Point(229, 118);
            this.edtidCambio.Name = "edtidCambio";
            this.edtidCambio.Size = new System.Drawing.Size(270, 20);
            this.edtidCambio.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código Cambio";
            // 
            // dataGridRepuesto
            // 
            this.dataGridRepuesto.AllowUserToAddRows = false;
            this.dataGridRepuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuesto.Location = new System.Drawing.Point(117, 289);
            this.dataGridRepuesto.Name = "dataGridRepuesto";
            this.dataGridRepuesto.ReadOnly = true;
            this.dataGridRepuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRepuesto.Size = new System.Drawing.Size(465, 129);
            this.dataGridRepuesto.TabIndex = 31;
            this.dataGridRepuesto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnviarDatos);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(579, 162);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(579, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(579, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(123, 217);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 13);
            this.label.TabIndex = 35;
            this.label.Text = "Cantidad";
            // 
            // edtCantidad
            // 
            this.edtCantidad.Location = new System.Drawing.Point(229, 214);
            this.edtCantidad.Name = "edtCantidad";
            this.edtCantidad.Size = new System.Drawing.Size(270, 20);
            this.edtCantidad.TabIndex = 34;
            this.edtCantidad.TextChanged += new System.EventHandler(this.edtCantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Seleccione para editar o eliminar";
            // 
            // GestionarCambioPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.edtCantidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridRepuesto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtRepuesto);
            this.Controls.Add(this.edtidCambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtServicio);
            this.Controls.Add(this.label3);
            this.Name = "GestionarCambioPiezas";
            this.Text = "GestionarCambioPiezas";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edtServicio, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtidCambio, 0);
            this.Controls.SetChildIndex(this.edtRepuesto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.dataGridRepuesto, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.edtCantidad, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtRepuesto;
        private System.Windows.Forms.TextBox edtidCambio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridRepuesto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.TextBox edtServicio;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox edtCantidad;
        private System.Windows.Forms.Label label1;
    }
}