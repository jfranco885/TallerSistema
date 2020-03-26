namespace TallSys
{
    partial class MtoUsuarios
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
            this.cboxRol = new System.Windows.Forms.ComboBox();
            this.edtUsuario = new System.Windows.Forms.TextBox();
            this.edtClave = new System.Windows.Forms.TextBox();
            this.edtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEmpleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            // 
            // cboxRol
            // 
            this.cboxRol.FormattingEnabled = true;
            this.cboxRol.Location = new System.Drawing.Point(390, 234);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(222, 21);
            this.cboxRol.TabIndex = 28;
            // 
            // edtUsuario
            // 
            this.edtUsuario.Location = new System.Drawing.Point(390, 160);
            this.edtUsuario.Name = "edtUsuario";
            this.edtUsuario.Size = new System.Drawing.Size(222, 20);
            this.edtUsuario.TabIndex = 26;
            // 
            // edtClave
            // 
            this.edtClave.Location = new System.Drawing.Point(390, 195);
            this.edtClave.Name = "edtClave";
            this.edtClave.Size = new System.Drawing.Size(222, 20);
            this.edtClave.TabIndex = 25;
            // 
            // edtId
            // 
            this.edtId.Location = new System.Drawing.Point(390, 118);
            this.edtId.Name = "edtId";
            this.edtId.Size = new System.Drawing.Size(222, 20);
            this.edtId.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código";
            // 
            // cboxEmpleado
            // 
            this.cboxEmpleado.FormattingEnabled = true;
            this.cboxEmpleado.Location = new System.Drawing.Point(390, 274);
            this.cboxEmpleado.Name = "cboxEmpleado";
            this.cboxEmpleado.Size = new System.Drawing.Size(222, 21);
            this.cboxEmpleado.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Empleado";
            // 
            // MtoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxRol);
            this.Controls.Add(this.edtUsuario);
            this.Controls.Add(this.edtClave);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MtoUsuarios";
            this.Text = "MtoUsuarios";
            this.Load += new System.EventHandler(this.MtoUsuarios_Load);
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
            this.Controls.SetChildIndex(this.edtId, 0);
            this.Controls.SetChildIndex(this.edtClave, 0);
            this.Controls.SetChildIndex(this.edtUsuario, 0);
            this.Controls.SetChildIndex(this.cboxRol, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboxEmpleado, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxRol;
        private System.Windows.Forms.TextBox edtUsuario;
        private System.Windows.Forms.TextBox edtClave;
        private System.Windows.Forms.TextBox edtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEmpleado;
        private System.Windows.Forms.Label label6;
    }
}