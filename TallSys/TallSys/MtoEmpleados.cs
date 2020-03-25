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
            tabla.DataSource = Utilidades.datasetLista("Empleados").Tables[0];
        }

        private void MtoEmpleados_Load(object sender, EventArgs e)
        {

            cboxEstado.Items.Add("Activo");
            cboxEstado.Items.Add("Inactivo");

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

                edtcorreo = edtCorreo.Text.Trim();

                String consul = String.Format("select *from empleados where dui='{0}'", edtdui);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarEmpleados '{0}','{1}','{2}','{3}'" +
                            ",'{4}','{5}','{6}','{7}'", edtnombres, edtapellidos, edtdui, cboxcargoInt, cboxespecialidadInt,
                            edtcorreo,edtcelular,cboxestadoInt);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");

                        desactivarControlesE();
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("Empleados").Tables[0];//actualizando tabla
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

        private void desactivarControlesE()
        {
            edtNombre.Enabled = false;
            edtApellido.Enabled = false;
            cboxCargo.Enabled = false;
            cboxEspecialidad.Enabled = false;
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
            edtDui.Enabled = true;
            edtCelular.Enabled = true;
            cboxEstado.Enabled = true;
            edtCorreo.Enabled = true;

        }

        private void limpiarCampos()
        {
            edtIdEmpleado.Text = "";
            edtNombre.Text = "";
            edtApellido.Text = "";
            cboxCargo.Text = "";
            cboxEspecialidad.Text = "";
            edtDui.Text = "";
            edtCelular.Text = "";
            cboxEstado.Text = "";
            edtCorreo.Text = "";
            edtFecha.Text = "";

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            activarControlesE();
            edtNombre.Focus();
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
                 String consul = String.Format("Select idempleado as Código,nombres_empleado as Nombres,apellidos_empleado as Apellidos,dui as DUI,car.cargo as Cargo,esp.nombre_especialidad as Especialidad,correo as Correo,celular as Celular,estado as Estado,fecha_creacion as FechaCreación from empleados as emp inner join cargo as car on emp.idcargo=car.idcargo inner join especialidades as esp on emp.idespecialidad=esp.idespecialidad where dui='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);


                    if (dt.Tables[0].Rows.Count > 0)
                     {
                         edtIdEmpleado.Text = (dt.Tables[0].Rows[0]["Código"].ToString().Trim());
                         edtNombre.Text = (dt.Tables[0].Rows[0]["Nombres"].ToString().Trim());
                         edtApellido.Text = (dt.Tables[0].Rows[0]["Apellidos"].ToString().Trim());
                         edtDui.Text = (dt.Tables[0].Rows[0]["DUI"].ToString().Trim());
                         edtCelular.Text = (dt.Tables[0].Rows[0]["Celular"].ToString().Trim());
                         edtCorreo.Text = (dt.Tables[0].Rows[0]["Correo"].ToString().Trim());
                         cboxEspecialidad.Text = (dt.Tables[0].Rows[0]["Especialidad"].ToString().Trim());
                         cboxCargo.Text = (dt.Tables[0].Rows[0]["Cargo"].ToString().Trim());
                         cboxEstado.Text = (dt.Tables[0].Rows[0]["Estado"].ToString().Trim());
                         edtFecha.Text = (dt.Tables[0].Rows[0]["FechaCreación"].ToString().Trim());

                         activarControlesE();
                         btnEditar.Enabled = true;
                         btnEliminar.Enabled = true;
                         btnGuardar.Enabled = false;
                     }
                     else
                     {
                         MessageBox.Show("Este cliente no existe");
                     }
                 

            }
        }
    }//fin clase
}//fin proyecto
