namespace TallSys
{
    partial class MtoModelos
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
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.edtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarModel = new System.Windows.Forms.Label();
            this.btnCrearMarca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(247, 79);
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
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(373, 209);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(227, 21);
            this.cboxMarca.TabIndex = 18;
            this.cboxMarca.Click += new System.EventHandler(this.eventoMarca);
            // 
            // edtId
            // 
            this.edtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtId.Location = new System.Drawing.Point(373, 132);
            this.edtId.Name = "edtId";
            this.edtId.Size = new System.Drawing.Size(227, 20);
            this.edtId.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "idModelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Modelo";
            // 
            // edtModelo
            // 
            this.edtModelo.Location = new System.Drawing.Point(373, 172);
            this.edtModelo.Name = "edtModelo";
            this.edtModelo.Size = new System.Drawing.Size(227, 20);
            this.edtModelo.TabIndex = 21;
            this.edtModelo.TextChanged += new System.EventHandler(this.edtModelo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Marca";
            // 
            // txtBuscarModel
            // 
            this.txtBuscarModel.AutoSize = true;
            this.txtBuscarModel.Location = new System.Drawing.Point(284, 79);
            this.txtBuscarModel.Name = "txtBuscarModel";
            this.txtBuscarModel.Size = new System.Drawing.Size(59, 13);
            this.txtBuscarModel.TabIndex = 24;
            this.txtBuscarModel.Text = "por modelo";
            // 
            // btnCrearMarca
            // 
            this.btnCrearMarca.Location = new System.Drawing.Point(606, 204);
            this.btnCrearMarca.Name = "btnCrearMarca";
            this.btnCrearMarca.Size = new System.Drawing.Size(75, 29);
            this.btnCrearMarca.TabIndex = 42;
            this.btnCrearMarca.Text = "Crear";
            this.btnCrearMarca.UseVisualStyleBackColor = true;
            this.btnCrearMarca.Click += new System.EventHandler(this.btnCrearMarca_Click);
            // 
            // MtoModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 492);
            this.Controls.Add(this.btnCrearMarca);
            this.Controls.Add(this.txtBuscarModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.cboxMarca);
            this.Name = "MtoModelos";
            this.Text = "MtoModelos";
            this.Load += new System.EventHandler(this.MtoModelos_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.edtBuscar, 0);
            this.Controls.SetChildIndex(this.cboxMarca, 0);
            this.Controls.SetChildIndex(this.edtId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.edtModelo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtBuscarModel, 0);
            this.Controls.SetChildIndex(this.btnCrearMarca, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.TextBox edtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtModelo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label txtBuscarModel;
        private System.Windows.Forms.Button btnCrearMarca;
    }
}