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
    public partial class SeleccionarServicios : ContenedorVentanas
    {
        private String idcliente;
        public SeleccionarServicios()
        {
            InitializeComponent();
            
        }

        private void SeleccionarServicios_Load(object sender, EventArgs e)
        {
            idcliente = Facturar.idCliente;
            dataGridServicios.DataSource = Utilidades.datasetConsultarProcedureConCadena("listarServiciosParaFacturar", idcliente).Tables[0];
        }

        private void EnviarDatos(object sender, DataGridViewCellEventArgs e)
        {
            txtEncabezado.Text = dataGridServicios.Rows[e.RowIndex].Cells["idEncabezado"].Value.ToString();
            txtIdServicio.Text = dataGridServicios.Rows[e.RowIndex].Cells["idServicio"].Value.ToString();
            txtCodigoTipoServ.Text = dataGridServicios.Rows[e.RowIndex].Cells["CodigoTipoServicio"].Value.ToString();
            txtTipoServicio.Text = dataGridServicios.Rows[e.RowIndex].Cells["Servicio"].Value.ToString();
            txtPrecio.Text = dataGridServicios.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtCantidad.Text = dataGridServicios.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();

            edtDescuento.Text = "0.0";


        }

        private void edtDescuento_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdServicio.Text))
            {
                MessageBox.Show("Debe seleccionar un servicio de la tabla");
            }else if (!validarSoloNumeros(edtDescuento))
            {
                
            }else if (Convert.ToDouble(txtPrecio.Text)* Convert.ToDouble(txtCantidad.Text)< Convert.ToDouble(edtDescuento.Text))
            {
                MessageBox.Show("Error, el descuento es mayor que la venta");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
