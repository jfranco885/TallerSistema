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
    public partial class MtoAsignarMecanicos : ContenedorMantenimientos
    {
        String empleadoActual;
        public MtoAsignarMecanicos()
        {
            InitializeComponent();
            desactivarControles();
            edtIdAsignacion.Enabled = false;
            cargarTabla();
            empleadoActual = edtIdEmpleado.Text.Trim();
        }
        private void MtoAsignarMecanicos_Load(object sender, EventArgs e)
        {
            
            cboxEstado.Items.Add("Disponible");
            cboxEstado.Items.Add("En Servicio");
        }
        public override void guardar()
        {
           // MessageBox.Show(cboxEstado.Text);
            if (validarCampo(edtIdServicio) | validarCampo(edtIdEmpleado)|validarCombox(cboxEstado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String idServicio = edtIdServicio.Text.Trim();
                String consul = String.Format("select *from detalle_servicios where iddetalle_servicio='{0}'", idServicio);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    //Verificando si existe el empleado
                    Boolean existeEmpleado;
                    String idEmpleado = edtIdEmpleado.Text.Trim();
                    String conl = String.Format("select *from empleados where idempleado='{0}'", idEmpleado);
                    existeEmpleado = Utilidades.Existe(conl);

                    if (existeEmpleado == true)
                    {
                        //Capturando el dato estado
                        int estado;
                        if (cboxEstado.Text == "Disponible")
                        {
                            estado = 0;//Esta disponible
                        }
                        else
                        {
                            estado = 1;
                        }

                     
                            Boolean disponible;
                            String consular = String.Format("select * from detalle_emp_serv where estado = 1 and idempleado='{0}'", edtIdEmpleado.Text.Trim());
                            disponible = Utilidades.Existe(consular);

                            if (disponible == false)
                            {
                                //Hacer la inserción
                                try                               
                                {                                 
         
                                    String consulta = String.Format("EXEC insertarAsignarMecanico '{0}','{1}','{2}'", idServicio, idEmpleado, estado);
                                    Utilidades.Ejecutar(consulta);
                                    MessageBox.Show("Se han guardado los datos");

                                limpiarCampos();
                                    cargarTabla();
                                desactivarControles();
                                    btnGuardar.Enabled = false;

                                }
                                catch (Exception er)
                                {
                                    MessageBox.Show("Ha ocurrido un error" + er.Message);
                                }

                                }
                            else
                            {
                                MessageBox.Show("El Empleado no está disponible");
                            }
                     
                    }
                    else
                    {
                        MessageBox.Show("El empleado no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No existe este id de Servicio");
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
                    Utilidades.eliminarRegistro("AsignacionMecanico", edtIdAsignacion.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControles();
                    cargarTabla();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
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
                    String consul = String.Format("select *from detalle_emp_serv where iddetalle_emp_serv='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        edtIdServicio.Text = (dt.Tables[0].Rows[0]["iddetalle_servicio"].ToString().Trim());
                        edtIdAsignacion.Text = (dt.Tables[0].Rows[0]["iddetalle_emp_serv"].ToString().Trim());
                        edtIdEmpleado.Text = (dt.Tables[0].Rows[0]["idempleado"].ToString().Trim());

                        
                        if ((dt.Tables[0].Rows[0]["estado"].ToString().Trim())== "1"){
                            cboxEstado.SelectedItem = "Disponible";
                        }
                        else
                        {
                            cboxEstado.SelectedItem = "En Servicio";
                        }

                        empleadoActual = (dt.Tables[0].Rows[0]["idempleado"].ToString().Trim());
                        activarControles();
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este id de Asignación no existe");
                        limpiarCampos();


                    }
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }

            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            if (validarCampo(edtIdServicio) | validarCampo(edtIdEmpleado) | validarCombox(cboxEstado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String idServicio = edtIdServicio.Text.Trim();
                String consul = String.Format("select *from detalle_servicios where iddetalle_servicio='{0}'", idServicio);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    //Verificando si existe el empleado
                    Boolean existeEmpleado;
                    String idEmpleado = edtIdEmpleado.Text.Trim();
                    String conl = String.Format("select *from empleados where idempleado='{0}'", idEmpleado);
                    existeEmpleado = Utilidades.Existe(conl);

                    if (existeEmpleado == true)
                    {
                        //Capturando el dato estado
                        int estado;
                        if (cboxEstado.Text == "Disponible")
                        {
                            estado = 0;//Esta disponible
                        }
                        else
                        {
                            estado = 1;
                        }

                       
                           //  MessageBox.Show(empleadoActual+" "+ edtIdEmpleado.Text.Trim());
                             if (empleadoActual == edtIdEmpleado.Text.Trim())
                             {
                                 //Solo hacer inserción sin verificar si está fisponible puesto que otros campos fueron los que cambiaron
                                 try
                                 {
                                     String consulta = String.Format("EXEC actualizarAsignarMecanico '{0}','{1}','{2}','{3}'",edtIdAsignacion.Text.Trim(), idServicio, idEmpleado, estado);
                                     Utilidades.Ejecutar(consulta);
                                     MessageBox.Show("Se han guardado los datos");

                                     cargarTabla();
                                limpiarCampos();
                                     btnGuardar.Enabled = false;
                                desactivarControles();
                                 }
                                 catch (Exception er)
                                 {
                                     MessageBox.Show("Ha ocurrido un error" + er.Message);
                                 }
                             }
                             else
                             {
                                 //verificando si no está empleado en otro servicio
                        Boolean disponible;
                        String consular = String.Format("select * from detalle_emp_serv where estado = 1 and idempleado='{0}'", edtIdEmpleado.Text.Trim());
                        disponible = Utilidades.Existe(consular);

                        if (disponible == false)
                        {
                            //Hacer la inserción
                            try
                            {
                                    String consulta = String.Format("EXEC actualizarAsignarMecanico '{0}','{1}','{2}','{3}'", edtIdAsignacion.Text.Trim(), idServicio, idEmpleado, estado);
                                    Utilidades.Ejecutar(consulta);
                                MessageBox.Show("Se han guardado los datos");

                                cargarTabla();
                                    limpiarCampos();
                                    btnGuardar.Enabled = false;
                                    desactivarControles();

                            }
                            catch (Exception er)
                            {
                                MessageBox.Show("Ha ocurrido un error" + er.Message);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El Empleado no está disponible");
                        }
                           }
                    }
                    else
                    {
                        MessageBox.Show("El empleado no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No existe este id de Servicio");
                }
            }
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            activarControles();
            cboxEstado.SelectedItem = "Disponible";
            edtIdServicio.Focus();
        }
        private void cargarTabla()
        {
            tabla.DataSource = Utilidades.datasetLista("listarMecanicosAsignadosTodos").Tables[0];

        }

    private void limpiarCampos()
        {
            edtBuscar.Text = "";
            edtIdServicio.Text = "";
            edtIdAsignacion.Text = "";
            edtIdEmpleado.Text = "";
        }
        private void activarControles()
        {
           
            edtIdServicio.Enabled = true;
            edtIdEmpleado.Enabled = true;
            cboxEstado.Enabled = true;
        }
        private void desactivarControles()
        {

            edtIdServicio.Enabled = false;
            edtIdEmpleado.Enabled = false;
            cboxEstado.Enabled = false;
        }

        private void eventoEstado(object sender, EventArgs e)
        {
            if (tieneItems(cboxEstado) == false)
            {
                MessageBox.Show("No hay opciones de estado");
            }
        }

        private void edtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtIdServicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyec
