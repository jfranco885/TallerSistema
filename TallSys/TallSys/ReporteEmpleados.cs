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
    public partial class ReporteEmpleados : Form
    {
        ReportedeEmpleados rempleados = new ReportedeEmpleados();
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            crEmpleados.ReportSource = rempleados;
        }

        private void crEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
