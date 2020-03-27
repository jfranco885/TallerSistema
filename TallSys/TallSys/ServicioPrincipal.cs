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
    public partial class ServicioPrincipal : ContenedorVentanas
    {
        public ServicioPrincipal()
        {
            InitializeComponent();
        }

        private void ServicioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            AgregarClientes agregarClientes = new AgregarClientes();
            agregarClientes.Show();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            AgregarVehiculos agregarVehiculos = new AgregarVehiculos();
            agregarVehiculos.Show();
        }
    }
}
