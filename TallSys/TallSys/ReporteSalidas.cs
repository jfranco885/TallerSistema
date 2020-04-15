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
    public partial class ReporteSalidas : Form
    {
        ReportedeSalidas rsalida = new ReportedeSalidas();


        public ReporteSalidas()
        {
            InitializeComponent();
        }

        private void ReporteSalidas_Load(object sender, EventArgs e)
        {
            crSalidas.ReportSource = rsalida;
        }
    }
}
