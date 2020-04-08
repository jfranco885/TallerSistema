namespace TallSys
{
    partial class MtoAsignarMecanicos
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
            this.label6 = new System.Windows.Forms.Label();
            this.edtIdServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtIdAsignacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(239, 79);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Estado";
            // 
            // edtIdServicio
            // 
            this.edtIdServicio.Location = new System.Drawing.Point(36, 103);
            this.edtIdServicio.Name = "edtIdServicio";
            this.edtIdServicio.Size = new System.Drawing.Size(161, 20);
            this.edtIdServicio.TabIndex = 31;
            this.edtIdServicio.TextChanged += new System.EventHandler(this.edtIdServicio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "id Empleado";
            // 
            // edtIdEmpleado
            // 
            this.edtIdEmpleado.Location = new System.Drawing.Point(368, 184);
            this.edtIdEmpleado.Name = "edtIdEmpleado";
            this.edtIdEmpleado.Size = new System.Drawing.Size(270, 20);
            this.edtIdEmpleado.TabIndex = 29;
            this.edtIdEmpleado.TextChanged += new System.EventHandler(this.edtIdEmpleado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Id Detalle Servicio";
            // 
            // edtIdAsignacion
            // 
            this.edtIdAsignacion.Location = new System.Drawing.Point(368, 132);
            this.edtIdAsignacion.Name = "edtIdAsignacion";
            this.edtIdAsignacion.Size = new System.Drawing.Size(270, 20);
            this.edtIdAsignacion.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "id Asignación";
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(372, 234);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(266, 21);
            this.cboxEstado.TabIndex = 34;
            this.cboxEstado.Click += new System.EventHandler(this.eventoEstado);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "id Asignación";
            // 
            // MtoAsignarMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtIdServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtIdEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtIdAsignacion);
            this.Controls.Add(this.label2);
            this.Name = "MtoAsignarMecanicos";
            this.Text = "MtoAsignarMecanicos";
            this.Load += new System.EventHandler(this.MtoAsignarMecanicos_Load);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtIdAsignacion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edtIdEmpleado, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.edtIdServicio, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboxEstado, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtIdServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtIdEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtIdAsignacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label5;
    }
}