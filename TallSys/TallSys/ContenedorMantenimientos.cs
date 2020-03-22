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

        private void ContenedorMantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edtBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }//fin class
}//fin Tallsys
