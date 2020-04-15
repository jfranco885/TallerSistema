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
    public partial class MtoEspecialidades : ContenedorMantenimientos
    {
     
        public MtoEspecialidades()
        {
            InitializeComponent();
            edtId.Enabled = false;
            edtEspecialidad.Enabled = false;

            tabla.DataSource = Utilidades.datasetLista("listarEspecialidades").Tables[0];
        }

        private void MtoEspecialidades_Load(object sender, EventArgs e)
        {

        }
        public override void guardar()
        {
            if (validarCampo(edtEspecialidad))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String edtespecialidad = edtEspecialidad.Text.Trim();
                String consul = String.Format("select *from especialidades where nombre_especialidad='{0}'", edtespecialidad);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarEspecialidad '{0}'", edtespecialidad);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        edtEspecialidad.Enabled = false;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarEspecialidades").Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" + e.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Esta especialidad ya existe");
                }
            }

            
        }

        public override void eliminar()
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try { 
                Utilidades.eliminarRegistro("Especialidad", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                limpiarCampos();
                edtEspecialidad.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                tabla.DataSource = Utilidades.datasetLista("listarEspecialidades").Tables[0];

                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }

        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            edtEspecialidad.Enabled = true;
            edtEspecialidad.Focus();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!validarSoloNumeros(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                try { 

                String edtbuscar = edtBuscar.Text.Trim();
                DataSet dt;
                String consul = String.Format("select *from especialidades where idespecialidad='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    edtId.Text = (dt.Tables[0].Rows[0]["idespecialidad"].ToString().Trim());
                    edtEspecialidad.Text = (dt.Tables[0].Rows[0]["nombre_especialidad"].ToString().Trim());

                    edtEspecialidad.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Esta especialidad no existe");
                        limpiarCampos();
                        edtEspecialidad.Enabled=false;
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
            if (validarCampo(edtEspecialidad))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {

                DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    try
                    {

                        String consulta = String.Format("EXEC actualizarEspecialidad '{0}','{1}'", edtId.Text, edtEspecialidad.Text);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        edtEspecialidad.Enabled = false;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("listarEspecialidades").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }
                    limpiarCampos();
                }
            }
        }

        private void limpiarCampos()
        {
            edtEspecialidad.Text = "";
            edtBuscar.Text = "";
            edtId.Text = "";
        }

        private void edtEspecialidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyecto
