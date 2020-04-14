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
    public partial class MenuPrincipal : Form
    {
       
        public MenuPrincipal()
        {
            InitializeComponent();
           
            
        }
        
        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            MenuMantenimientos menuMantenimientos =new MenuMantenimientos();

            menuMantenimientos.ShowDialog();
        }

        private void btnAgregarServ_Click(object sender, EventArgs e)
        {
            SeleccionServicios seleccionServicios = new SeleccionServicios();
            
            seleccionServicios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Arvertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //  this.Close();
                Application.Exit();

            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // string cmd = "select * from usuarios where idusuario="+Form1.codigo;
            //  DataSet ds = Utilidades.Ejecutar(cmd);

            //  txtUsuario.Text = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();

           

            if (Form1.rol == 4) {

                btnAgregarServ.Visible = true;
                btnMantenimientos.Visible = true;
                btnReportes.Visible = true;
                btnSalir.Visible = true;

            }
            else{
                btnAgregarServ.Visible = true;
                btnMantenimientos.Visible = true;
                btnReportes.Visible = false;
                btnSalir.Visible = true;

            }



        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.ShowDialog();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Facturar facturar = new Facturar();
            facturar.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReporteClientes rcli = new ReporteClientes();
            rcli.ShowDialog();
        }
    }
}
