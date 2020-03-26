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
    public partial class MtoModelos : ContenedorMantenimientos
    {
        public MtoModelos()
        {
            InitializeComponent();
            edtId.Enabled = false;
            edtModelo.Enabled = false;
            cboxMarca.Enabled = false;

            tabla.DataSource = Utilidades.datasetLista("Modelo").Tables[0];
        }

        private void MtoModelos_Load(object sender, EventArgs e)
        {
            cboxMarca.DataSource = Utilidades.llenarComboBox("select idmarca,marca from marca");
            cboxMarca.DisplayMember = "marca";
            cboxMarca.ValueMember = "idmarca";
        }
        public override void guardar()
        {
            if (validarCampo(edtModelo))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String modelo = edtModelo.Text.Trim();
               
                String consul = String.Format("select *from modelo where modelo='{0}'", modelo);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        int marca = Convert.ToInt16(cboxMarca.SelectedValue);

                        String consulta = String.Format("EXEC insertarModelo '{0}','{1}'", modelo,marca);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        edtModelo.Enabled = false;
                        cboxMarca.Enabled = false;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("Modelo").Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" + e.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este modelo ya existe");
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
                    Utilidades.eliminarRegistro("Modelo", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    edtModelo.Enabled = false;
                    cboxMarca.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("Modelo").Tables[0];

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
            edtModelo.Enabled = true;
            cboxMarca.Enabled = true;
            edtModelo.Focus();
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
                String consul = String.Format("Select idmodelo,modelo,mar.marca as marca from modelo as mo inner join marca as mar on mo.idmarca=mar.idmarca where modelo='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);


                if (dt.Tables[0].Rows.Count > 0)
                {                  

                    edtId.Text = (dt.Tables[0].Rows[0]["idmodelo"].ToString().Trim());
                    edtModelo.Text = (dt.Tables[0].Rows[0]["modelo"].ToString().Trim());                   
                    cboxMarca.Text = (dt.Tables[0].Rows[0]["marca"].ToString().Trim());


                    edtModelo.Enabled = true;
                    cboxMarca.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Este Modelo no existe");
                    limpiarCampos();
                    edtModelo.Enabled = false;
                    cboxMarca.Enabled = false;
                }


            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtModelo))
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
                        String id = edtId.Text.Trim();
                        String modelo = edtModelo.Text.Trim();
                        int marca = Convert.ToInt16(cboxMarca.SelectedValue);
                       

                        String consulta = String.Format("EXEC actualizarModelo '{0}','{1}','{2}'", id, modelo,marca);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        edtModelo.Enabled = false;
                        cboxMarca.Enabled = false;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("Modelo").Tables[0];
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
            edtId.Text = "";
            edtModelo.Text = "";
        }

        private void edtModelo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyecto
