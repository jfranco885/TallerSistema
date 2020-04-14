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
    public partial class MtoNaves : ContenedorMantenimientos
    {
        public MtoNaves()
        {
            InitializeComponent();
            edtId.Enabled = false;
            edtDescripcion.Enabled = false;
            
            cboxEstado.Enabled=false;

            tabla.DataSource = Utilidades.datasetLista("listarNave").Tables[0];
        }

        private void MtoNaves_Load(object sender, EventArgs e)
        {

            cboxEstado.Items.Add("Disponible");
            cboxEstado.Items.Add("Ocupada");

        }

        public override void guardar()
        {
            if (validarCampo(edtDescripcion) | validarCombox(cboxEstado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                String descripcion = edtDescripcion.Text.Trim();
                String estado = cboxEstado.Text.Trim();
              
                    try
                    {
                        String consulta = String.Format("EXEC insertarNave '{0}','{1}'", descripcion,estado );
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        edtDescripcion.Enabled = false;
                    cboxEstado.Enabled = false;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarNave").Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" + e.Message);
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
                    Utilidades.eliminarRegistro("Nave", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    edtDescripcion.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cboxEstado.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("listarNave").Tables[0];

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
            edtDescripcion.Enabled = true;
            cboxEstado.Enabled = true;
            cboxEstado.Text = "Disponible";
            edtDescripcion.Focus();
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!validarSoloNumeros(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                try
                {
                    String edtbuscar = edtBuscar.Text.Trim();
                    DataSet dt;
                    String consul = String.Format("select *from nave where idnave='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        edtId.Text = (dt.Tables[0].Rows[0]["idnave"].ToString().Trim());
                        edtDescripcion.Text = (dt.Tables[0].Rows[0]["descripcion"].ToString().Trim());
                        cboxEstado.Text = (dt.Tables[0].Rows[0]["Estado"].ToString().Trim());

                        edtDescripcion.Enabled = true;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        cboxEstado.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta Nave no existe");
                        limpiarCampos();
                        edtDescripcion.Enabled = false;
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
            if (validarCampo(edtDescripcion) | validarCombox(cboxEstado))
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

                        String consulta = String.Format("EXEC actualizarNave '{0}','{1}','{2}'", edtId.Text, edtDescripcion.Text,cboxEstado.Text.Trim());
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        edtDescripcion.Enabled = false;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        cboxEstado.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("listarNave").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }
                    limpiarCampos();
                }
            }
        }
        private void edtDescripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void limpiarCampos()
        {
            edtBuscar.Text = "";
            edtDescripcion.Text = "";
            edtId.Text = "";
            cboxEstado.Text = "";
        }

       
    }//fin clase
}//fin proyecto
