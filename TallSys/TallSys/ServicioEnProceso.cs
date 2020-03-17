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
    public partial class ServicioEnProceso : ContenedorVentanas
    {
        public ServicioEnProceso()
        {
            InitializeComponent();
        }

        private void ServicioEnProceso_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            MtoCambioPiezas mtoCambioPiezas = new MtoCambioPiezas();
            mtoCambioPiezas.Show();
        }
    }
}
