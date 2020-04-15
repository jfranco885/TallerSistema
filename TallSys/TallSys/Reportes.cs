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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteClientes rp = new ReporteClientes();
            rp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteEntradas reporte = new ReporteEntradas();
            reporte.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReporteSalidas re3 = new ReporteSalidas();
            re3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteFacturas rfacturas = new ReporteFacturas();
            rfacturas.ShowDialog();
        }
    }
}
