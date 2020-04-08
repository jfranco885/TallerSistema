namespace TallSys
{
    partial class AsignarMecanicos
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
            this.btnElegir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMecSinAsignar = new System.Windows.Forms.DataGridView();
            this.edtEmpleado = new System.Windows.Forms.TextBox();
            this.dataGridMecanicoAsignado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdServicio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMecSinAsignar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMecanicoAsignado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(774, 10);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(529, 82);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 7;
            this.btnElegir.Text = "Asignar";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mecanico Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asignar Mecánicos";
            // 
            // dataGridMecSinAsignar
            // 
            this.dataGridMecSinAsignar.AllowUserToAddRows = false;
            this.dataGridMecSinAsignar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMecSinAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMecSinAsignar.Location = new System.Drawing.Point(468, 132);
            this.dataGridMecSinAsignar.Name = "dataGridMecSinAsignar";
            this.dataGridMecSinAsignar.ReadOnly = true;
            this.dataGridMecSinAsignar.RowHeadersVisible = false;
            this.dataGridMecSinAsignar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMecSinAsignar.Size = new System.Drawing.Size(485, 263);
            this.dataGridMecSinAsignar.TabIndex = 96;
            // 
            // edtEmpleado
            // 
            this.edtEmpleado.Location = new System.Drawing.Point(260, 84);
            this.edtEmpleado.Name = "edtEmpleado";
            this.edtEmpleado.Size = new System.Drawing.Size(246, 20);
            this.edtEmpleado.TabIndex = 97;
            this.edtEmpleado.TextChanged += new System.EventHandler(this.edtEmpleado_TextChanged);
            // 
            // dataGridMecanicoAsignado
            // 
            this.dataGridMecanicoAsignado.AllowUserToAddRows = false;
            this.dataGridMecanicoAsignado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMecanicoAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMecanicoAsignado.Location = new System.Drawing.Point(25, 132);
            this.dataGridMecanicoAsignado.Name = "dataGridMecanicoAsignado";
            this.dataGridMecanicoAsignado.ReadOnly = true;
            this.dataGridMecanicoAsignado.RowHeadersVisible = false;
            this.dataGridMecanicoAsignado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMecanicoAsignado.Size = new System.Drawing.Size(437, 263);
            this.dataGridMecanicoAsignado.TabIndex = 99;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Se envía como estado uno automáticamente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.AutoSize = true;
            this.txtIdServicio.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdServicio.Location = new System.Drawing.Point(76, 53);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(53, 13);
            this.txtIdServicio.TabIndex = 101;
            this.txtIdServicio.Text = "idServicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Id Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Mecánicos Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Mecánicos que han sido asignados";
            // 
            // AsignarMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridMecanicoAsignado);
            this.Controls.Add(this.edtEmpleado);
            this.Controls.Add(this.dataGridMecSinAsignar);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsignarMecanicos";
            this.Text = "AsignarMecanicos";
            this.Load += new System.EventHandler(this.AsignarMecanicos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnElegir, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridMecSinAsignar, 0);
            this.Controls.SetChildIndex(this.edtEmpleado, 0);
            this.Controls.SetChildIndex(this.dataGridMecanicoAsignado, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txtIdServicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMecSinAsignar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMecanicoAsignado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMecSinAsignar;
        private System.Windows.Forms.TextBox edtEmpleado;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label txtIdServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridMecanicoAsignado;
    }
}