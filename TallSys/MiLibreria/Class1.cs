using System;
using System.Data;
using System.Data.SqlClient;

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
        }
    }
}
