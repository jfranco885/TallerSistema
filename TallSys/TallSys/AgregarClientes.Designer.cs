namespace TallSys
{
    partial class AgregarClientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNombres = new System.Windows.Forms.TextBox();
            this.edtApellidos = new System.Windows.Forms.TextBox();
            this.edtDui = new System.Windows.Forms.TextBox();
            this.edtTelefono = new System.Windows.Forms.TextBox();
            this.edtCorreo = new System.Windows.Forms.TextBox();
            this.edtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(670, 10);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Agregar Clientes";
            // 
            // edtNombres
            // 
            this.edtNombres.Location = new System.Drawing.Point(144, 82);
            this.edtNombres.Name = "edtNombres";
            this.edtNombres.Size = new System.Drawing.Size(201, 20);
            this.edtNombres.TabIndex = 91;
            this.edtNombres.TextChanged += new System.EventHandler(this.edtNombres_TextChanged);
            // 
            // edtApellidos
            // 
            this.edtApellidos.Location = new System.Drawing.Point(144, 123);
            this.edtApellidos.Name = "edtApellidos";
            this.edtApellidos.Size = new System.Drawing.Size(201, 20);
            this.edtApellidos.TabIndex = 90;
            this.edtApellidos.TextChanged += new System.EventHandler(this.edtApellidos_TextChanged);
            // 
            // edtDui
            // 
            this.edtDui.Location = new System.Drawing.Point(144, 166);
            this.edtDui.Name = "edtDui";
            this.edtDui.Size = new System.Drawing.Size(201, 20);
            this.edtDui.TabIndex = 89;
            this.edtDui.TextChanged += new System.EventHandler(this.edtDui_TextChanged);
            // 
            // edtTelefono
            // 
            this.edtTelefono.Location = new System.Drawing.Point(430, 112);
            this.edtTelefono.Name = "edtTelefono";
            this.edtTelefono.Size = new System.Drawing.Size(201, 20);
            this.edtTelefono.TabIndex = 88;
            this.edtTelefono.TextChanged += new System.EventHandler(this.edtTelefono_TextChanged);
            // 
            // edtCorreo
            // 
            this.edtCorreo.Location = new System.Drawing.Point(429, 71);
            this.edtCorreo.Name = "edtCorreo";
            this.edtCorreo.Size = new System.Drawing.Size(201, 20);
            this.edtCorreo.TabIndex = 87;
            // 
            // edtDireccion
            // 
            this.edtDireccion.Location = new System.Drawing.Point(429, 138);
            this.edtDireccion.Multiline = true;
            this.edtDireccion.Name = "edtDireccion";
            this.edtDireccion.Size = new System.Drawing.Size(201, 48);
            this.edtDireccion.TabIndex = 86;
            this.edtDireccion.TextChanged += new System.EventHandler(this.edtDireccion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Apellidos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "DUI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Correo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Difección";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(9, 230);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowHeadersVisible = false;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(766, 118);
            this.dataGridClientes.TabIndex = 95;
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 359);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtNombres);
            this.Controls.Add(this.edtApellidos);
            this.Controls.Add(this.edtDui);
            this.Controls.Add(this.edtTelefono);
            this.Controls.Add(this.edtCorreo);
            this.Controls.Add(this.edtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "AgregarClientes";
            this.Text = "AgregarClientes";
            this.Load += new System.EventHandler(this.AgregarClientes_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.edtDireccion, 0);
            this.Controls.SetChildIndex(this.edtCorreo, 0);
            this.Controls.SetChildIndex(this.edtTelefono, 0);
            this.Controls.SetChildIndex(this.edtDui, 0);
            this.Controls.SetChildIndex(this.edtApellidos, 0);
            this.Controls.SetChildIndex(this.edtNombres, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridClientes, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNombres;
        private System.Windows.Forms.TextBox edtApellidos;
        private System.Windows.Forms.TextBox edtDui;
        private System.Windows.Forms.TextBox edtTelefono;
        private System.Windows.Forms.TextBox edtCorreo;
        private System.Windows.Forms.TextBox edtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridClientes;
    }
}