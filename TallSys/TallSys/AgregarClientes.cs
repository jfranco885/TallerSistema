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
    public partial class AgregarClientes : ContenedorVentanas
    {
        String edtidcliente;
        String edtnombres;
        String edtapellidos;
        String edtdui;
        String edttelefono;
        String edtdireccion;
        String edtcorreo;

        public AgregarClientes()
        {
            InitializeComponent();
            dataGridClientes.DataSource = Utilidades.datasetLista("Clientes").Tables[0];
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtNombres) | validarCampo(edtApellidos) | validarCampo(edtDui) |
              validarCampo(edtTelefono) | validarCampo(edtDireccion))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                edtnombres = edtNombres.Text.Trim();
                edtapellidos = edtApellidos.Text.Trim();
                edtdui = edtDui.Text.Trim();
                edttelefono = edtTelefono.Text.Trim();
                edtdireccion = edtDireccion.Text.Trim();
                edtcorreo = edtCorreo.Text.Trim();

                String consul = String.Format("select *from clientes where dui='{0}'", edtdui);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarClientes '{0}','{1}','{2}','{3}'" +
                            ",'{4}','{5}'", edtnombres, edtapellidos, edtdui, edttelefono, edtdireccion, edtcorreo);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");

                       

                        //  desactivarControlesC();
                        //  btnGuardar.Enabled = false;
                        //   limpiarCampos();
                        //   tabla.DataSource = Utilidades.datasetLista("Clientes").Tables[0];//actualizando tabla
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

        private void edtTelefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtDireccion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
