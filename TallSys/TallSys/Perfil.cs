using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallSys.Properties;
using MiLibreria;
using System.Data.SqlClient;
namespace TallSys
{
    public partial class Perfil : ContenedorVentanas
    {
        public Perfil()
        {
            InitializeComponent();
            edtNombres.Enabled = false;
            edtApellidos.Enabled = false;
            edtCargo.Enabled = false;
            edtUsuario.Enabled = false;
            edtClave.Enabled = false;
            gboxCambiar.Visible = false;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (edtConfirmar.UseSystemPasswordChar == false)
            {
                edtConfirmar.UseSystemPasswordChar = true;
                btnMostrar.Image = Resources.ver;
            }
            else
            {
                edtConfirmar.UseSystemPasswordChar = false;
                btnMostrar.Image = Resources.nover;
            }
        }

        private void btnMostrarCambio_Click(object sender, EventArgs e)
        {
            if (edtClaveCambiar.UseSystemPasswordChar == false)
            {
                edtClaveCambiar.UseSystemPasswordChar = true;
                btnMostrarCambio.Image = Resources.ver;
            }
            else
            {
                edtClaveCambiar.UseSystemPasswordChar = false;
                btnMostrarCambio.Image = Resources.nover;
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            gboxCambiar.Visible = true;
            btnCambiarClave.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gboxCambiar.Visible = false;
            btnCambiarClave.Enabled = true;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtConfirmar)| validarCampo(edtClaveCambiar))
            {
            }else
            {
                //verificando si existe el usuario y la contraseña
                try{
                    SqlConnection conn = Utilidades.con;
                    using (SqlCommand cmd = new SqlCommand("dbo.loginUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Paráetros de entrada
                        cmd.Parameters.AddWithValue("@usuario", edtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@clave", edtConfirmar.Text.Trim());
                        //Parámetro de salida
                        cmd.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@rol", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@idempleado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@iduser", SqlDbType.Int).Direction = ParameterDirection.Output;
                        // open connection and execute stored procedure
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        // read output value from @NewId                      
                        conn.Close();
                        int resultado = Convert.ToInt32(cmd.Parameters["@Result"].Value);
                        //validando la respuesta
                        if (resultado == 1)
                        {
                            int idusuario = Convert.ToInt32(cmd.Parameters["@iduser"].Value);
                            int  rol = Convert.ToInt32(cmd.Parameters["@rol"].Value);
                          String  nombreUsuario = Convert.ToString(cmd.Parameters["@nombre"].Value);
                          int  idempleado = Convert.ToInt32(cmd.Parameters["@idempleado"].Value);

                            //Actualizar
                            try{
                                String consulta = String.Format("EXEC actualizarUsuarios '{0}','{1}','{2}','{3}','{4}'", idusuario, edtUsuario.Text.Trim(), edtClaveCambiar.Text.Trim(), rol, idempleado);
                                Utilidades.Ejecutar(consulta);
                                MessageBox.Show("Se actualizó la contraseña");                               
                            }catch (Exception error)
                            {
                                MessageBox.Show("Ha ocurrido un error" + error.Message);
                            }
                            //fin actualizar
                            gboxCambiar.Visible = false;
                            btnCambiarClave.Enabled = true;
                            edtClaveCambiar.Text = "";
                            edtConfirmar.Text = "";
                        }
                        else{
                            MessageBox.Show("Contraseña de confirmación incorrecta....!!!!");
                            edtClaveCambiar.Text = "";
                            edtConfirmar.Text = "";
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Ha habido un problema" + ex.Message);
                }               
            }           
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

            int idempleado = Form1.idempleado;

            DataSet dt;
            String consulta = String.Format("exec Perfil");
            dt = Utilidades.Ejecutar(consulta);

            edtNombres.Text = (dt.Tables[0].Rows[0]["Nombres"].ToString());
            edtApellidos.Text = (dt.Tables[0].Rows[0]["Apellidos"].ToString());
            edtCargo.Text = (dt.Tables[0].Rows[0]["Cargo"].ToString());
            edtUsuario.Text = (dt.Tables[0].Rows[0]["Usuario"].ToString());
            edtClave.Text = (dt.Tables[0].Rows[0]["Clave"].ToString());
        }

        private void edtConfirmar_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void edtClaveCambiar_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
