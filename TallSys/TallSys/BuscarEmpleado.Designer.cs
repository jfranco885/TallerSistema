namespace TallSys
{
    partial class BuscarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridBuscar = new System.Windows.Forms.DataGridView();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDui = new System.Windows.Forms.RadioButton();
            this.edtFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Filtrar";
            // 
            // dataGridBuscar
            // 
            this.dataGridBuscar.AllowUserToAddRows = false;
            this.dataGridBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscar.Location = new System.Drawing.Point(9, 157);
            this.dataGridBuscar.Name = "dataGridBuscar";
            this.dataGridBuscar.ReadOnly = true;
            this.dataGridBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBuscar.Size = new System.Drawing.Size(850, 229);
            this.dataGridBuscar.TabIndex = 37;
            this.dataGridBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscar_CellContentClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDui);
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Location = new System.Drawing.Point(265, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 45);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
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
            // edtFiltrar
            // 
            this.edtFiltrar.Location = new System.Drawing.Point(271, 83);
            this.edtFiltrar.Name = "edtFiltrar";
            this.edtFiltrar.Size = new System.Drawing.Size(270, 20);
            this.edtFiltrar.TabIndex = 41;
            this.edtFiltrar.TextChanged += new System.EventHandler(this.edtBuscarPorNombre_TextChanged);
            // 
            // BuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edtFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridBuscar);
            this.Name = "BuscarEmpleado";
            this.Text = "BuscarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridBuscar;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDui;
        public System.Windows.Forms.TextBox edtFiltrar;
    }
}