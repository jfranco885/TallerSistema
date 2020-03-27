using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;
namespace TallSys
{
    public partial class AsignarMecanicos : ContenedorVentanas
    {
        String idEmpleado;
        public AsignarMecanicos()
        {
            InitializeComponent();
            dataGridEmpleados.DataSource = Utilidades.datasetLista("Empleados").Tables[0];
        }

        private void AsignarMecanicos_Load(object sender, EventArgs e)
        {

        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            idEmpleado = edtEmpleado.Text.Trim();
        }
    }
}
