using System;
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

namespace TallSys
{
    public partial class Form1 : Form
    {
        Hash llamar = new Hash();
        public Form1()
        {
            InitializeComponent();
        }

        public static string codigo = "";
        public static string eltipo = "";
        public static int rol=0;
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampo(txtusuario) | validarCampo(txtclave))
            {
                //mostrar ellor vacio
            }
            else { 
            try
            {
                string cmd = string.Format("select * from usuarios where usuario='{0}' and clave='{1}'",txtusuario.Text.Trim(),llamar.PassHash(txtclave.Text.Trim()));
              DataSet  ds = Utilidades.Ejecutar(cmd);

                codigo = ds.Tables[0].Rows[0]["idusuario"].ToString().Trim();
                string usuario = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string clave = ds.Tables[0].Rows[0]["clave"].ToString().Trim();
                rol = Convert.ToInt32(eltipo=ds.Tables[0].Rows[0]["idrol"].ToString().Trim());

                if (usuario==txtusuario.Text.Trim() && clave == llamar.PassHash(txtclave.Text.Trim())) {

                    if (rol==1) {
                     MenuPrincipal menuPrincipal = new MenuPrincipal();
                     this.Hide();
                      menuPrincipal.Show();

                    }
                    else
                    {
                        MenuPrincipal menuPrincipal = new MenuPrincipal();
                        this.Hide();
                        menuPrincipal.Show();

                        // MessageBox.Show("Bienvenido Usuario"+usuario);
                    }

                }
                else{
                    MessageBox.Show("EL usuario o contraseña son incorrectos....!!!!");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Credenciales incorrectas");
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
    }//fin clase
}//fin proyecto
