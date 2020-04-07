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
    public partial class MtoEmpleados : ContenedorMantenimientos
    {
       private String edtidempleado;
        String edtnombres;
        String edtapellidos;
        String edtdui;
        String edtcelular;
        String edtfecha;
        String edtcorreo;
        int cboxcargoInt;
        int cboxespecialidadInt;
        int servicioVehiculo;
        String cboxcargo;
        String cboxespecialidad;
        String cboxestado;

        int cboxestadoInt;

        public MtoEmpleados()
        {
            InitializeComponent();
            edtFecha.Enabled = false;
            edtIdEmpleado.Enabled = false;
            desactivarControlesE();
            
            tabla.DataSource = Utilidades.datasetLista("listarEmpleados").Tables[0];
        }

        private void MtoEmpleados_Load(object sender, EventArgs e)
        {

            cboxEstado.Items.Add("Activo");
            cboxEstado.Items.Add("Inactivo");

            cboxServicioVehiculo.Items.Add("Si");
            cboxServicioVehiculo.Items.Add("No");

            // Utilidades.llenarComboBox("select idespecialidad, nombre_especialidad from especialidades", cboxEspecialidad, "nombre_especialidad","idespecialidad");
            //   Utilidades.llenarComboBox("select idcargo, cargo from cargo", cboxCargo, "cargo","idcargo");

            cboxEspecialidad.DataSource = Utilidades.llenarComboBox("select idespecialidad,nombre_especialidad from especialidades");
            cboxEspecialidad.DisplayMember = "nombre_especialidad";
            cboxEspecialidad.ValueMember = "idespecialidad";

            cboxCargo.DataSource = Utilidades.llenarComboBox("select idcargo,cargo from cargo");
            cboxCargo.DisplayMember = "cargo";
            cboxCargo.ValueMember = "idcargo";

            

        }
        public override void guardar()
        {

          //  MessageBox.Show(cboxcargo = cboxCargo.SelectedValue.ToString());
            if (validarCampo(edtNombre) | validarCampo(edtApellido) | validarCampo(edtDui) |
                validarCampo(edtCelular) | validarCampo(edtCorreo))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                edtnombres = edtNombre.Text.Trim();
                edtapellidos = edtApellido.Text.Trim();
               // cboxcargo = cboxCargo.SelectedItem.ToString();
                cboxcargoInt =Convert.ToInt32(cboxCargo.SelectedValue);
                cboxespecialidadInt = Convert.ToInt32(cboxEspecialidad.SelectedValue);
                // cboxespecialidad =cboxEspecialidad.SelectedItem.ToString();
                edtdui = edtDui.Text.Trim();
                edtcelular = edtCelular.Text.Trim();
                cboxestado= cboxEstado.SelectedItem.ToString();
                if (cboxestado == "Activo" | cboxestado == "activo")
                {
                    cboxestadoInt = 1;
                }
                else
                {
                    cboxestadoInt = 0;
                }
                //Serviciovehiculo
                if (cboxServicioVehiculo.SelectedItem.ToString() == "Si")
                {
                    servicioVehiculo = 1;
                }
                else
                {
                    servicioVehiculo = 0;
                }

                edtcorreo = edtCorreo.Text.Trim();

                String consul = String.Format("select *from empleados where dui='{0}'", edtdui);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarEmpleados '{0}','{1}','{2}','{3}'" +
                            ",'{4}','{5}','{6}','{7}','{8}'", edtnombres, edtapellidos, edtdui, cboxcargoInt, cboxespecialidadInt,
                            edtcorreo,edtcelular,cboxestadoInt,servicioVehiculo);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");

                        desactivarControlesE();
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarEmpleados").Tables[0];//actualizando tabla
                    }
                    catch (Exception errorGuardarC)
                    {
                        MessageBox.Show("Ha ocurrido un error" + errorGuardarC.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este  ya existe");
                }
            }


        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            activarControlesE();
            edtNombre.Focus();
            cboxEstado.SelectedItem = "Activo";
            cboxServicioVehiculo.SelectedItem = "Si";
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
                String consul = String.Format("Select idempleado as Código,nombres_empleado as Nombres,apellidos_empleado as Apellidos,dui as DUI,car.cargo as Cargo,esp.nombre_especialidad as Especialidad,correo as Correo,celular as Celular,estado as Estado,fecha_creacion as FechaCreación,servicio_vehiculo from empleados as emp inner join cargo as car on emp.idcargo=car.idcargo inner join especialidades as esp on emp.idespecialidad=esp.idespecialidad where dui='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);


                if (dt.Tables[0].Rows.Count > 0)
                {
                    String estad = dt.Tables[0].Rows[0]["Estado"].ToString().Trim();
                    String servVehiculo;
                    if (estad == "1")
                    {
                        estad = "Activo";
                    }
                    else
                    {
                        estad = "InActivo";
                    }
                    //para sel serviciovehiculo si o no
                    if (dt.Tables[0].Rows[0]["servicio_vehiculo"].ToString().Trim() == "1")
                    {
                        servVehiculo = "Si";
                    }
                    else
                    {
                        servVehiculo = "No";
                    }

                    edtIdEmpleado.Text = (dt.Tables[0].Rows[0]["Código"].ToString().Trim());
                    edtNombre.Text = (dt.Tables[0].Rows[0]["Nombres"].ToString().Trim());
                    edtApellido.Text = (dt.Tables[0].Rows[0]["Apellidos"].ToString().Trim());
                    edtDui.Text = (dt.Tables[0].Rows[0]["DUI"].ToString().Trim());
                    edtCelular.Text = (dt.Tables[0].Rows[0]["Celular"].ToString().Trim());
                    edtCorreo.Text = (dt.Tables[0].Rows[0]["Correo"].ToString().Trim());
                    cboxEspecialidad.Text = (dt.Tables[0].Rows[0]["Especialidad"].ToString().Trim());
                    cboxCargo.Text = (dt.Tables[0].Rows[0]["Cargo"].ToString().Trim());
                    cboxEstado.Text = (estad);
                    cboxServicioVehiculo.Text = (servVehiculo);
                    edtFecha.Text = (dt.Tables[0].Rows[0]["FechaCreación"].ToString().Trim());

                    activarControlesE();
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Este Empleado no existe");
                    limpiarCampos();
                    desactivarControlesE();
                }


            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtNombre) | validarCampo(edtApellido) | validarCampo(edtDui) |
               validarCampo(edtCelular) | validarCampo(edtCorreo))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    edtidempleado = edtIdEmpleado.Text.Trim();
                    edtnombres = edtNombre.Text.Trim();
                    edtapellidos = edtApellido.Text.Trim();
                    // cboxcargo = cboxCargo.SelectedItem.ToString();
                    cboxcargoInt = Convert.ToInt32(cboxCargo.SelectedValue);
                    cboxespecialidadInt = Convert.ToInt32(cboxEspecialidad.SelectedValue);
                    // cboxespecialidad =cboxEspecialidad.SelectedItem.ToString();
                    edtdui = edtDui.Text.Trim();
                    edtcelular = edtCelular.Text.Trim();
                    cboxestado = cboxEstado.SelectedItem.ToString();
                    if (cboxestado == "Activo" | cboxestado == "activo")
                    {
                        cboxestadoInt = 1;
                    }
                    else
                    {
                        cboxestadoInt = 0;
                    }
                    //Serviciovehiculo
                    if (cboxServicioVehiculo.SelectedItem.ToString() == "Si")
                    {
                        servicioVehiculo = 1;
                    }
                    else
                    {
                        servicioVehiculo = 0;
                    }

                    edtcorreo = edtCorreo.Text.Trim();
                    try
                    {

                        String consulta = String.Format("EXEC actualizarEmpleados '{0}','{1}','{2}','{3}'" +
                                ",'{4}','{5}','{6}','{7}','{8}','{9}'", edtidempleado, edtnombres, edtapellidos, edtdui, cboxcargoInt, cboxespecialidadInt, edtcorreo, edtcelular, cboxestadoInt,servicioVehiculo);
                        Utilidades.Ejecutar(consulta);

                        MessageBox.Show("Se actualizaron los datos");
                        desactivarControlesE();
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarEmpleados").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }

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
                    Utilidades.eliminarRegistro("Empleados", edtIdEmpleado.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControlesE();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("listarEmpleados").Tables[0];
                }catch(Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }

        }
        private void desactivarControlesE()
        {
            edtNombre.Enabled = false;
            edtApellido.Enabled = false;
            cboxCargo.Enabled = false;
            cboxEspecialidad.Enabled = false;
            cboxServicioVehiculo.Enabled = false;
            edtDui.Enabled = false;
            edtCelular.Enabled = false;
            cboxEstado.Enabled = false;
            edtCorreo.Enabled = false;

        }
        private void activarControlesE()
        {
            edtNombre.Enabled = true;
            edtApellido.Enabled = true;
            cboxCargo.Enabled = true;
            cboxEspecialidad.Enabled = true;
            cboxServicioVehiculo.Enabled = true;
            edtDui.Enabled = true;
            edtCelular.Enabled = true;
            cboxEstado.Enabled = true;
            edtCorreo.Enabled = true;

        }

        private void limpiarCampos()
        {
            edtBuscar.Text = "";
            edtIdEmpleado.Text = "";
            edtNombre.Text = "";
            edtApellido.Text = "";
            cboxCargo.Text = "";
            cboxEspecialidad.Text = "";
            cboxEstado.Text = "";
            cboxServicioVehiculo.Text = "";
            edtDui.Text = "";
            edtCelular.Text = "";
            cboxEstado.Text = "";
            edtCorreo.Text = "";
            edtFecha.Text = "";

        }

        private void edtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtDui_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtCelular_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtCorreo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtFecha_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void eventoCargo(object sender, EventArgs e)
        {
            if (tieneItems(cboxCargo) == false)
            {
                MessageBox.Show("No hay opciones de Cargo, debe ingresarlas en el mantenimiento cargo");
            }
        }

        private void eventoEspecialidad(object sender, EventArgs e)
        {
            if (tieneItems(cboxEspecialidad) == false)
            {
                MessageBox.Show("No hay opciones de especialidades");
            }
        }

        private void eventoEstado(object sender, EventArgs e)
        {
            if (tieneItems(cboxEstado) == false)
            {
                MessageBox.Show("No hay opciones de estado");
            }
        }

        private void eventoSeraVehi(object sender, EventArgs e)
        {
            if (tieneItems(cboxServicioVehiculo) == false)
            {
                MessageBox.Show("No hay opciones de servicio a vehículo");
            }
        }
    }//fin clase
}//fin proyecto
