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
    public partial class BuscarEmpleado : Form
    {
        public BuscarEmpleado()
        {
            InitializeComponent();
        }

        private void dataGridBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MtoUsuarios mtoUsuarios = new MtoUsuarios();
            String nombres= dataGridBuscar.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            String apellidos= dataGridBuscar.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            String nombreCompleto = nombres + " " + apellidos;
            mtoUsuarios.edtNombreEmpleado.Text = nombreCompleto;
            mtoUsuarios.edtIdEmpleado.Text = dataGridBuscar.Rows[e.RowIndex].Cells["Código"].Value.ToString();

            
            // MessageBox.Show(dataGridBuscar.Rows[e.RowIndex].Cells["Nombres"].Value.ToString());
            mtoUsuarios.activarControlesE();
            mtoUsuarios.btnGuardar.Enabled = true;
            
           // this.Close();
            this.Hide();//Oculto de lo contrario sale una ventana anterior
            mtoUsuarios.ShowDialog();
        }

       

        private void edtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dt;
                String consulta;
                if (rdbNombre.Checked)
                {
                    consulta = String.Format("exec filtrarEmpleadosPorNombre '{0}'", edtFiltrar.Text.Trim());
                }
                else
                {
                    consulta = String.Format("exec filtrarEmpleadosPorDui '{0}'", edtFiltrar.Text.Trim());
                }
                // String consulta = String.Format("select * from empleados where nombres_empleado like ('%" + edtBuscarPorNombre.Text.Trim() + "%')");
               
                dt = Utilidades.Ejecutar(consulta);
                dataGridBuscar.DataSource = dt.Tables[0];
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            edtFiltrar.Text = "";
            edtFiltrar.Focus();
        }

        private void rdbDui_CheckedChanged(object sender, EventArgs e)
        {
            edtFiltrar.Text = "";
            edtFiltrar.Focus();
        }
    }
}
