using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallSys
{
    public partial class ContenedorVentanas : Form
    {
        MenuPrincipal menuPrincipal= new MenuPrincipal();
        public ContenedorVentanas()
        {
            InitializeComponent();
           
        }

        private void ContenedorVentanas_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Form1.nombreUsuario;
        }

        public virtual void editar()
        {

        }
        public virtual void eliminar()
        {

        }
        public virtual void nuevo()
        {

        }
        public virtual void buscar()
        {

        }
        public virtual void listar()
        {

        }
        public virtual void guardar()
        {
            
        }
       
        //VALIDAR CAMPO VACÍO

        public Boolean validarCampo(TextBox campo)
        {
            Boolean vacio = false;
            if (campo.Text == "")
            {
                vacio = true;
                errorProvider1.SetError(campo, "Debe ingresar datos");
            }
            return vacio;
        }//fin validar campo vacío

        //VALICANDO COMBOX VACIO
        public Boolean validarCombox(ComboBox cbox)
        {
            Boolean vacio = false;
            if (cbox.Text == "")
            {
                vacio = true;
                errorProvider1.SetError(cbox, "Debe Seleccionar una opción");
            }
            return vacio;
        }//fin validar campo vacío

        //Validar solo números
        public Boolean validarSoloNumeros(TextBox campo)
        {
          
            try
            {
                
                Double numero = Convert.ToDouble(campo.Text.Trim());
                // Double resultado =  numero / 1;
               
                return true;//son solo números
            }
            catch
            {
                errorProvider1.SetError(campo, "Debe ingresar dato numérico");
                return false;//Significa que se ha ingresado letras
            }
        }
        public Boolean tieneItems(ComboBox cbox)
        {
            if (cbox.Items.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void btnSalir_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Está seguro que desea salir?","Arvertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
              //  this.Close();
                Application.Exit();

            }
        }

        
    }//fin class
}//fin tallsys
