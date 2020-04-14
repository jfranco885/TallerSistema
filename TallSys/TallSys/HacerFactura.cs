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
    public partial class HacerFactura : Form
    {
        public HacerFactura()
        {
            InitializeComponent();
        }

        private void HacerFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.listarPorEncabezadoFactura' Puede moverla o quitarla según sea necesario.
          //  this.listarPorEncabezadoFacturaTableAdapter.Fill(this.DataSetFactura.listarPorEncabezadoFactura);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.listarPorEncabezadoFactura' Puede moverla o quitarla según sea necesario.
            //this.listarPorEncabezadoFacturaTableAdapter.Fill(this.DataSetFactura.listarPorEncabezadoFactura);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.listarPorEncabezadoFactura' Puede moverla o quitarla según sea necesario.
            //  this.listarPorEncabezadoFacturaTableAdapter.Fill(this.DataSetFactura.listarPorEncabezadoFactura);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura.listarPorEncabezadoFactura' Puede moverla o quitarla según sea necesario.
            // this.listarPorEncabezadoFacturaTableAdapter.Fill(this.DataSetFactura.listarPorEncabezadoFactura);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
