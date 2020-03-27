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
            this.dataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.edtEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(774, 10);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(629, 79);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 7;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mecanico Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asignar Mecánicos";
            // 
            // dataGridEmpleados
            // 
            this.dataGridEmpleados.AllowUserToAddRows = false;
            this.dataGridEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleados.Location = new System.Drawing.Point(12, 132);
            this.dataGridEmpleados.Name = "dataGridEmpleados";
            this.dataGridEmpleados.RowHeadersVisible = false;
            this.dataGridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpleados.Size = new System.Drawing.Size(941, 263);
            this.dataGridEmpleados.TabIndex = 96;
            // 
            // edtEmpleado
            // 
            this.edtEmpleado.Location = new System.Drawing.Point(342, 81);
            this.edtEmpleado.Name = "edtEmpleado";
            this.edtEmpleado.Size = new System.Drawing.Size(246, 20);
            this.edtEmpleado.TabIndex = 97;
            // 
            // AsignarMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 407);
            this.Controls.Add(this.edtEmpleado);
            this.Controls.Add(this.dataGridEmpleados);
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
            this.Controls.SetChildIndex(this.dataGridEmpleados, 0);
            this.Controls.SetChildIndex(this.edtEmpleado, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridEmpleados;
        private System.Windows.Forms.TextBox edtEmpleado;
    }
}