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
        private Double total = 0.0;
            
        public static string idCliente;
        public Facturar()
        {
            InitializeComponent();
            txtTotal.Text = total.ToString();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIdCliente.Text))
            {
                idCliente = txtIdCliente.Text;

                SeleccionarServicios seleccionarServicios = new SeleccionarServicios();
                seleccionarServicios.ShowDialog();

                if (seleccionarServicios.DialogResult == DialogResult.OK)
                {
                    String idEncabezadoServ= seleccionarServicios.txtEncabezado.Text;
                    String idservicio = seleccionarServicios.txtIdServicio.Text;
                    String idTipoServicio = seleccionarServicios.txtCodigoTipoServ.Text;
                    String tipoServicio = seleccionarServicios.txtTipoServicio.Text;
                    Double precio =Convert.ToDouble(seleccionarServicios.txtPrecio.Text);
                    Double cantidad = Convert.ToDouble(seleccionarServicios.txtCantidad.Text);
                    Double descuento = Convert.ToDouble(seleccionarServicios.edtDescuento.Text);

                    Double subTotal = 0.0;
                    
                    

                    //verificando si ya fue agregado el id servicio
                    Boolean existe = false;                   
                   
                        for (int i = 0;   i <datagridFacturar.Rows.Count; i++)
                        {
                            if (datagridFacturar.Rows[i].Cells[0].Value.ToString() == idservicio)
                            {
                                existe = true;
                            }
                        }                   

                    if (existe == false)//Si no se ha agregado el id servicio
                    {
                        subTotal = (precio * cantidad) - descuento;
                        total = total + subTotal;
                        //Enviando los datos
                        txtIdEncabezadoServ.Text = idEncabezadoServ;

                        datagridFacturar.Rows.Add(idservicio, idTipoServicio, tipoServicio, cantidad, precio, descuento, subTotal);
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Este Servicio ya se agregó");
                    }
                       

                }//Fin resulDialog
            }
            else
            {
                MessageBox.Show("Primero tiene que seleccionar un cliente");
            }
            
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (datagridFacturar.Rows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro seleccionado?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    String restarSubTotal = datagridFacturar.Rows[datagridFacturar.CurrentRow.Index].Cells[6].Value.ToString();
                    datagridFacturar.Rows.RemoveAt(datagridFacturar.CurrentRow.Index);

                    total = total - Convert.ToDouble(restarSubTotal);
                    txtTotal.Text = total.ToString();
                }
            }
        }
        //Limpiar campos
        private void limpiarCampos()
        {
            txtCliente.Text = "";
            txtIdCliente.Text = "";
            txtIdEncabezadoServ.Text = "";
            txtDui.Text = "";
            txtIdEncabezadoServ.Text = "";
            datagridFacturar.Rows.Clear();
            txtTotal.Text = "";

            total = 0.0;
        }
    }//fin clase
}//fin proyec
