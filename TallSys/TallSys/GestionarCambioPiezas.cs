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
    public partial class GestionarCambioPiezas : ContenedorVentanas
    {
       
        public GestionarCambioPiezas()
        {
            InitializeComponent();
            edtServicio.Enabled = false;
            edtidCambio.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtRepuesto) | validarCampo(edtCantidad))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
               
                    try
                    {
                        String consulta = String.Format("EXEC insertarCambioPieza '{0}','{1}','{2}'", edtRepuesto.Text.Trim(),edtServicio.Text.Trim(),Convert.ToInt16(edtCantidad.Text.Trim()));
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                    edtRepuesto.Text = "";
                    edtCantidad.Text = "";
                    edtidCambio.Text = "";
                    dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(edtServicio.Text.Trim())).Tables[0];
                  
                }
                catch (Exception er)
                    {
                        MessageBox.Show("Ha ocurrido un error" + er.Message);
                    }

                }
               
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtRepuesto)| validarCampo(edtCantidad))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                String idcambio = edtidCambio.Text.Trim();
                String pieza = edtRepuesto.Text.Trim();
                String idservicio = edtServicio.Text.Trim();
                


                try
                {
                    String consulta = String.Format("EXEC actualizarCambioPieza '{0}','{1}','{2}','{3}'", idcambio,pieza,idservicio, edtCantidad.Text.Trim());
                    Utilidades.Ejecutar(consulta);
                    MessageBox.Show("Se han guardado los datos");
                    edtRepuesto.Text = "";
                    edtCantidad.Text = "";
                    edtidCambio.Text = "";
                    dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(edtServicio.Text.Trim())).Tables[0];

                }
                catch (Exception er)
                {
                    MessageBox.Show("Ha ocurrido un error" + er.Message);
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtidCambio))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    String idcambio = edtidCambio.Text.Trim();

                try
                {
                    String consulta = String.Format("EXEC eliminarCambioPieza '{0}'", idcambio);
                    Utilidades.Ejecutar(consulta);
                    MessageBox.Show("Se Eliminó el registro");
                    edtRepuesto.Text = "";
                    edtCantidad.Text = "";
                    edtidCambio.Text = "";
                    dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(edtServicio.Text.Trim())).Tables[0];

                }
                catch (Exception er)
                {
                    MessageBox.Show("Ha ocurrido un error" + er.Message);
                }
            }
            }
        }

        private void edtRepuesto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtCantidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void EnviarDatos(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(dataGridRepuesto.ImeMode);
           // int i = dataGridRepuesto.CurrentRow.Index;

            edtidCambio.Text = dataGridRepuesto.Rows[e.RowIndex].Cells["Código"].Value.ToString();
            edtRepuesto.Text = dataGridRepuesto.Rows[e.RowIndex].Cells["Pieza"].Value.ToString();
            edtCantidad.Text = dataGridRepuesto.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
        }
    }//fin clase
    
}//fin proyec

