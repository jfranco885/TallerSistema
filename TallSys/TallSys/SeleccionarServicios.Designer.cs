namespace TallSys
{
    partial class SeleccionarServicios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(790, 11);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Size = new System.Drawing.Size(0, 20);
            this.txtUsuario.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(940, 223);
            this.dataGridView1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DUI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "id Cliente";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(59, 79);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 14;
            this.label.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(161, 166);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(232, 23);
            this.txtIdCliente.TabIndex = 13;
            // 
            // txtDui
            // 
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDui.Location = new System.Drawing.Point(161, 117);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(232, 23);
            this.txtDui.TabIndex = 12;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(161, 69);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(232, 23);
            this.txtCliente.TabIndex = 11;
            // 
            // SeleccionarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionarServicios";
            this.Text = "SeleccionarServicios";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtDui, 0);
            this.Controls.SetChildIndex(this.txtIdCliente, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label txtIdCliente;
        private System.Windows.Forms.Label txtDui;
        private System.Windows.Forms.Label txtCliente;
    }
}