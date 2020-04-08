namespace TallSys
{
    partial class ServiciosEjecutandose
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
            this.btnGestionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtIdServicio = new System.Windows.Forms.TextBox();
            this.dataGridServEjecutandose = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMisServicios = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServEjecutandose)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(481, 93);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(142, 23);
            this.btnGestionar.TabIndex = 2;
            this.btnGestionar.Text = "Gestionar Servicio";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IdServicio";
            // 
            // edtIdServicio
            // 
            this.edtIdServicio.Location = new System.Drawing.Point(306, 93);
            this.edtIdServicio.Name = "edtIdServicio";
            this.edtIdServicio.Size = new System.Drawing.Size(160, 20);
            this.edtIdServicio.TabIndex = 4;
            this.edtIdServicio.TextChanged += new System.EventHandler(this.edtIdServicio_TextChanged);
            // 
            // dataGridServEjecutandose
            // 
            this.dataGridServEjecutandose.AllowUserToAddRows = false;
            this.dataGridServEjecutandose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServEjecutandose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServEjecutandose.Location = new System.Drawing.Point(0, 155);
            this.dataGridServEjecutandose.Name = "dataGridServEjecutandose";
            this.dataGridServEjecutandose.ReadOnly = true;
            this.dataGridServEjecutandose.RowHeadersVisible = false;
            this.dataGridServEjecutandose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServEjecutandose.Size = new System.Drawing.Size(935, 265);
            this.dataGridServEjecutandose.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 126);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMisServicios);
            this.groupBox2.Controls.Add(this.rdbTodos);
            this.groupBox2.Location = new System.Drawing.Point(27, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rdbMisServicios
            // 
            this.rdbMisServicios.AutoSize = true;
            this.rdbMisServicios.Location = new System.Drawing.Point(106, 19);
            this.rdbMisServicios.Name = "rdbMisServicios";
            this.rdbMisServicios.Size = new System.Drawing.Size(87, 17);
            this.rdbMisServicios.TabIndex = 1;
            this.rdbMisServicios.Text = "Mis Servicios";
            this.rdbMisServicios.UseVisualStyleBackColor = true;
            this.rdbMisServicios.CheckedChanged += new System.EventHandler(this.rdbMisServicios_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(6, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // ServiciosEjecutandose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridServEjecutandose);
            this.Controls.Add(this.edtIdServicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGestionar);
            this.Name = "ServiciosEjecutandose";
            this.Text = "ServiciosEjecutandose";
            this.Load += new System.EventHandler(this.ServiciosEjecutandose_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnGestionar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtIdServicio, 0);
            this.Controls.SetChildIndex(this.dataGridServEjecutandose, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServEjecutandose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtIdServicio;
        private System.Windows.Forms.DataGridView dataGridServEjecutandose;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMisServicios;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}