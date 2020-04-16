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
    public partial class ReporteFacturas : Form
    {
        ReportedeFacturas rfac = new ReportedeFacturas();
        
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {

          crfacturas.ReportSource = rfac;
        }

        private void crfacturas_Load(object sender, EventArgs e)
        {

        }
    }
}
