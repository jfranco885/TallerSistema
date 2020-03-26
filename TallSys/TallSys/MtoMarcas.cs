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
    public partial class MtoMarcas : ContenedorMantenimientos
    {
        public MtoMarcas()
        {
            InitializeComponent();
            edtIdMarca.Enabled = false;
            edtMarca.Enabled = false;

            tabla.DataSource = Utilidades.datasetLista("Marca").Tables[0];
        }
        public override void guardar()
        {
            if (validarCampo(edtMarca))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String edtmarca = edtMarca.Text.Trim();
                String consul = String.Format("select *from marca where marca='{0}'", edtmarca);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarMarca '{0}'", edtmarca);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        edtMarca.Enabled = false;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("Marca").Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" + e.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Esta Marca ya existe");
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
                    Utilidades.eliminarRegistro("Marca", edtIdMarca.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    edtMarca.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("Marca").Tables[0];

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
            edtMarca.Enabled = true;
            edtMarca.Focus();
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
                    String consul = String.Format("select *from marca where marca='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        edtIdMarca.Text = (dt.Tables[0].Rows[0]["idmarca"].ToString().Trim());
                        edtMarca.Text = (dt.Tables[0].Rows[0]["marca"].ToString().Trim());

                        edtMarca.Enabled = true;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta Marca no existe");
                        limpiarCampos();
                        edtMarca.Enabled = false;
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
            if (validarCampo(edtMarca))
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

                        String consulta = String.Format("EXEC actualizarMarca '{0}','{1}'", edtIdMarca.Text, edtMarca.Text);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        edtMarca.Enabled = false;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("Marca").Tables[0];
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
            edtBuscar.Text = "";
            edtIdMarca.Text = "";
            edtMarca.Text = "";
        }

        private void edtMarca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clases
}//fin proyecto
