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
    public partial class MtoClientes : ContenedorMantenimientos

    {
        String edtidcliente;
        String edtnombres;
        String edtapellidos;
        String edtdui;
        String edttelefono;
        String edtdireccion;
        String edtcorreo;
        public MtoClientes()
        {
            InitializeComponent();
            tabla.DataSource = Utilidades.datasetLista("Clientes").Tables[0];
            edtFecha.Enabled = false;
            edtIdCliente.Enabled = false;
            desactivarControlesC();

        }

        public override void guardar()
        {
            if (validarCampo(edtNombres) | validarCampo(edtApellidos) | validarCampo(edtDui) | 
                validarCampo(edtTelefono)| validarCampo(edtDireccion))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
               edtnombres = edtNombres.Text.Trim();
               edtapellidos = edtApellidos.Text.Trim();
               edtdui=edtDui.Text.Trim();
               edttelefono=edtTelefono.Text.Trim();
               edtdireccion=edtDireccion.Text.Trim();
               edtcorreo=edtCorreo.Text.Trim();

                String consul = String.Format("select *from clientes where dui='{0}'", edtdui);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarClientes '{0}','{1}','{2}','{3}'" +
                            ",'{4}','{5}'", edtnombres,edtapellidos,edtdui,edttelefono,edtdireccion,edtcorreo);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                       
                        desactivarControlesC();
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("Clientes").Tables[0];//actualizando tabla
                    }
                    catch (Exception errorGuardarC)
                    {
                        MessageBox.Show("Ha ocurrido un error" + errorGuardarC.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este cargo ya existe");
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
                String consul = String.Format("select *from clientes where dui='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    edtIdCliente.Text = (dt.Tables[0].Rows[0]["idcliente"].ToString().Trim());
                    edtNombres.Text = (dt.Tables[0].Rows[0]["nombres_cliente"].ToString().Trim());
                    edtApellidos.Text = (dt.Tables[0].Rows[0]["apellidos_cliente"].ToString().Trim());
                    edtDui.Text = (dt.Tables[0].Rows[0]["dui"].ToString().Trim());
                    edtTelefono.Text = (dt.Tables[0].Rows[0]["telefono"].ToString().Trim());
                    edtCorreo.Text = (dt.Tables[0].Rows[0]["correo"].ToString().Trim());
                    edtDireccion.Text = (dt.Tables[0].Rows[0]["direccion"].ToString().Trim());
                    edtFecha.Text = (dt.Tables[0].Rows[0]["fecha_creacion"].ToString().Trim());

                    activarControlesC();
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

        public override void eliminar()
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                Utilidades.eliminarRegistro("Cliente", edtIdCliente.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                limpiarCampos();
                desactivarControlesC();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                tabla.DataSource = Utilidades.datasetLista("Clientes").Tables[0];
            }

        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    edtidcliente = edtIdCliente.Text.Trim();
                    edtnombres = edtNombres.Text.Trim();
                    edtapellidos = edtApellidos.Text.Trim();
                    edtdui = edtDui.Text.Trim();
                    edttelefono = edtTelefono.Text.Trim();
                    edtdireccion = edtDireccion.Text.Trim();
                    edtcorreo = edtCorreo.Text.Trim();

                    String consulta = String.Format("EXEC actualizarClientes '{0}','{1}','{2}','{3}'" +
                            ",'{4}','{5}','{6}'",edtidcliente, edtnombres, edtapellidos, edtdui, edttelefono, edtdireccion, edtcorreo);
                    Utilidades.Ejecutar(consulta);

                    Utilidades.Ejecutar(consulta);
                    MessageBox.Show("Se actualizaron los datos");
                    desactivarControlesC();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    limpiarCampos();
                    tabla.DataSource = Utilidades.datasetLista("Clientes").Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error" + error.Message);
                }
                limpiarCampos();
            }
        }
        //limpiar
        private void limpiarCampos()
        {
            edtBuscar.Text = ("");
            edtIdCliente.Text = ("");
            edtNombres.Text = ("");
            edtApellidos.Text = ("");
            edtDui.Text = ("");
            edtTelefono.Text = ("");
            edtDireccion.Text = ("");
            edtCorreo.Text = ("");
            edtFecha.Text = ("");
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            activarControlesC();
            limpiarCampos();               
            edtNombres.Focus();
        }
        //desactivando botones
        private void desactivarControlesC()
        {
           
            edtNombres.Enabled = false;
            edtApellidos.Enabled = false;
            edtDui.Enabled = false;
            edtTelefono.Enabled = false;
            edtDireccion.Enabled = false;
            edtCorreo.Enabled = false;
           
        }
        //activando botones
        private void activarControlesC()
        {
            
            edtNombres.Enabled = true;
            edtApellidos.Enabled = true;
            edtDui.Enabled = true;
            edtTelefono.Enabled = true;
            edtDireccion.Enabled = true;
            edtCorreo.Enabled = true;
            
        }

        private void MtoClientes_Load(object sender, EventArgs e)
        {

        }

        private void edtNombres_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtApellidos_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtDui_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtCorreo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edtTelefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtDireccion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyecto
