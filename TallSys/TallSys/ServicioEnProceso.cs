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
            edtIdTipoServNave.Enabled = false;

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
            gestionarCambioPiezas.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCombox(cboxEstadoNuevo))
            {

            }
            else { 
            if (!string.IsNullOrEmpty(edtTiempoReal.Text) & !validarSoloNumeros(edtTiempoReal))//Si no es nullo y a la vez no son numeros
            {

            }
            else
            {
                try
                {

                    String idDetalleServicio = txtServicio.Text;
                    String descripcion = edtDescripcion.Text.Trim();
                    String diagnostico = edtDiagnostico.Text.Trim();
                    int estado = int.Parse(cboxEstadoNuevo.SelectedValue.ToString());
                    String tiempoReal = edtTiempoReal.Text.Trim();

                    if (tiempoReal == "")
                    {
                        tiempoReal = "0";
                    }
                    String actividad = edtActividad.Text.Trim();
                    int idnavetipo = int.Parse(edtIdTipoServNave.Text.Trim());
                    int idEncabezadoServicio = int.Parse(txtEncabezado.Text.Trim());

                    String consulta = String.Format("EXEC insertarDatosElMecanico '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", idDetalleServicio, descripcion, diagnostico, estado, tiempoReal, actividad, idnavetipo, idEncabezadoServicio);

                    Utilidades.Ejecutar(consulta);



                    //actualizando los datos en la vista


                    edtTiempoReal.Text = tiempoReal;
                    edtEstadoActual.Text = cboxEstadoNuevo.Text;
                    errorProvider1.Clear();

                    MessageBox.Show("Se han guardado los datos");




                }
                catch (Exception errorGuardarC)
                {
                    MessageBox.Show("Ha ocurrido un error" + errorGuardarC.Message);
                }

                //Si se seleccionó terminar en el estado entonces dar de baja a empleados y liberar la nave
                if (cboxEstadoNuevo.Text.Trim() == "Terminado")
                {
                    try
                    {
                        //dando de baja a empleados
                        String consulta = String.Format("update detalle_emp_serv set estado=0 where iddetalle_servicio =" + txtServicio.Text.Trim());
                        Utilidades.Ejecutar(consulta);
                        //liberando la nave
                        String consultaNave = String.Format("update nave set estado='Disponible' where idnave =" + edtNave.Text.Trim());
                        Utilidades.Ejecutar(consultaNave);
                        MessageBox.Show("Se ha liberado la nave y los empleados");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error " + err.Message);
                    }
                }
            }

        }
    }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(txtServicio.Text.Trim())).Tables[0];

        }

        private void btnDardeBaja_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere dar de baja a los empleados asignados en este servicio?", "Dar de baja", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    String consulta = String.Format("update detalle_emp_serv set estado=0 where iddetalle_servicio ="+txtServicio.Text.Trim());
                    Utilidades.Ejecutar(consulta);

                    MessageBox.Show("Los empleados que habían sido asignados a este servicio ya están disponibles para otro.");
                }catch(Exception err)
                {
                    MessageBox.Show("Error "+err.Message);
                }
               

            }
        }

        private void eventocboxEstado(object sender, EventArgs e)
        {
            if (tieneItems(cboxEstadoNuevo) == false)
            {
                MessageBox.Show("No hay opciones de Estado");
            }
        }

        private void btnMecanicos_Click(object sender, EventArgs e)
        {
            AsignarMecanicos asignarMecanicos = new AsignarMecanicos();
            asignarMecanicos.txtIdServicio.Text = txtServicio.Text.Trim();
            asignarMecanicos.dataGridMecanicoAsignado.DataSource = Utilidades.datasetConsultarProcedure("listarMecanicosAsignados", Convert.ToInt16(txtServicio.Text.Trim())).Tables[0];

            asignarMecanicos.ShowDialog();
        }
    }//fin clase
}//fin proyecto
