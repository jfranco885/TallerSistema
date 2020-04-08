namespace TallSys
{
    partial class MtoServicios
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
            this.edtDiag = new System.Windows.Forms.TextBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.cboxTipoServicio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtIdDetalleServ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtActivida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edtIdEncabezado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.edtTiempo = new System.Windows.Forms.TextBox();
            this.edtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtIdNaveServ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxNav = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // edtDiag
            // 
            this.edtDiag.Location = new System.Drawing.Point(475, 112);
            this.edtDiag.Multiline = true;
            this.edtDiag.Name = "edtDiag";
            this.edtDiag.Size = new System.Drawing.Size(251, 48);
            this.edtDiag.TabIndex = 50;
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(164, 238);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(223, 21);
            this.cboxEstado.TabIndex = 47;
            this.cboxEstado.Click += new System.EventHandler(this.eventocboxEstado);
            // 
            // cboxTipoServicio
            // 
            this.cboxTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoServicio.FormattingEnabled = true;
            this.cboxTipoServicio.Location = new System.Drawing.Point(164, 143);
            this.cboxTipoServicio.Name = "cboxTipoServicio";
            this.cboxTipoServicio.Size = new System.Drawing.Size(223, 21);
            this.cboxTipoServicio.TabIndex = 46;
            this.cboxTipoServicio.Click += new System.EventHandler(this.eventocboxTipo);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tipo Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Diagnóstico";
            // 
            // edtFecha
            // 
            this.edtFecha.Location = new System.Drawing.Point(95, 83);
            this.edtFecha.Name = "edtFecha";
            this.edtFecha.Size = new System.Drawing.Size(175, 20);
            this.edtFecha.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fecha";
            // 
            // edtIdDetalleServ
            // 
            this.edtIdDetalleServ.Location = new System.Drawing.Point(164, 112);
            this.edtIdDetalleServ.Name = "edtIdDetalleServ";
            this.edtIdDetalleServ.Size = new System.Drawing.Size(223, 20);
            this.edtIdDetalleServ.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "IdServiciodetalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tiempo Real Hr";
            // 
            // edtActivida
            // 
            this.edtActivida.Location = new System.Drawing.Point(476, 176);
            this.edtActivida.Multiline = true;
            this.edtActivida.Name = "edtActivida";
            this.edtActivida.Size = new System.Drawing.Size(251, 48);
            this.edtActivida.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Actividades";
            // 
            // edtIdEncabezado
            // 
            this.edtIdEncabezado.Location = new System.Drawing.Point(127, 53);
            this.edtIdEncabezado.Name = "edtIdEncabezado";
            this.edtIdEncabezado.Size = new System.Drawing.Size(115, 20);
            this.edtIdEncabezado.TabIndex = 58;
            this.edtIdEncabezado.TextChanged += new System.EventHandler(this.edtIdEncabezado_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "IdEncabezado Servicio";
            // 
            // edtTiempo
            // 
            this.edtTiempo.Location = new System.Drawing.Point(164, 266);
            this.edtTiempo.Name = "edtTiempo";
            this.edtTiempo.Size = new System.Drawing.Size(223, 20);
            this.edtTiempo.TabIndex = 59;
            this.edtTiempo.TextChanged += new System.EventHandler(this.edtTiempo_TextChanged);
            // 
            // edtDescripcion
            // 
            this.edtDescripcion.Location = new System.Drawing.Point(475, 238);
            this.edtDescripcion.Multiline = true;
            this.edtDescripcion.Name = "edtDescripcion";
            this.edtDescripcion.Size = new System.Drawing.Size(251, 48);
            this.edtDescripcion.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Descripción";
            // 
            // edtIdNaveServ
            // 
            this.edtIdNaveServ.Location = new System.Drawing.Point(164, 209);
            this.edtIdNaveServ.Name = "edtIdNaveServ";
            this.edtIdNaveServ.Size = new System.Drawing.Size(223, 20);
            this.edtIdNaveServ.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "IdNaveTipoServicio";
            // 
            // cboxNav
            // 
            this.cboxNav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNav.FormattingEnabled = true;
            this.cboxNav.Location = new System.Drawing.Point(164, 173);
            this.cboxNav.Name = "cboxNav";
            this.cboxNav.Size = new System.Drawing.Size(223, 21);
            this.cboxNav.TabIndex = 64;
            this.cboxNav.Click += new System.EventHandler(this.eventocboxNave);
            // 
            // MtoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.cboxNav);
            this.Controls.Add(this.edtIdNaveServ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.edtDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edtTiempo);
            this.Controls.Add(this.edtIdEncabezado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.edtActivida);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtDiag);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.cboxTipoServicio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtIdDetalleServ);
            this.Controls.Add(this.label2);
            this.Name = "MtoServicios";
            this.Text = "MtoServicios";
            this.Load += new System.EventHandler(this.MtoServicios_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtIdDetalleServ, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.edtFecha, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cboxTipoServicio, 0);
            this.Controls.SetChildIndex(this.cboxEstado, 0);
            this.Controls.SetChildIndex(this.edtDiag, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.edtActivida, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.edtIdEncabezado, 0);
            this.Controls.SetChildIndex(this.edtTiempo, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.edtDescripcion, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.edtIdNaveServ, 0);
            this.Controls.SetChildIndex(this.cboxNav, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox edtDiag;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.ComboBox cboxTipoServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtIdDetalleServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtActivida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtIdEncabezado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox edtTiempo;
        private System.Windows.Forms.TextBox edtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtIdNaveServ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxNav;
    }
}