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
            edtIdVehiculo.Enabled = false;

            
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

            cboxNave.DataSource = Utilidades.llenarComboBox("select idnave from nave");
            cboxNave.DisplayMember = "idnave";
            cboxNave.ValueMember = "idnave";






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

                    asignarMecanicos.Show();
                    }
                    else//si existe
                    {
                        MessageBox.Show("Este servicio no se ha creado");
                    }
                }
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtDescripcion))
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


                    String consulta = String.Format("EXEC insertarDetalleServicio '{0}','{1}','{2}','{3}','{4}'",idtipoServicio,idNave,descripcion,idEstado,idServicioEncabezado );
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                   

                    cargarTabla();
                    
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
    }//fin clase
}//fin proyec
