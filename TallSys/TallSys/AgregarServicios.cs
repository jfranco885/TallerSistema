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
    public partial class AgregarServicios : ContenedorVentanas
    {
        public AgregarServicios()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AsignarMecanicos asignarMecanicos = new AsignarMecanicos();
            asignarMecanicos.Show();
        }
    }
}
