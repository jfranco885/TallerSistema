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
    public partial class AgregarVehiculos : ContenedorVentanas
    {
        public AgregarVehiculos()
        {
            InitializeComponent();
            dataGridVehiculos.DataSource = Utilidades.datasetLista("Vehiculo").Tables[0];
        }

        private void AgregarVehiculos_Load(object sender, EventArgs e)
        {
            

            cboxMarca.DataSource = Utilidades.llenarComboBox("select idmarca,marca from marca");
            cboxMarca.DisplayMember = "marca";
           // cboxMarca.ValueMember = "idmarca";

            cboxModelo.DataSource = Utilidades.llenarComboBox("select idmodelo,modelo from modelo");
            cboxModelo.DisplayMember = "modelo";
           // cboxModelo.ValueMember = "idmodelo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtPlaca))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String placa = edtPlaca.Text.Trim();

                String consul = String.Format("select *from vehiculo where placa='{0}'", placa);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        int marca = Convert.ToInt16(cboxMarca.SelectedValue);
                        int modelo = Convert.ToInt16(cboxModelo.SelectedValue);

                        String consulta = String.Format("EXEC insertarVehiculo '{0}','{1}','{2}'", marca, modelo, placa);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        
                       // desactivarControles();
                       // btnGuardar.Enabled = false;
                       // limpiarCampos();
                       // tabla.DataSource = Utilidades.datasetLista("Vehiculo").Tables[0];
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ha ocurrido un error" + er.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este vehiculo ya existe");
                }
            }

        }

        private void edtPlaca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
    }

