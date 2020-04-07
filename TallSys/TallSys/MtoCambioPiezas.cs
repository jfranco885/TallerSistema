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
    public partial class MtoCambioPiezas : ContenedorMantenimientos
    {
        public MtoCambioPiezas()
        {
            InitializeComponent();
            cargarTabla();
            desactivarControles();
            edtidCambio.Enabled = false;
        }

        public override void guardar()
        {
            if (validarCampo(edtIdServicio)| validarCampo(edtRepuesto) | !validarSoloNumeros(edtCantidad))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String idServicio = edtIdServicio.Text.Trim();
                String consul = String.Format("select *from detalle_servicios where iddetalle_servicio='{0}'", idServicio);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    //Hacer la inserción
                    try
                    {
                        String consulta = String.Format("EXEC insertarCambioPieza '{0}','{1}','{2}'", edtRepuesto.Text.Trim(), edtIdServicio.Text.Trim(), Convert.ToInt16(edtCantidad.Text.Trim()));
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        limpiarCampos();
                        cargarTabla();
                        desactivarControles();
                        btnGuardar.Enabled = false;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ha ocurrido un error" + er.Message);
                    }

                }
                else
                {
                    MessageBox.Show("No existe este id de Cambio de Piezas");
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
                    Utilidades.eliminarRegistro("CambioPieza", edtidCambio.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    desactivarControles();
                    cargarTabla();
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;

                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
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
                try
                {
                    String edtbuscar = edtBuscar.Text.Trim();
                    DataSet dt;
                    String consul = String.Format("select *from cambio_piezas where idcambio_pieza='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        edtIdServicio.Text = (dt.Tables[0].Rows[0]["iddetalle_servicio"].ToString().Trim());
                        edtidCambio.Text = (dt.Tables[0].Rows[0]["idcambio_pieza"].ToString().Trim());
                        edtRepuesto.Text = (dt.Tables[0].Rows[0]["nombre_pieza"].ToString().Trim());
                        edtCantidad.Text = (dt.Tables[0].Rows[0]["cantidad"].ToString().Trim());

                        activarControles();
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este id de cambio de pieza no existe");
                        limpiarCampos();
                       

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
            if (validarCampo(edtIdServicio) | validarCampo(edtRepuesto) | !validarSoloNumeros(edtCantidad))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String idServicio = edtIdServicio.Text.Trim();
                String consul = String.Format("select *from detalle_servicios where iddetalle_servicio='{0}'", idServicio);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    //Hacer la inserción
                    try
                    {
                        String consulta = String.Format("EXEC actualizarCambioPieza '{0}','{1}','{2}','{3}'",edtidCambio.Text, edtRepuesto.Text.Trim(), edtIdServicio.Text.Trim(), Convert.ToInt16(edtCantidad.Text.Trim()));
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han actualizado los datos");
                        limpiarCampos();
                        cargarTabla();
                        desactivarControles();
                        btnEliminar.Enabled = false;
                        btnEditar.Enabled = false;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ha ocurrido un error" + er.Message);
                    }

                }
                else
                {
                    MessageBox.Show("No existe este id de Servicio");
                }
            }
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            activarControles();
            edtIdServicio.Focus();
        }
        private void MtoCambioPiezas_Load(object sender, EventArgs e)
        {

        }
        private void cargarTabla()
        {
            tabla.DataSource = Utilidades.datasetLista("listarCambioPieza").Tables[0];
        }

        private void activarControles()
        {
            edtIdServicio.Enabled = true;
            edtRepuesto.Enabled = true;
            edtCantidad.Enabled = true;
        }
        private void desactivarControles()
        {
                edtIdServicio.Enabled = false;
                edtRepuesto.Enabled = false;
                edtCantidad.Enabled = false;
            
        }

        private void limpiarCampos()
        {

            edtIdServicio.Text = "";
            edtRepuesto.Text = "";
            edtCantidad.Text = "";
            edtBuscar.Text = "";
            edtidCambio.Text = "";

        }

        private void edtRepuesto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtCantidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtIdServicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyecto
