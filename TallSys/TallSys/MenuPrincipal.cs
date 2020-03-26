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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            MenuMantenimientos menuMantenimientos =new MenuMantenimientos();
            menuMantenimientos.Show();
        }

        private void btnAgregarServ_Click(object sender, EventArgs e)
        {
            SeleccionServicios seleccionServicios = new SeleccionServicios();
            seleccionServicios.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Arvertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //  this.Close();
                Application.Exit();

            }
        }
    }
}
