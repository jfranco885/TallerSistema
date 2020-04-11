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
    public partial class AgregarServicios : ContenedorVentanas
    {
        public AgregarServicios()
        {
            InitializeComponent();
            edtIdServicioEncabezado.Enabled = false;
            edtPlacaVehiculo.Enabled = false;
            btnGuardar.Enabled = false;
            edtNombreCliente.Enabled = false;
            edtDui.Enabled = false;
            edtAsignacion.Enabled = false;

            
            dataGridServiciosAgregados.DataSource = Utilidades.datasetConsultarProcedure("listarServiciosPorencabezados", 0).Tables[0];
        }
        private void AgregarServicios_Load(object sender, EventArgs e)
        {

            cboxEstado.DataSource = Utilidades.llenarComboBox("select idestado,estado from estado");
            cboxEstado.DisplayMember = "estado";
            cboxEstado.ValueMember = "idestado";

            cboxTipoServicio.DataSource = Utilidades.llenarComboBox("select idtipo_servicio,nombre_servicio from tipo_servicios");
            cboxTipoServicio.DisplayMember = "nombre_servicio";
            cboxTipoServicio.ValueMember = "idtipo_servicio";


            cargarComboxNave();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAsignarMecanico_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtidServicioDetalle))
            {
                

            }
            else
            {
                 
                    Boolean existe;
                    String iddetalleSer = edtidServicioDetalle.Text.Trim();
                    String consul = String.Format("select *from detalle_servicios where iddetalle_servicio='{0}'", iddetalleSer);
                    existe = Utilidades.Existe(consul);

                    if (existe == true)
                    {

                        AsignarMecanicos asignarMecanicos = new AsignarMecanicos();
                        asignarMecanicos.txtIdServicio.Text = edtidServicioDetalle.Text.Trim();
                    asignarMecanicos.dataGridMecanicoAsignado.DataSource = Utilidades.datasetConsultarProcedure("listarMecanicosAsignados", Convert.ToInt16(edtidServicioDetalle.Text.Trim())).Tables[0];
                  
                    asignarMecanicos.ShowDialog();
                }
                    else//si existe
                    {
                        MessageBox.Show("Este servicio no se ha creado");
                    }
                }
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

           
            if (validarCombox(cboxTipoServicio)|!validarSoloNumeros(edtCantidad)|validarCombox(cboxNave)|validarCombox(cboxEstado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
               
               
                    try
                    {
                     
                    int idtipoServicio = Convert.ToInt16(cboxTipoServicio.SelectedValue);
                    int idNave = Convert.ToInt16(cboxNave.SelectedValue);
                    String descripcion = edtDescripcion.Text.Trim();
                    int idEstado = Convert.ToInt16(cboxEstado.SelectedValue);
                    String idServicioEncabezado = edtIdServicioEncabezado.Text.Trim();
                    int cantidad = Convert.ToInt16(edtCantidad.Text.Trim());




                    String consulta = String.Format("EXEC insertarDetalleServicio '{0}','{1}','{2}','{3}','{4}','{5}'", idtipoServicio,idNave,descripcion,idEstado,idServicioEncabezado,cantidad );
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                   

                    cargarTabla();
                    cargarComboxNave();

                    limpiarCampos();

                    int idencabezado = Convert.ToInt32((edtIdServicioEncabezado.Text.ToString()));
                    dataGridServiciosAgregados.DataSource = Utilidades.datasetConsultarProcedure("listarServiciosPorencabezados", idencabezado).Tables[0];

                }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ha ocurrido un error" + er.Message);
                    }

                }
               
            }

        private void cargarTabla()
        {
            int idServEnc = Convert.ToInt16(edtIdServicioEncabezado.Text);
            dataGridServiciosAgregados.DataSource = Utilidades.datasetConsultarProcedure("listarServiciosPorencabezados", idServEnc).Tables[0];

        }


        private void limpiarCampos()
        {
            edtDescripcion.Text = "";
        }
      
           
        

        private void edtDescripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

       

        private void edtidServicioDetalle_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
           
            
            edtPlacaVehiculo.Enabled = true;
            edtDui.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            if (validarCampo(edtIdServicioEncabezado) | validarCampo(edtDui) | validarCampo(edtPlacaVehiculo))
            {

            }//fin validando ampos
            else
            {

                Boolean existeEncabezado;
                String idencabezado = edtIdServicioEncabezado.Text.Trim();
                String consul = String.Format("select *from encabezado_servicio where idencabezado_servicio='{0}'", idencabezado);
                existeEncabezado = Utilidades.Existe(consul);

                if (existeEncabezado == true)
                {
                    //Validando si existe el vehiculo
                    Boolean existeVehiculo;
                    String placa = edtPlacaVehiculo.Text.Trim();
                    String consula = String.Format("select *from vehiculo where placa='{0}'", placa);
                    existeVehiculo = Utilidades.Existe(consula);
                    if (existeVehiculo == true)
                    {
                        //validando si existe el cliente
                        Boolean existeCliente;
                        String dui = edtDui.Text.Trim();
                        String consultar = String.Format("select *from clientes where dui='{0}'", dui);
                        existeCliente = Utilidades.Existe(consultar);
                        if (existeCliente == true)
                        {
                            //hacer la inserción
                            try
                            {
                                String iddetalleVehiculo = edtAsignacion.Text.Trim();
                                
                                String cons = String.Format("exec CambiarClienteVehiculo '{0}','{1}','{2}'", iddetalleVehiculo, dui, placa);
                                Utilidades.Ejecutar(cons);
                                MessageBox.Show("Se Modificaron los datos");

                            }
                            catch(Exception err)
                            {
                                MessageBox.Show("Hay un error"+err.Message);
                            }

                            btnGuardar.Enabled = false;
                            edtIdServicioEncabezado.Enabled = false;
                            edtPlacaVehiculo.Enabled = false;
                            edtNombreCliente.Enabled = false;
                            edtDui.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se modificó. Este Cliente no existe");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se modificó. Este vehículo no existe");
                    }


                    }else
                {
                    MessageBox.Show("No se modificó. Este encabezado de servicio no existe");
                }

                //Rellenando nuevamente los campos

                try
                {
                    String consulta = String.Format("exec listarEncabezadoServicio '{0}'", edtIdServicioEncabezado.Text.Trim());
                    DataSet dt = Utilidades.Ejecutar(consulta);

                    edtPlacaVehiculo.Text = (dt.Tables[0].Rows[0]["placa"].ToString().Trim());
                    edtNombreCliente.Text = (dt.Tables[0].Rows[0]["nombre"].ToString().Trim());
                    edtDui.Text = (dt.Tables[0].Rows[0]["dui"].ToString().Trim());
                    edtAsignacion.Text = (dt.Tables[0].Rows[0]["idasignacion"].ToString().Trim());


                }
                catch (Exception err)
                {
                    MessageBox.Show("Error" + err.Message);
                }
                
              


            }//fin validadndo campos

        }//fin guardar

        private void edtPlacaVehiculo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtDui_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        
        private void evento(object sender, EventArgs e)
        {
            if (tieneItems(cboxNave)==false)
            {
                MessageBox.Show("No hay nave disponible");
            }
           
        }

        private void eventoTipo(object sender, EventArgs e)
        {
            if (tieneItems(cboxTipoServicio) == false)
            {
                MessageBox.Show("No hay opciones de tipo de servicio");
            }
        }

        private void eventoEstado(object sender, EventArgs e)
        {
            if (tieneItems(cboxEstado) == false)
            {
                MessageBox.Show("No hay opciones de estado");
            }
        }
        private void cargarComboxNave()
        {
           
            cboxNave.DataSource = Utilidades.llenarComboBox("select idnave from nave where estado ='Disponible'");
            cboxNave.DisplayMember = "idnave";
            cboxNave.ValueMember = "idnave";


        }

        private void edtCantidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyec
