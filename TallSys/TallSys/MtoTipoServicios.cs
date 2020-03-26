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
using System.Globalization;
namespace TallSys
{
    public partial class MtoTipoServicios : ContenedorMantenimientos
    {
        String id, tipoServicio, precio, descripcion,tiempoEstablecido;
     //   Double precioDouble, tiempoDouble;
        public MtoTipoServicios()
        {
            InitializeComponent();
            tabla.DataSource = Utilidades.datasetLista("TipoServicio").Tables[0];
            edtFecha.Enabled = false;
            edtId.Enabled = false;
            desactivarControles();
        }

        private void MtoTipoServicios_Load(object sender, EventArgs e)
        {

        }

     
        public override void guardar()
        {

            //    System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            //   Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.ToString());

            // double i = double.Parse(n);
            /*     

                 NumberFormatInfo provider = new NumberFormatInfo();

                 provider.NumberDecimalSeparator = ". ";
                 //    provider.NumberGroupSeparator = ".";
     */


            // double i = Convert.ToDouble(n, provider);
            // NumberFormatInfo cultures = new CultureInfo("en-US", false).NumberFormat; 
          //  CultureInfo cultures = new CultureInfo("en-US");
          //  String n = "22222.50";
          //  decimal i = Decimal.Parse(n, cultures);
          //  i = i * Convert.ToDecimal(2.3);
          //  MessageBox.Show(i.ToString());
            


            /* CultureInfo  provider = new CultureInfo("en-US");
               i = Decimal.Parse(n, "de-DE", provider);

               // Displays: 
               //    '$6,032.51' converted to 6032.51.

       */
            if (validarCampo(edtServicio) | validarCampo(edtPrecio) | validarCampo(edtDescripcion) |
                validarCampo(edtTiempo))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                tipoServicio = edtServicio.Text.Trim();            
            
                descripcion = edtDescripcion.Text.Trim();            
                String consul = String.Format("select *from tipo_servicios where nombre_servicio='{0}'", tipoServicio);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarTipoServicio '{0}','{1}','{2}','{3}'", tipoServicio, edtPrecio.Text.Trim(), descripcion, edtTiempo.Text.Trim());
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");

                        desactivarControles();
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("TipoServicio").Tables[0];//actualizando tabla
                    }
                    catch (Exception errorGuardarC)
                    {
                        MessageBox.Show("Ha ocurrido un error" + errorGuardarC.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este Tipo de Servicio ya existe ya existe");
                }
            }


        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                try
                {
                    String edtbuscar = edtBuscar.Text.Trim();
                    DataSet dt;
                    String consul = String.Format("select *from tipo_servicios where idtipo_servicio='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        edtId.Text = (dt.Tables[0].Rows[0]["idtipo_servicio"].ToString().Trim());
                        edtServicio.Text = (dt.Tables[0].Rows[0]["nombre_servicio"].ToString().Trim());
                        edtPrecio.Text = (dt.Tables[0].Rows[0]["precio"].ToString().Trim());
                        edtDescripcion.Text = (dt.Tables[0].Rows[0]["descripcion"].ToString().Trim());
                        edtTiempo.Text = (dt.Tables[0].Rows[0]["tiempo_hr_establecido"].ToString().Trim());
                        edtFecha.Text = (dt.Tables[0].Rows[0]["fecha_creacion"].ToString().Trim());

                        activarControles();
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este tipo de servicio no existe");
                        limpiarCampos();
                        desactivarControles();
                    }
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }

            }

        }

      

        public override void eliminar()
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    Utilidades.eliminarRegistro("TipoServicio", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControles();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("TipoServicio").Tables[0];
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    

                    String consulta = String.Format("EXEC actualizarTipoServicio '{0}','{1}','{2}','{3}','{4}'",edtId.Text.Trim(), edtServicio.Text.Trim(),Convert.ToDecimal(edtPrecio.Text.Trim()), edtDescripcion.Text.Trim(), Convert.ToDecimal(edtTiempo.Text.Trim()));
                    Utilidades.Ejecutar(consulta);

                    MessageBox.Show("Se actualizaron los datos");
                    desactivarControles();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    limpiarCampos();
                    tabla.DataSource = Utilidades.datasetLista("TipoServicio").Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                }

            }
        }




        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            activarControles();
            limpiarCampos();
            edtServicio.Focus();
        }

        private void edtServicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtTiempo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        

        private void edtDescripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void limpiarCampos()
        {

            edtBuscar.Text = "";
            edtId.Text = "";
            edtServicio.Text = "";
            edtPrecio.Text = "";
            edtDescripcion.Text = "";
            edtTiempo.Text = "";
            edtFecha.Text = "";

        }
        private void desactivarControles()
        {
            
         
            edtServicio.Enabled = false;
            edtPrecio.Enabled = false;
            edtDescripcion.Enabled = false;
            edtTiempo.Enabled = false;
        }
        private void activarControles()
        {

    
            edtServicio.Enabled = true;
            edtPrecio.Enabled = true;
            edtDescripcion.Enabled = true;
            edtTiempo.Enabled = true;
        }
    }//fin clase
}//fin proyecto
