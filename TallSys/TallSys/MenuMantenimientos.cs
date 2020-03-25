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
    public partial class MenuMantenimientos : ContenedorVentanas
    {
        public MenuMantenimientos()
        {
            InitializeComponent();
        }

        private void MenuMantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarServ_Click(object sender, EventArgs e)
        {
            MtoServicios mtoServicios = new MtoServicios();
            mtoServicios.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MtoUsuarios mtoUsuarios = new MtoUsuarios();
            mtoUsuarios.Show();
        }

        private void btnTipoServicio_Click(object sender, EventArgs e)
        {
            MtoTipoServicios mtoTipoServicios = new MtoTipoServicios();
            mtoTipoServicios.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MtoEmpleados mtoEmpleados = new MtoEmpleados();
            mtoEmpleados.Show();
        }

        private void btnNaves_Click(object sender, EventArgs e)
        {
            MtoNaves mtoNaves = new MtoNaves();
            mtoNaves.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MtoClientes mtoClientes = new MtoClientes();
            mtoClientes.Show();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            MtoEspecialidades mtoEspecialidades = new MtoEspecialidades();
            mtoEspecialidades.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            MtoCargos mtoCargos = new MtoCargos();
            mtoCargos.Show();
        }

        private void btnEstadoServicio_Click(object sender, EventArgs e)
        {
            MtoEstadoServicios mtoEstadoServicios = new MtoEstadoServicios();
            mtoEstadoServicios.Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            MtoFacturacion mtoFacturacion = new MtoFacturacion();
            mtoFacturacion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MtoCambioPiezas mtoCambioPiezas = new MtoCambioPiezas();
            mtoCambioPiezas.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            MtoMarcas mtoMarcas = new MtoMarcas();
            mtoMarcas.Show();
        }
    }
}
