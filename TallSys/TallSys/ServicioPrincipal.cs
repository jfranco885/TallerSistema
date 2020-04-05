using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MiLibreria;

namespace TallSys
{
    public partial class ServicioPrincipal : ContenedorVentanas
    {
     
        int idcliente;
        int idvehiculo;
        public ServicioPrincipal()
        {
            InitializeComponent();
            edtVehiculo.Enabled = false;
            edtCliente.Enabled = false;
            edtIdCliente.Enabled = false;
            edtIdVehiculo.Enabled = false;
        }

        private void ServicioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            AgregarClientes agregarClientes = new AgregarClientes();
            agregarClientes.ShowDialog();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            AgregarVehiculos agregarVehiculos = new AgregarVehiculos();
            agregarVehiculos.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtBuscarC))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                try
                {
                    String edtbuscar = edtBuscarC.Text.Trim();
                    DataSet dt;
                    String consul = String.Format("select *from clientes where dui='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        String nombre = edtCliente.Text = (dt.Tables[0].Rows[0]["nombres_cliente"].ToString().Trim());
                        String apellido = edtCliente.Text = (dt.Tables[0].Rows[0]["apellidos_cliente"].ToString().Trim());
                        edtIdCliente.Text = (dt.Tables[0].Rows[0]["idcliente"].ToString().Trim());

                        edtCliente.Text = nombre + " " + apellido;



                    }
                    else
                    {
                        MessageBox.Show("Este cliente no existe");

                    }
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }

            }

        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtBuscarV))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {

                String edtbuscar = edtBuscarV.Text.Trim();
                DataSet dt;
                String consul = String.Format("select idvehiculo,mar.idmarca as Marca,mo.modelo as Modelo,placa,fecha_creacion from vehiculo as v inner join marca as mar on v.idmarca = mar.idmarca inner join modelo as mo on v.idmodelo = mo.idmodelo  where placa='{0}'", edtbuscar);
                dt = Utilidades.Ejecutar(consul);


                if (dt.Tables[0].Rows.Count > 0)
                {
                    String marca = (dt.Tables[0].Rows[0]["Marca"].ToString().Trim());
                    // String modelo= (dt.Tables[0].Rows[0]["Modelo"].ToString().Trim());
                    String placa = (dt.Tables[0].Rows[0]["placa"].ToString().Trim()); ;

                    edtIdVehiculo.Text = (dt.Tables[0].Rows[0]["idvehiculo"].ToString().Trim());
                    edtVehiculo.Text = "Marca: " + marca + " Placa: " + placa;





                }
                else
                {
                    MessageBox.Show("Este Vehículo no existe");

                }


            }
        }

        private void edtBuscarC_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtBuscarV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtIdCliente) | validarCampo(edtIdVehiculo))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                int clienteId = Convert.ToInt32(edtIdCliente.Text.Trim());
                int vehiculoId = Convert.ToInt32(edtIdVehiculo.Text.Trim());

                try
                {
                    SqlConnection con = Utilidades.con;
                    
                    // using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G2V0SUK\\SQLEXPRESS;Initial Catalog=tallerdb;Integrated Security=True"))
                    
                    using (SqlCommand cmd = new SqlCommand("dbo.insertarEncab_DetVehiculo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Paráetros de entrada
                        cmd.Parameters.AddWithValue("@idvehiculo", vehiculoId);
                        cmd.Parameters.AddWithValue("@idcliente", clienteId);
                        //Parámetro de salida
                        cmd.Parameters.Add("@idServicioEncabezado", SqlDbType.Int).Direction = ParameterDirection.Output;


                        // open connection and execute stored procedure
                        con.Open();
                        cmd.ExecuteNonQuery();

                        // read output value from @NewId                      
                        con.Close();
                        int idSerGenerado = Convert.ToInt32(cmd.Parameters["@idServicioEncabezado"].Value);
                        edtCodigoSer.Text = idSerGenerado.ToString();
                        edtCodigoServicio.Text = idSerGenerado.ToString();
                    }




                    limpiarCampos();

                }
                catch (Exception er)
                {
                    MessageBox.Show("Ha ocurrido un error" + er.Message);
                }


            }

        }
        private void limpiarCampos()
        {
            edtVehiculo.Text = "";
            edtCliente.Text = "";
            edtIdCliente.Text = "";
            edtIdVehiculo.Text = "";
            edtBuscarC.Text = "";
            edtBuscarV.Text = "";
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {


            if (validarCampo(edtCodigoServicio))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String idencabezado = edtCodigoServicio.Text.Trim();
                String consul = String.Format("select *from encabezado_servicio where idencabezado_servicio='{0}'", idencabezado);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    AgregarServicios agregarServicios = new AgregarServicios();

                    agregarServicios.dataGridServiciosAgregados.DataSource = Utilidades.datasetConsultarProcedure("listarServiciosPorencabezados",Convert.ToInt16(edtCodigoServicio.Text.Trim())).Tables[0];

                    agregarServicios.edtIdServicioEncabezado.Text = edtCodigoServicio.Text.Trim();
                    agregarServicios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se ha creado este encabezado de Servicio");
                }

            }
        }

        private void edtCodigoServicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        

    }//fin clase
}//fin proyect
