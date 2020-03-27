using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace TallSys
{
    public partial class AgregarServicios : ContenedorVentanas
    {
        public AgregarServicios()
        {
            InitializeComponent();
            dataGridServiciosAgregados.DataSource = Utilidades.datasetConsultarProcedure("listarServiciosPorencabezados", "1").Tables[0];
        }
        private void AgregarServicios_Load(object sender, EventArgs e)
        {
           

             cboxTipoServicio.DataSource = Utilidades.llenarComboBox("select idtipo_servicio,nombre_servicio from tipo_servicios");
             cboxTipoServicio.DisplayMember = "nombre_servicio";
             cboxTipoServicio.ValueMember = "idtipo_servicio";

            cboxNave.DataSource = Utilidades.llenarComboBox("select idnave from nave");
            cboxNave.DisplayMember = "idnave";
            cboxNave.ValueMember = "idnave";





        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AsignarMecanicos asignarMecanicos = new AsignarMecanicos();
            asignarMecanicos.Show();
        }

       
    }//fin clase
}//fin proyec
