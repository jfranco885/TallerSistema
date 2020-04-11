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
    public partial class BuscarCliente : ContenedorVentanas
    {
        public BuscarCliente()
        {
            InitializeComponent();
            dataGridClientes.DataSource = Utilidades.datasetLista("listarClientes").Tables[0];

        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }

        private void edtFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt;
                String consulta;
                if (rdbNombre.Checked)
                {
                    consulta = String.Format("exec filtrarClientesPorNombre '{0}'", edtFiltrar.Text.Trim());
                }
                else
                {
                    consulta = String.Format("exec filtrarClientesPorDui '{0}'", edtFiltrar.Text.Trim());
                }
                // String consulta = String.Format("select * from empleados where nombres_empleado like ('%" + edtBuscarPorNombre.Text.Trim() + "%')");

                dt = Utilidades.Ejecutar(consulta);
                dataGridClientes.DataSource = dt.Tables[0];
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void rdbDui_CheckedChanged(object sender, EventArgs e)
        {
            edtFiltrar.Text = "";
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            edtFiltrar.Text = "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
