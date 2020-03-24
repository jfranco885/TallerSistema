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
        String cboxcargo, cboxespecialidad, cboxestado;

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

    Utilidades.llenarComboBox("select nombre_especialidad from especialidades", cboxEspecialidad, "nombre_especialidad");
    Utilidades.llenarComboBox("select cargo from cargo", cboxCargo, "cargo");

        }
        public override void guardar()
        {
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
                cboxcargo = cboxCargo.SelectedItem.ToString();
                cboxespecialidad=cboxEspecialidad.SelectedItem.ToString();
                edtdui = edtDui.Text.Trim();
                edtcelular = edtCelular.Text.Trim();
                cboxestado= cboxEstado.SelectedItem.ToString();
                edtcorreo = edtCorreo.Text.Trim();

                String consul = String.Format("select *from empleados where dui='{0}'", edtdui);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarEmpleados '{0}','{1}','{2}','{3}'" +
                            ",'{4}','{5}','{6}','{7}'", edtnombres, edtapellidos, edtdui, cboxcargo, cboxespecialidad,
                            edtcorreo,edtcelular,cboxestado);
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
    }//fin clase
}//fin proyecto
