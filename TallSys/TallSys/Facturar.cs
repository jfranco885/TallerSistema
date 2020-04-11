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
    public partial class Facturar : ContenedorVentanas
    {
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarCliente = new BuscarCliente();
            buscarCliente.ShowDialog();

            if (buscarCliente.DialogResult == DialogResult.OK)
            {
                String idcliente = buscarCliente.dataGridClientes.Rows[buscarCliente.dataGridClientes.CurrentRow.Index].Cells[0].Value.ToString();
                String nombre = buscarCliente.dataGridClientes.Rows[buscarCliente.dataGridClientes.CurrentRow.Index].Cells[1].Value.ToString();
                String apellido = buscarCliente.dataGridClientes.Rows[buscarCliente.dataGridClientes.CurrentRow.Index].Cells[2].Value.ToString();
                String dui = buscarCliente.dataGridClientes.Rows[buscarCliente.dataGridClientes.CurrentRow.Index].Cells[3].Value.ToString();

                txtCliente.Text = nombre + " " + apellido;
                txtDui.Text = dui;
                txtIdCliente.Text = idcliente;

            }
        }
    }
}
