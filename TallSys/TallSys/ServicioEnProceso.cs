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
    public partial class txtIdServicio : ContenedorVentanas
    {
        public txtIdServicio()
        {
            InitializeComponent();
            
            edtCliente.Enabled = false;
            edtEstadoActual.Enabled = false;
            edtNave.Enabled = false;
            edtTiempoEstablecido.Enabled = false;
            edtTipoServicio.Enabled = false;
            edtDescripcion.Enabled = false;

            cboxEstadoNuevo.Text = edtEstadoActual.Text;
           
        }

        private void ServicioEnProceso_Load(object sender, EventArgs e)
        {
            cboxEstadoNuevo.DataSource = Utilidades.llenarComboBox("select idestado,estado from estado");
            cboxEstadoNuevo.DisplayMember = "estado";
            cboxEstadoNuevo.ValueMember = "idestado";
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            GestionarCambioPiezas gestionarCambioPiezas = new GestionarCambioPiezas();
            gestionarCambioPiezas.edtServicio.Text = txtServicio.Text.Trim();
            gestionarCambioPiezas.dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(txtServicio.Text.Trim())).Tables[0];
            gestionarCambioPiezas.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                String idDetalleServicio = txtServicio.Text;
                String descripcion = edtDescripcion.Text.Trim();
                String diagnostico=edtDiagnostico.Text.Trim();
                int estado =int.Parse(cboxEstadoNuevo.SelectedValue.ToString());
                String tiempoReal = edtTiempoReal.Text.Trim();

                if (tiempoReal == "")
                {
                    tiempoReal = "0";
                }
                String actividad = edtActividad.Text.Trim();
                int idnavetipo =int.Parse(edtIdTipoServicio.Text.Trim());
                int idEncabezadoServicio =int.Parse(txtEncabezado.Text.Trim());
            
                String consulta = String.Format("EXEC insertarDatosElMecanico '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", idDetalleServicio,descripcion,diagnostico,estado,tiempoReal,actividad,idnavetipo,idEncabezadoServicio);

                Utilidades.Ejecutar(consulta);



                //actualizando los datos en la vista

                
                edtTiempoReal.Text = tiempoReal;
                edtEstadoActual.Text = cboxEstadoNuevo.Text;
                
                MessageBox.Show("Se han guardado los datos");

              
               
               
            }
            catch (Exception errorGuardarC)
            {
                MessageBox.Show("Ha ocurrido un error" + errorGuardarC.Message);
            }
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(txtServicio.Text.Trim())).Tables[0];

        }
    }//fin clase
}//fin proyecto
