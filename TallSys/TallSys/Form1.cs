﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;
using System.Resources;
using TallSys.Properties;

namespace TallSys
{
    public partial class Form1 : Form
    {
        public static string codigo = "";
        public static string eltipo = "";
        public static int rol = 0;
        public static string nombreUsuario = "";
        public static int idempleado = 0;

       // Hash llamar = new Hash();
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampo(txtusuario) | validarCampo(txtclave))
            {
                //mostrar ellor vacio
            }
            else { 
            try
            {
                    
                        SqlConnection conn = Utilidades.con;

                    // using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G2V0SUK\\SQLEXPRESS;Initial Catalog=tallerdb;Integrated Security=True"))

                    using (SqlCommand cmd = new SqlCommand("dbo.loginUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Paráetros de entrada
                        cmd.Parameters.AddWithValue("@usuario", txtusuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@clave", txtclave.Text.Trim());
                        //Parámetro de salida
                        cmd.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@rol", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar,50).Direction = ParameterDirection.Output;
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
                            rol = Convert.ToInt32(cmd.Parameters["@rol"].Value);
                            nombreUsuario = Convert.ToString(cmd.Parameters["@nombre"].Value);
                            idempleado= Convert.ToInt32(cmd.Parameters["@idempleado"].Value);

                            MenuPrincipal menuPrincipal = new MenuPrincipal();
                            this.Hide();
                            menuPrincipal.Show();
                            //Validando el rol, Traer el rol en una variable de retorno
                           
                            if (rol == 4)
                                {
                                   
                                    this.Hide();
                                    menuPrincipal.Show();

                                }
                                else
                                {
                                   
                                    this.Hide();
                                    menuPrincipal.Show();

                                    // MessageBox.Show("Bienvenido Usuario"+usuario);
                                }

                            menuPrincipal.txtUsuario.Text = nombreUsuario;

                           
                           
                        }
                        else
                        {
                            MessageBox.Show("EL usuario o contraseña son incorrectos....!!!!");
                        }

                    }                  

                }
                catch (Exception ex)
            {
                MessageBox.Show("Ha habido un problema"+ex.Message);
            }

            }

        }
        //VALIDAR CAMPO VACÍO

        public Boolean validarCampo(TextBox campo)
        {
            Boolean vacio = false;
            if (campo.Text == "")
            {
                vacio = true;
                errorProvider2.SetError(campo, "Debe ingresar datos");
            }
            return vacio;
        }//fin validar campo vacío

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(txtclave.UseSystemPasswordChar == false)
            {
                txtclave.UseSystemPasswordChar = true;
                btnMostrar.Image = Resources.ver;
            }
            else
            {
                txtclave.UseSystemPasswordChar = false;
                btnMostrar.Image = Resources.nover;
            }
            
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }
    }//fin clase
}//fin proyecto
