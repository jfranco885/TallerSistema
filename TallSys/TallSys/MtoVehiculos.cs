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
    public partial class MtoVehiculos : ContenedorMantenimientos
    {
        public MtoVehiculos()
        {
            InitializeComponent();
            edtId.Enabled = false;
            edtFecha.Enabled = false;
            desactivarControles();

            tabla.DataSource = Utilidades.datasetLista("Vehiculo").Tables[0];
        }

        private void MtoVehiculos_Load(object sender, EventArgs e)
        {
            cboxMarca.DataSource = Utilidades.llenarComboBox("select idmarca,marca from marca");
            cboxMarca.DisplayMember = "marca";
            cboxMarca.ValueMember = "idmarca";

            cboxModelo.DataSource = Utilidades.llenarComboBox("select idmodelo,modelo from modelo");
            cboxModelo.DisplayMember = "modelo";
            cboxModelo.ValueMember = "idmodelo";

        }

        public override void guardar()
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
                       
                        String consulta = String.Format("EXEC insertarVehiculo '{0}','{1}','{2}'", marca,modelo,placa);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        desactivarControles();
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("Vehiculo").Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" + e.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este vehiculo ya existe");
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
                    Utilidades.eliminarRegistro("Vehiculo", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControles();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("Vehiculo").Tables[0];

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
            activarControles();
            edtPlaca.Focus();
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
                String consul = String.Format("select idvehiculo,mar.idmarca as Marca,mo.modelo as Modelo,placa,fecha_creacion from vehiculo as v inner join marca as mar on v.idmarca = mar.idmarca inner join modelo as mo on v.idmodelo = mo.idmodelo  where placa='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);


                if (dt.Tables[0].Rows.Count > 0)
                {

                    edtId.Text = (dt.Tables[0].Rows[0]["idvehiculo"].ToString().Trim());                    
                    cboxMarca.Text = (dt.Tables[0].Rows[0]["Marca"].ToString().Trim());
                    cboxModelo.Text = (dt.Tables[0].Rows[0]["Modelo"].ToString().Trim());
                    edtPlaca.Text = (dt.Tables[0].Rows[0]["placa"].ToString().Trim());
                    edtFecha.Text = (dt.Tables[0].Rows[0]["fecha_creacion"].ToString().Trim());


                    activarControles();
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Este Vehículo no existe");
                    limpiarCampos();
                    desactivarControles();
                }


            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtPlaca))
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
                        int marca = Convert.ToInt16(cboxMarca.SelectedValue);
                        int modelo = Convert.ToInt16(cboxModelo.SelectedValue);
                        String placa = edtPlaca.Text.Trim();
                        


                        String consulta = String.Format("EXEC actualizarVehiculo '{0}','{1}','{2}','{3}'", id, marca,modelo,placa);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        desactivarControles();
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("Vehiculo").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }
                    limpiarCampos();
                }
            }
        }
        private void edtPlaca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void limpiarCampos()
        {
            edtBuscar.Text = "";
            edtId.Text = "";
            edtFecha.Text = "";
            edtPlaca.Text = "";
        }

        private void desactivarControles()
        {
            cboxMarca.Enabled = false;
            cboxModelo.Enabled = false;
            edtPlaca.Enabled = false;
        }
        private void activarControles()
        {
            cboxMarca.Enabled = true;
            cboxModelo.Enabled = true;
            edtPlaca.Enabled = true;
        }

        
    }//fin clase
}//fin proyect
