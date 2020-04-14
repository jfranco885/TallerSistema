namespace TallSys
{
    partial class BuscarFactura
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
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.edtidEncabezado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            this.txtUsuario.Text = "";
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.AllowUserToAddRows = false;
            this.dataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(16, 231);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.ReadOnly = true;
            this.dataGridFacturas.RowHeadersVisible = false;
            this.dataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacturas.Size = new System.Drawing.Size(892, 207);
            this.dataGridFacturas.TabIndex = 18;
            // 
            // edtidEncabezado
            // 
            this.edtidEncabezado.Location = new System.Drawing.Point(297, 100);
            this.edtidEncabezado.Name = "edtidEncabezado";
            this.edtidEncabezado.Size = new System.Drawing.Size(222, 20);
            this.edtidEncabezado.TabIndex = 20;
            this.edtidEncabezado.TextChanged += new System.EventHandler(this.edtidEncabezado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "id Encabezado Factura";
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.Location = new System.Drawing.Point(534, 92);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(75, 35);
            this.btnImprimirFactura.TabIndex = 21;
            this.btnImprimirFactura.Text = "Imprimir Factura";
            this.btnImprimirFactura.UseVisualStyleBackColor = true;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // BuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.edtidEncabezado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridFacturas);
            this.Name = "BuscarFactura";
            this.Text = "BuscarFactura";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridFacturas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtidEncabezado, 0);
            this.Controls.SetChildIndex(this.btnImprimirFactura, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridFacturas;
        public System.Windows.Forms.TextBox edtidEncabezado;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimirFactura;
    }
}