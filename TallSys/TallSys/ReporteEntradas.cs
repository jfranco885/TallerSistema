﻿using System;
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
    public partial class ReporteEntradas : Form
    {

        ReportedeEntradas rentradas = new ReportedeEntradas();

        public ReporteEntradas()
        {
            InitializeComponent();
        }

        private void ReporteEntradas_Load(object sender, EventArgs e)
        {
          crEntradas.ReportSource = rentradas;
        }
    }
}
