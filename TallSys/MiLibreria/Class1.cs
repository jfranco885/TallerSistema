using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(String consulta)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G2V0SUK\\SQLEXPRESS;Initial Catalog=tallerdb;Integrated Security=True");

            con.Open();
            //  MessageBox.Show("Conexión con éxito");
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, con);
            
            sqlDataAdapter.Fill(dataSet);//llenando el dataset
            con.Close();//cerrando conexión
            
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
        public static DataSet datasetLista(String tablaDbNombreProcedure)
        {
            DataSet dt;
            String consulta = String.Format("exec listar"+ tablaDbNombreProcedure);
            dt = Ejecutar(consulta);

            return dt;
        }

        //Eliminar registro
        public static void eliminarRegistro(String tablaDbNombreProcedure, String id)
        {
            String consulta = String.Format("exec eliminar"+ tablaDbNombreProcedure + " '{0}'",id);
            Ejecutar(consulta);
            MessageBox.Show("Se ha eliminado el registro");
        }
      
    }//fin clase
}//Min mi libreria
