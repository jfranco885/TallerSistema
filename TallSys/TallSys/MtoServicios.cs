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
    public partial class MtoServicios : ContenedorMantenimientos
    {
        String naveActual;
        public MtoServicios()
        {
            InitializeComponent();
            desactivarControles();
            edtIdDetalleServ.Enabled = false;
            edtFecha.Enabled = false;
            edtIdNaveServ.Enabled = false;
            cargarTablaMtoServicios();
        }

        private void MtoServicios_Load(object sender, EventArgs e)
        {
            cboxEstado.DataSource = Utilidades.llenarComboBox("select idestado,estado from estado");
            cboxEstado.DisplayMember = "estado";
            cboxEstado.ValueMember = "idestado";

            cboxTipoServicio.DataSource = Utilidades.llenarComboBox("select idtipo_servicio,nombre_servicio from tipo_servicios");
            cboxTipoServicio.DisplayMember = "nombre_servicio";
            cboxTipoServicio.ValueMember = "idtipo_servicio";

            cboxNav.DataSource = Utilidades.llenarComboBox("select idnave from nave");         
            cboxNav.DisplayMember = "idnave";
            cboxNav.ValueMember = "idnave";
            
        }

        public override void guardar()
        {

            //  MessageBox.Show(cboxcargo = cboxCargo.SelectedValue.ToString());
            if (validarCampo(edtIdEncabezado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                if (!string.IsNullOrEmpty(edtTiempo.Text) & !validarSoloNumeros(edtTiempo))//Si no es nullo y a la vez no son numeros
                {

                }
                else
                {

                    Boolean existe;
                    String idEncabezado = edtIdEncabezado.Text.Trim();

                    String consul = String.Format("select *from encabezado_servicio where idencabezado_servicio='{0}'", idEncabezado);
                    existe = Utilidades.Existe(consul);

                    if (existe == true)
                    {

                        //////////////////////
                        //Validando si está disponible la nave
                        Boolean naveDisponible;
                        int validarNave = Convert.ToInt32(cboxNav.SelectedValue);

                        String consultar = String.Format("select * from nave where estado='Disponible' and idnave ={0}", validarNave);
                        naveDisponible = Utilidades.Existe(consultar);
                        if (naveDisponible)
                        {
                            //////////

                            String descripcion = edtDescripcion.Text.Trim();
                            String diagnostico = edtDiag.Text.Trim();
                            int estado = Convert.ToInt32(cboxEstado.SelectedValue);
                            String tiempo = edtTiempo.Text.Trim();
                            if (tiempo == "")
                            {
                                tiempo = "0";
                            }
                            String actividad = edtActivida.Text.Trim();
                            int nave = Convert.ToInt32(cboxNav.SelectedValue);
                            String estadoNave = "Ocupada";
                            int tipoServicio = Convert.ToInt32(cboxTipoServicio.SelectedValue);
                            //Validando que si tiempo lleva datos no sean letras
                            if (!string.IsNullOrEmpty(edtTiempo.Text) & !validarSoloNumeros(edtTiempo))//Si no es nullo y a la vez no son numeros
                            {

                            }
                            else
                            {
                                try
                                {
                                    String consulta = String.Format("EXEC insertarMtoDetalleServicio '{0}','{1}','{2}','{3}'" +
                                        ",'{4}','{5}','{6}','{7}','{8}'", idEncabezado, descripcion, diagnostico, estado, tiempo,
                                        actividad, nave, estadoNave, tipoServicio);
                                    Utilidades.Ejecutar(consulta);

                                    errorProvider1.Clear();
                                    MessageBox.Show("Se han guardado los datos");

                                    desactivarControles();
                                    btnGuardar.Enabled = false;
                                    
                                    limpiarCampos();
                                    
                                    cargarTablaMtoServicios();
                                }
                                catch (Exception errorGuardarC)
                                {
                                    MessageBox.Show("Ha ocurrido un error" + errorGuardarC.Message);
                                }
                            }//final validando si el tiempo no es nulo sean solo dígitos


                        }//fin si está disponible la nave
                        else
                        {
                            MessageBox.Show("Esta nave no está disponible");
                        }
                    }//sin si existe
                    else//si existe
                    {
                        MessageBox.Show("No existe este Encabezado de servicio");
                    }
                }
            }//fin validadndo campos


        }//fin boton
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
            limpiarCampos();
            activarControles();
            edtIdEncabezado.Focus();
            cboxEstado.SelectedIndex=1;
            cboxEstado.Enabled = false;//una vez creado el servicio estará iniciado

        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {

                String edtbuscar = edtBuscar.Text.Trim();
                DataSet dt;
               
                dt = Utilidades.datasetConsultarProcedure("consultarMtoDetalleServicio",Convert.ToInt16(edtbuscar));
               
                if (dt.Tables[0].Rows.Count > 0)
                {

                   



                    String estad = dt.Tables[0].Rows[0]["Estado"].ToString().Trim();
                    String servVehiculo;

                    edtIdEncabezado.Text = dt.Tables[0].Rows[0]["IdEncabezadoServicio"].ToString().Trim();
                    edtIdDetalleServ.Text = dt.Tables[0].Rows[0]["IdServicio"].ToString().Trim();
                    edtTiempo.Text = dt.Tables[0].Rows[0]["TiempoDiagnosticado"].ToString().Trim();
                    edtDescripcion.Text = dt.Tables[0].Rows[0]["Descripcion"].ToString().Trim();
                    edtDiag.Text = dt.Tables[0].Rows[0]["Diagnostico"].ToString().Trim();
                    edtActivida.Text = dt.Tables[0].Rows[0]["Actividad"].ToString().Trim();
                    edtFecha.Text = dt.Tables[0].Rows[0]["Fecha"].ToString().Trim();
                    edtIdNaveServ.Text = dt.Tables[0].Rows[0]["IdNaveTipoServicio"].ToString().Trim();
                    cboxEstado.Text= dt.Tables[0].Rows[0]["Estado"].ToString().Trim();
                    cboxNav.Text= dt.Tables[0].Rows[0]["Nave"].ToString().Trim();  
                    //cboxNav.DisplayMember = dt.Tables[0].Rows[0]["Nave"].ToString().Trim();

                    cboxTipoServicio.Text= dt.Tables[0].Rows[0]["TipoServicio"].ToString().Trim();

                    naveActual= dt.Tables[0].Rows[0]["Nave"].ToString().Trim();//para validar cuando haya cambios al editar


                    activarControles();
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Este id de Detalle Servicio no existe");
                    limpiarCampos();
                    desactivarControles();
                }


            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtIdEncabezado) | validarCampo(edtIdDetalleServ))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                //Validando que si tiempo lleva datos no sean letras
                if (!string.IsNullOrEmpty(edtTiempo.Text) & !validarSoloNumeros(edtTiempo))//Si no es nullo y a la vez no son numeros
                {

                }
                else
                {

                    Boolean existe;
                    String idEncabezado = edtIdEncabezado.Text.Trim();

                    String consul = String.Format("select *from encabezado_servicio where idencabezado_servicio='{0}'", idEncabezado);
                    existe = Utilidades.Existe(consul);

                    if (existe == true)
                    {


                        Boolean naveDisponible;
                        int validarNave = Convert.ToInt32(cboxNav.SelectedValue);

                        errorProvider1.Clear();//borrando el error si viene vacio el tiempo

                        DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
                        if (resul == DialogResult.Yes)
                        {
                            String idDetalleServicio = edtIdDetalleServ.Text.Trim();
                            String descripcion = edtDescripcion.Text.Trim();
                            String diagnostico = edtDiag.Text.Trim();
                            int estado = Convert.ToInt32(cboxEstado.SelectedValue);
                            String tiempo = edtTiempo.Text.Trim();
                            if (tiempo == "")
                            {
                                tiempo ="0";
                            }
                            String actividad = edtActivida.Text.Trim();
                            int nave = Convert.ToInt32(cboxNav.SelectedValue);
                            //para valor del estado nave
                            String validarEst = cboxEstado.Text.Trim();
                            String estadoNave = "Ocupada";

                            if (validarEst == "Terminado")
                            {
                                estadoNave = "Disponible";
                            }


                            int tipoServicio = Convert.ToInt32(cboxTipoServicio.SelectedValue);
                            String idNaveTipoServicio = edtIdNaveServ.Text.Trim();
                            if (naveActual == cboxNav.Text.Trim())
                            {//Si la nave no ha cambiado solo insertar
                                try
                                {
                                    String consulta = String.Format("EXEC actualizarMtoDetalleServicio '{0}','{1}','{2}','{3}'" +
                                            ",'{4}','{5}','{6}','{7}','{8}','{9}','{10}'", idDetalleServicio, descripcion, diagnostico,
                                            estado, tiempo, actividad, nave, estadoNave, tipoServicio, idEncabezado, idNaveTipoServicio);
                                    Utilidades.Ejecutar(consulta);
                                    MessageBox.Show("Se actualizaron los datos");
                                    desactivarControles();
                                    btnEditar.Enabled = false;
                                    btnEliminar.Enabled = false;
                                    limpiarCampos();
                                    cargarTablaMtoServicios();//llenando la tabla
                                }
                                catch (Exception error)
                                {
                                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                                }
                            }//Si la nave cambio verificar si está dicponible
                            else
                            {


                                //validando si está disponible la nave
                                String consultar = String.Format("select * from nave where estado='Disponible' and idnave ={0}", validarNave);
                                naveDisponible = Utilidades.Existe(consultar);
                                if (naveDisponible)
                                {
                                    try
                                    {
                                        String consulta = String.Format("EXEC actualizarMtoDetalleServicio '{0}','{1}','{2}','{3}'" +
                                                ",'{4}','{5}','{6}','{7}','{8}','{9}','{10}'", idDetalleServicio, descripcion, diagnostico,
                                                estado, tiempo, actividad, nave, estadoNave, tipoServicio, idEncabezado, idNaveTipoServicio);
                                        Utilidades.Ejecutar(consulta);
                                        MessageBox.Show("Se actualizaron los datos");
                                        desactivarControles();
                                        btnEditar.Enabled = false;
                                        btnEliminar.Enabled = false;
                                        limpiarCampos();
                                        cargarTablaMtoServicios();//llenando la tabla
                                    }
                                    catch (Exception error)
                                    {
                                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Esta nave no está disponible");
                                }

                                
                            }

                        }


                    }//fin si existe
                    else//si existe
                    {
                        MessageBox.Show("No existe este Encabezado de servicio");
                    }
                }
            }//fin validando campos
        }//fin editar
        public override void eliminar()
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    Utilidades.eliminarRegistro("MtoDetalleServicio", edtIdDetalleServ.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControles();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cargarTablaMtoServicios();
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }

        }
        private void limpiarCampos()
        {
            edtIdEncabezado.Text = "";
            edtIdDetalleServ.Text = "";
            edtTiempo.Text = "";            
            edtDescripcion.Text = "";
            edtBuscar.Text = "";
            edtDiag.Text = "";
            edtActivida.Text = "";
            edtFecha.Text = "";
            edtIdNaveServ.Text = "";
                        
        }
        private void activarControles()
        {
            edtIdEncabezado.Enabled = true;            
            edtTiempo.Enabled = true;
          
            edtDescripcion.Enabled = true;           
            edtDiag.Enabled = true;
            edtActivida.Enabled = true;
            cboxEstado.Enabled = true;
            cboxNav.Enabled = true;
            cboxTipoServicio.Enabled = true;           

        }
        private void desactivarControles()
        {
            edtIdEncabezado.Enabled = false;
            edtTiempo.Enabled = false;
           
            edtDescripcion.Enabled = false;
            edtDiag.Enabled = false;
            edtActivida.Enabled = false;
            cboxEstado.Enabled = false;
            cboxNav.Enabled = false;
            cboxTipoServicio.Enabled = false;

        }
        private void cargarTablaMtoServicios()
        {
            tabla.DataSource = Utilidades.datasetLista("listarMtoDetalleServicio").Tables[0];
        }

        private void edtTiempo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//prin proyecto
