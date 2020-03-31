using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        //clase principal
       
        //Prueba de conexion este mensaje fue agregado 31/03/2020  a las 11:31

       public static SqlConnection con= new SqlConnection("Data Source=.;Initial Catalog=tallerdb;Integrated Security=True");
        public static DataSet Ejecutar(String consulta)
        {
            //  con = new SqlConnection("Data Source=DESKTOP-G2V0SUK\\SQLEXPRESS;Initial Catalog=tallerdb;Integrated Security=True");//DESKTOP-G2V0SUK\\SQLEXPRESS
            DataSet dataSet = new DataSet();
            try
            {
                con.Open();

                //  MessageBox.Show("Conexión con éxito");
               
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);

                sqlDataAdapter.Fill(dataSet);//llenando el dataset
                con.Close();//cerrando conexión
            }catch(Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
           
            
            return dataSet;
        }//Min Ejecutar

        //Para ver si existe un registro
        public static Boolean Existe(String consulta)
        {
            DataSet dt = null;
            //verificando si existe
            try
            {
               
                dt =Ejecutar(consulta);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al verificar si ya existe" + e.Message);
            }

            if (dt.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fin Existe

        //Método para llenar dataset y ocuparlo en la tabla
        public static DataSet datasetLista(String NombreProcedure)
        {
            DataSet dt=null;
            try
            {
                String consulta = String.Format("exec " + NombreProcedure);
                dt = Ejecutar(consulta);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al al hacer la consulta" + err.Message);
            }

            return dt;
        }

        public static DataSet datasetConsultarProcedure(String procedimientoConsultar,int buscar)        
        {
            DataSet dt = null;
            try
            {
                 String consulta = String.Format("exec " + procedimientoConsultar + " '{0}'", buscar);
                
                dt = Ejecutar(consulta);
            }catch(Exception err)
            {
                MessageBox.Show("Error al al hacer la consulta" + err.Message);
            }
           
           

            return dt;
        }
        public static DataSet datasetConsultarProcedureConCadena(String procedimientoConsultar, String variable)
        {
            DataSet dt = null;
            try
            {
                String consulta = String.Format("exec " + procedimientoConsultar + " '{0}'", variable);

                dt = Ejecutar(consulta);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al al hacer la consulta" + err.Message);
            }



            return dt;
        }
        //Eliminar registro
        public static void eliminarRegistro(String tablaDbNombreProcedure, String id)
        {
            try
            {
                String consulta = String.Format("exec eliminar" + tablaDbNombreProcedure + " '{0}'", id);
                Ejecutar(consulta);
                MessageBox.Show("Se ha eliminado el registro");
            }catch(Exception err)
            {
                MessageBox.Show("Hubo error"+err.Message);
            }
           
        }

        //llenar combobox
        public static DataTable llenarComboBox(String consult)
        {
            // DataTable dt = null;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                con.Open();               
                da.SelectCommand = new SqlCommand(consult, con);
              //  dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al buscar los datos en mi libreria" + er.Message);
            }
            return dt;
        }

      


           public static void llenarCombox(String consult,ComboBox cbox,String nombreCampo,String id )
           {
               try
               {

                   SqlDataReader sqlDataReader;
                   con.Open();
                   SqlCommand consulta =new SqlCommand (consult, con);
                   sqlDataReader = consulta.ExecuteReader();

                   while (sqlDataReader.Read())
                   {
                       cbox.Items.Add(sqlDataReader[nombreCampo].ToString());
                       cbox.ValueMember= sqlDataReader[id].ToString();
                   }
                   con.Close();
               }
               catch (Exception er)
               {
                   MessageBox.Show("Error al buscar los datos en mi libreria" + er.Message);
               }

           }


        /// TRES TRISTE TIGRES COMEN EN TRES TRISTES TRATES Y NO ME ACUERDO LO DEMAS JAJAJAJJA
        /// //comentario franco

       




    }//fin clase
}//Min mi libreria
