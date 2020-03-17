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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testablecido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoDiag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(481, 93);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(75, 23);
            this.btnGestionar.TabIndex = 2;
            this.btnGestionar.Text = "Gestionar";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdServicio,
            this.Estado,
            this.Cliente,
            this.TipoServicio,
            this.Testablecido,
            this.Nave,
            this.HoraInicio,
            this.TiempoDiag});
            this.dataGridView1.Location = new System.Drawing.Point(0, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 265);
            this.dataGridView1.TabIndex = 5;
            // 
            // IdServicio
            // 
            this.IdServicio.HeaderText = "IdServicio";
            this.IdServicio.Name = "IdServicio";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // TipoServicio
            // 
            this.TipoServicio.HeaderText = "Tipo Servicio";
            this.TipoServicio.Name = "TipoServicio";
            // 
            // Testablecido
            // 
            this.Testablecido.HeaderText = "Tiempo Establecido";
            this.Testablecido.Name = "Testablecido";
            // 
            // Nave
            // 
            this.Nave.HeaderText = "Nave";
            this.Nave.Name = "Nave";
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // TiempoDiag
            // 
            this.TiempoDiag.HeaderText = "TiempoDiagnosticado";
            this.TiempoDiag.Name = "TiempoDiag";
            // 
            // ServiciosEjecutandose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 456);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtIdServicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testablecido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nave;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoDiag;
    }
}