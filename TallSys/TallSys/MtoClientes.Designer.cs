namespace TallSys
{
    partial class MtoClientes
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
            this.edtNombres = new System.Windows.Forms.TextBox();
            this.edtApellidos = new System.Windows.Forms.TextBox();
            this.edtDui = new System.Windows.Forms.TextBox();
            this.edtTelefono = new System.Windows.Forms.TextBox();
            this.edtCorreo = new System.Windows.Forms.TextBox();
            this.edtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(245, 82);
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
            // edtNombres
            // 
            this.edtNombres.Location = new System.Drawing.Point(233, 166);
            this.edtNombres.Name = "edtNombres";
            this.edtNombres.Size = new System.Drawing.Size(201, 20);
            this.edtNombres.TabIndex = 38;
            this.edtNombres.TextChanged += new System.EventHandler(this.edtNombres_TextChanged);
            // 
            // edtApellidos
            // 
            this.edtApellidos.Location = new System.Drawing.Point(233, 207);
            this.edtApellidos.Name = "edtApellidos";
            this.edtApellidos.Size = new System.Drawing.Size(201, 20);
            this.edtApellidos.TabIndex = 37;
            this.edtApellidos.TextChanged += new System.EventHandler(this.edtApellidos_TextChanged);
            // 
            // edtDui
            // 
            this.edtDui.Location = new System.Drawing.Point(233, 250);
            this.edtDui.Name = "edtDui";
            this.edtDui.Size = new System.Drawing.Size(201, 20);
            this.edtDui.TabIndex = 36;
            this.edtDui.TextChanged += new System.EventHandler(this.edtDui_TextChanged);
            // 
            // edtTelefono
            // 
            this.edtTelefono.Location = new System.Drawing.Point(515, 170);
            this.edtTelefono.Name = "edtTelefono";
            this.edtTelefono.Size = new System.Drawing.Size(201, 20);
            this.edtTelefono.TabIndex = 35;
            this.edtTelefono.TextChanged += new System.EventHandler(this.edtTelefono_TextChanged);
            // 
            // edtCorreo
            // 
            this.edtCorreo.Location = new System.Drawing.Point(514, 129);
            this.edtCorreo.Name = "edtCorreo";
            this.edtCorreo.Size = new System.Drawing.Size(201, 20);
            this.edtCorreo.TabIndex = 34;
            this.edtCorreo.TextChanged += new System.EventHandler(this.edtCorreo_TextChanged);
            // 
            // edtDireccion
            // 
            this.edtDireccion.Location = new System.Drawing.Point(514, 196);
            this.edtDireccion.Multiline = true;
            this.edtDireccion.Name = "edtDireccion";
            this.edtDireccion.Size = new System.Drawing.Size(201, 48);
            this.edtDireccion.TabIndex = 33;
            this.edtDireccion.TextChanged += new System.EventHandler(this.edtDireccion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Difección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "por DUI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código";
            // 
            // edtFecha
            // 
            this.edtFecha.Location = new System.Drawing.Point(515, 250);
            this.edtFecha.Name = "edtFecha";
            this.edtFecha.Size = new System.Drawing.Size(201, 20);
            this.edtFecha.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fecha";
            // 
            // edtId
            // 
            this.edtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtId.Location = new System.Drawing.Point(233, 128);
            this.edtId.Name = "edtId";
            this.edtId.Size = new System.Drawing.Size(201, 20);
            this.edtId.TabIndex = 41;
            // 
            // MtoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edtNombres);
            this.Controls.Add(this.edtApellidos);
            this.Controls.Add(this.edtDui);
            this.Controls.Add(this.edtTelefono);
            this.Controls.Add(this.edtCorreo);
            this.Controls.Add(this.edtDireccion);
            this.Controls.Add(this.edtFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MtoClientes";
            this.Text = "MtoClientes";
            this.Load += new System.EventHandler(this.MtoClientes_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.edtFecha, 0);
            this.Controls.SetChildIndex(this.edtDireccion, 0);
            this.Controls.SetChildIndex(this.edtCorreo, 0);
            this.Controls.SetChildIndex(this.edtTelefono, 0);
            this.Controls.SetChildIndex(this.edtDui, 0);
            this.Controls.SetChildIndex(this.edtApellidos, 0);
            this.Controls.SetChildIndex(this.edtNombres, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.edtId, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox edtNombres;
        private System.Windows.Forms.TextBox edtApellidos;
        private System.Windows.Forms.TextBox edtDui;
        private System.Windows.Forms.TextBox edtTelefono;
        private System.Windows.Forms.TextBox edtCorreo;
        private System.Windows.Forms.TextBox edtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtId;
    }
}