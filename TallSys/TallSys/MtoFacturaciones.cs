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
    public partial class MtoFacturaciones : ContenedorMantenimientos
    {
        public MtoFacturaciones()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = true;

            tabla.DataSource = Utilidades.datasetLista("listarDetalleFactura").Tables[0];
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!validarSoloNumeros(edtBuscar))
            {

            }
            else
            {
                String idDetalleFactura = edtBuscar.Text.Trim();
                //verificando si existe
                Boolean existe;
                String consultaExiste = String.Format("select * from factura_detalle where idfactura_detalle = '{0}'",idDetalleFactura);

                existe = Utilidades.Existe(consultaExiste);

                if (existe == true)
                {
                    DataSet dt;
                    dt = Utilidades.datasetConsultarProcedureConCadena("consultarDetalleFactura",idDetalleFactura);

                    txtNoFactura.Text = (dt.Tables[0].Rows[0]["idfactura_encabezado"].ToString().Trim());
                    txtidDetalleServicio.Text = (dt.Tables[0].Rows[0]["iddetalle_servicio"].ToString().Trim());
                    txtCantidad.Text = (dt.Tables[0].Rows[0]["cantidad"].ToString().Trim());
                    txtDescuento.Text = (dt.Tables[0].Rows[0]["descuento"].ToString().Trim());
                    txtSubtotal.Text = (dt.Tables[0].Rows[0]["subtotal"].ToString().Trim());
                    txtPrecio.Text = (dt.Tables[0].Rows[0]["precio"].ToString().Trim());
                    txtDetalleFactura.Text = (dt.Tables[0].Rows[0]["idfactura_detalle"].ToString().Trim());

                }
                else
                {
                    MessageBox.Show("Este id de detalle factura no existe");
                }


            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    Utilidades.eliminarRegistro("DetalleFactura", txtDetalleFactura.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();

                    tabla.DataSource = Utilidades.datasetLista("listarDetalleFactura").Tables[0];

                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }
           
        }
        private void limpiarCampos()
        {
            txtNoFactura.Text = "";
            txtidDetalleServicio.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            txtSubtotal.Text = "";
            txtPrecio.Text = "";
            txtDetalleFactura.Text = "";
        }
    }//fin clase
}//fin proyec

