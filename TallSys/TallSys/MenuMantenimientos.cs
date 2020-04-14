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
            mtoServicios.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MtoUsuarios mtoUsuarios = new MtoUsuarios();
           // mtoUsuarios.Show();
            mtoUsuarios.ShowDialog();
        }

        private void btnTipoServicio_Click(object sender, EventArgs e)
        {
            MtoTipoServicios mtoTipoServicios = new MtoTipoServicios();
            mtoTipoServicios.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MtoEmpleados mtoEmpleados = new MtoEmpleados();
            mtoEmpleados.ShowDialog();
        }

        private void btnNaves_Click(object sender, EventArgs e)
        {
            MtoNaves mtoNaves = new MtoNaves();
            mtoNaves.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MtoClientes mtoClientes = new MtoClientes();
            mtoClientes.ShowDialog();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            MtoEspecialidades mtoEspecialidades = new MtoEspecialidades();
            mtoEspecialidades.ShowDialog();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            MtoCargos mtoCargos = new MtoCargos();
            mtoCargos.ShowDialog();
        }

        private void btnEstadoServicio_Click(object sender, EventArgs e)
        {
            MtoEstadoServicios mtoEstadoServicios = new MtoEstadoServicios();
            mtoEstadoServicios.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            MtoFacturaciones mtoFacturaciones = new MtoFacturaciones();
            mtoFacturaciones.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MtoCambioPiezas mtoCambioPiezas = new MtoCambioPiezas();
            mtoCambioPiezas.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            MtoMarcas mtoMarcas = new MtoMarcas();
            mtoMarcas.ShowDialog();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            MtoModelos mtoModelos = new MtoModelos();
            mtoModelos.ShowDialog();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            MtoVehiculos mtoVehiculos = new MtoVehiculos();
            mtoVehiculos.ShowDialog();
        }

        private void btnMecAsig_Click(object sender, EventArgs e)
        {
            MtoAsignarMecanicos mtoAsignarMecanicos = new MtoAsignarMecanicos();
            mtoAsignarMecanicos.ShowDialog();
        }
    }
}
