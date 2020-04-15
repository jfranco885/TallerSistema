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
    public partial class BuscarFactura : ContenedorVentanas    {
        public BuscarFactura()
        {
            InitializeComponent();
            dataGridFacturas.DataSource = Utilidades.datasetLista("listarEncabezadoFactura").Tables[0];
        }

        private void edtidEncabezado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (!validarSoloNumeros(edtidEncabezado))
            {

            }
            else
            {
                
                
                String idEncabezadoFactura=edtidEncabezado.Text.Trim();

                //Verificando si existe
                Boolean existe;
                String consultaExiste = String.Format("select * from factura_encabezado where idfactura_encabezado= '{0}'",idEncabezadoFactura);
                existe = Utilidades.Existe(consultaExiste);

                if(existe == true)
                {
                    try
                    {

                        DataSet dtConsultaFactura;
                        String consultaFactura = String.Format("exec listarPorEncabezadoFactura '{0}'", idEncabezadoFactura);
                        dtConsultaFactura = Utilidades.Ejecutar(consultaFactura);


                        HacerFactura hacerFactura = new HacerFactura();
                        hacerFactura.reportViewer1.LocalReport.DataSources[0].Value = dtConsultaFactura.Tables[0];
                        hacerFactura.ShowDialog();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error al traer datos para la factura" + err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Esta factura no se ha generado");
                }
               



            }//fin validando campo vacio
        }//fin imprimir
    }//fin clase
}//fin proyect
