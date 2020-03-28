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
    public partial class MtoUsuarios : ContenedorMantenimientos
    {
        Hash llamar = new Hash();

        //private String edtidusuario;
        String edtusuario;
        String edtclave;
        String cboxrol;
        
        int cboxrolInt;
        int cboxempleadoInt;

      //  String cboxrol;
       // String cboxempleado;


        public MtoUsuarios()
        {
            InitializeComponent();

            tabla.DataSource = Utilidades.datasetLista("listarUsuarios").Tables[0];
        }

        private void MtoUsuarios_Load(object sender, EventArgs e)
        {
            cboxRol.DataSource = Utilidades.llenarComboBox("select idrol,rol from roles");
            cboxRol.DisplayMember = "rol";
            cboxRol.ValueMember = "idrol";

            cboxEmpleado.DataSource = Utilidades.llenarComboBox("select idempleado,nombres_empleado from empleados");
            cboxEmpleado.DisplayMember = "nombres_empleado";
            cboxEmpleado.ValueMember = "idempleado";
        }


        public override void guardar()
        {

            //  MessageBox.Show(cboxcargo = cboxCargo.SelectedValue.ToString());
            if (validarCampo(edtUsuario) | validarCampo(edtClave))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                edtusuario = edtUsuario.Text.Trim();
               edtclave = edtClave.Text.Trim();
                // cboxcargo = cboxCargo.SelectedItem.ToString();
                cboxrolInt = Convert.ToInt32(cboxRol.SelectedValue);
                cboxempleadoInt = Convert.ToInt32(cboxEmpleado.SelectedValue);
                // cboxespecialidad =cboxEspecialidad.SelectedItem.ToString();


                //Serviciovehiculo

                String consul = String.Format("select *from usuarios where usuario='{0}'", edtusuario);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                       // string datoClave = llamar.PassHash(edtclave);
                        String consulta = String.Format("EXEC insertarUsuarios '{0}','{1}'" + ",'{2}','{3}'", edtusuario, llamar.PassHash(edtclave), cboxrolInt, cboxempleadoInt);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");

                        //tabla.DataSource = Utilidades.datasetLista("listarEmpleados").Tables[0];//actualizando tabla
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
                String consul = String.Format("Select idusuario as Código,usuario as Usuario,clave as Clave,ro.rol as Rol,emp.nombres_empleado as Empleado from usuarios as us inner join roles as ro on us.idrol=ro.idrol inner join empleados as emp on us.idempleado=emp.idempleado where usuario='{0}'",edtBuscar.Text);
                dt = Utilidades.Ejecutar(consul);

                if (dt.Tables[0].Rows.Count > 0)
                {

                    edtId.Text = (dt.Tables[0].Rows[0]["Código"].ToString().Trim());
                    edtUsuario.Text = (dt.Tables[0].Rows[0]["Usuario"].ToString().Trim());
                    edtClave.Text = (dt.Tables[0].Rows[0]["Clave"].ToString().Trim());
                    cboxRol.Text = (dt.Tables[0].Rows[0]["Rol"].ToString().Trim());
                    cboxEmpleado.Text = (dt.Tables[0].Rows[0]["Empleado"].ToString().Trim());

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

        public override void eliminar()
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    Utilidades.eliminarRegistro("Usuarios", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControlesE();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("listarUsuarios").Tables[0];
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }

        }

        private void desactivarControlesE()
        {
            edtId.Enabled = false;
            edtUsuario.Enabled = false;
            cboxRol.Enabled = false;
            cboxEmpleado.Enabled = false;
            edtClave.Enabled = false;
            
        }
        private void activarControlesE()
        {
            edtId.Enabled = true;
            edtUsuario.Enabled = true;
            cboxRol.Enabled = true;
            cboxEmpleado.Enabled = true;
            edtClave.Enabled = true;

        }

        private void limpiarCampos()
        {
            edtBuscar.Text = "";
            edtId.Text = "";
            edtUsuario.Text = "";
            edtClave.Text = "";
            cboxRol.Text = "";
            cboxEmpleado.Text = "";
            
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            if (validarCampo(edtUsuario) | validarCampo(edtClave))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    //edtId = edtId.Text.Trim();
                    edtusuario = edtUsuario.Text.Trim();
                    edtclave = edtClave.Text.Trim();
                    // cboxcargo = cboxCargo.SelectedItem.ToString();
                    cboxrolInt = Convert.ToInt32(cboxRol.SelectedValue);
                    cboxempleadoInt = Convert.ToInt32(cboxEmpleado.SelectedValue);
                    // cboxespecialidad =cboxEspecialidad.SelectedItem.ToString();
                    edtusuario = edtUsuario.Text.Trim();
                    edtclave = edtClave.Text.Trim();
                    cboxrol = cboxRol.SelectedItem.ToString();
                   /* if (cboxrol == "Admin" | cboxrol == "admin")
                    {
                        cboxrolInt = 1;
                    }
                    else
                    {
                        cboxrolInt = 0;
                    }
                   */

                    //edtcorreo = edtCorreo.Text.Trim();
                    try
                    {

                        String consulta = String.Format("EXEC actualizarUsuarios '{0}','{1}'"+",'{2}','{3}'", edtusuario, edtclave,cboxrolInt, cboxempleadoInt);
                        Utilidades.Ejecutar(consulta);

                        MessageBox.Show("Se actualizaron los datos");
                        desactivarControlesE();
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarUsuarios").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }

                }


            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            activarControlesE();
        }
    }
    }
