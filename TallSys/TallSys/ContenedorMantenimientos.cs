using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallSys
{
    public partial class ContenedorMantenimientos : ContenedorVentanas
    {
        public ContenedorMantenimientos()
        {
            InitializeComponent();
        }

        public void ContenedorMantenimientos_Load(object sender, EventArgs e)
        {

        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();

        }

        public void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        public void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
           
            buscar();

        }

        private void edtBuscar_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin class
}//fin Tallsys
