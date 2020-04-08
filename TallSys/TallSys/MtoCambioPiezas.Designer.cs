namespace TallSys
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
            this.edtidCambio = new System.Windows.Forms.TextBox();
            this.edtRepuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtIdServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(194, 79);
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
            // txtUsuario
            // 
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            this.txtUsuario.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código Cambio";
            // 
            // edtidCambio
            // 
            this.edtidCambio.Location = new System.Drawing.Point(368, 145);
            this.edtidCambio.Name = "edtidCambio";
            this.edtidCambio.Size = new System.Drawing.Size(270, 20);
            this.edtidCambio.TabIndex = 17;
            // 
            // edtRepuesto
            // 
            this.edtRepuesto.Location = new System.Drawing.Point(368, 197);
            this.edtRepuesto.Name = "edtRepuesto";
            this.edtRepuesto.Size = new System.Drawing.Size(270, 20);
            this.edtRepuesto.TabIndex = 19;
            this.edtRepuesto.TextChanged += new System.EventHandler(this.edtRepuesto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id Detalle Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre Repuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "por id Cambio Pieza";
            // 
            // edtIdServicio
            // 
            this.edtIdServicio.Location = new System.Drawing.Point(36, 116);
            this.edtIdServicio.Name = "edtIdServicio";
            this.edtIdServicio.Size = new System.Drawing.Size(161, 20);
            this.edtIdServicio.TabIndex = 23;
            this.edtIdServicio.TextChanged += new System.EventHandler(this.edtIdServicio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cantidad";
            // 
            // edtCantidad
            // 
            this.edtCantidad.Location = new System.Drawing.Point(368, 249);
            this.edtCantidad.Name = "edtCantidad";
            this.edtCantidad.Size = new System.Drawing.Size(270, 20);
            this.edtCantidad.TabIndex = 24;
            this.edtCantidad.TextChanged += new System.EventHandler(this.edtCantidad_TextChanged);
            // 
            // MtoCambioPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtCantidad);
            this.Controls.Add(this.edtIdServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtRepuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtidCambio);
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
            this.Controls.SetChildIndex(this.edtidCambio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edtRepuesto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.edtIdServicio, 0);
            this.Controls.SetChildIndex(this.edtCantidad, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtidCambio;
        private System.Windows.Forms.TextBox edtRepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtIdServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtCantidad;
    }
}