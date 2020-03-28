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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServEjecutandose)).BeginInit();
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
            this.dataGridServEjecutandose.RowHeadersVisible = false;
            this.dataGridServEjecutandose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServEjecutandose.Size = new System.Drawing.Size(935, 265);
            this.dataGridServEjecutandose.TabIndex = 5;
            // 
            // ServiciosEjecutandose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 456);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServEjecutandose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtIdServicio;
        private System.Windows.Forms.DataGridView dataGridServEjecutandose;
    }
}