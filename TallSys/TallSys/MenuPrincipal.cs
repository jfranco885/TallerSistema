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
            AgregarServicios agregarServicios = new AgregarServicios();
            agregarServicios.Show();
        }
    }
}
