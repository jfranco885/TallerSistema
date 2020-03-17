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
    public partial class SeleccionServicios : Form
    {
        public SeleccionServicios()
        {
            InitializeComponent();
        }

        private void SeleccionServicios_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            AgregarServicios agregarServicios = new AgregarServicios();
            this.Hide();
            agregarServicios.Show();
        }

        private void btnServEjecutandose_Click(object sender, EventArgs e)
        {
            ServiciosEjecutandose serviciosEjecutandose = new ServiciosEjecutandose();
            this.Hide();
            serviciosEjecutandose.Show();
        }
    }
}
