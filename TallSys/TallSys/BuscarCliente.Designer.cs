namespace TallSys
{
    partial class BuscarCliente
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
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.edtFiltrar = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDui = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(802, 10);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            this.txtUsuario.Text = "";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(12, 202);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowHeadersVisible = false;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(940, 234);
            this.dataGridClientes.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(238, 116);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Filtar por DUI";
            // 
            // edtFiltrar
            // 
            this.edtFiltrar.Location = new System.Drawing.Point(338, 116);
            this.edtFiltrar.Name = "edtFiltrar";
            this.edtFiltrar.Size = new System.Drawing.Size(204, 20);
            this.edtFiltrar.TabIndex = 9;
            this.edtFiltrar.TextChanged += new System.EventHandler(this.edtFiltrar_TextChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(652, 160);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbDui);
            this.groupBox2.Controls.Add(this.rdbNombre);
            this.groupBox2.Location = new System.Drawing.Point(241, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 45);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // rdbDui
            // 
            this.rdbDui.AutoSize = true;
            this.rdbDui.Location = new System.Drawing.Point(131, 19);
            this.rdbDui.Name = "rdbDui";
            this.rdbDui.Size = new System.Drawing.Size(90, 17);
            this.rdbDui.TabIndex = 43;
            this.rdbDui.Text = "Filtrar por DUI";
            this.rdbDui.UseVisualStyleBackColor = true;
            this.rdbDui.CheckedChanged += new System.EventHandler(this.rdbDui_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Checked = true;
            this.rdbNombre.Location = new System.Drawing.Point(6, 19);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(108, 17);
            this.rdbNombre.TabIndex = 42;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Filtrar por Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.edtFiltrar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridClientes, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.edtFiltrar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox edtFiltrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbDui;
        private System.Windows.Forms.RadioButton rdbNombre;
        public System.Windows.Forms.DataGridView dataGridClientes;
    }
}