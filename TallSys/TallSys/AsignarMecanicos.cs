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
    public partial class AsignarMecanicos : ContenedorVentanas
    {
        
        public AsignarMecanicos()
        {
            InitializeComponent();
            dataGridMecSinAsignar.DataSource = Utilidades.datasetLista("listarEmpleadosQuePuedeDisponerse").Tables[0];
        }

        private void AsignarMecanicos_Load(object sender, EventArgs e)
        {

        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtEmpleado))
            {

            }
            else
            {
                Boolean existe;
                String idEmpleado = edtEmpleado.Text.Trim();
                String consul = String.Format("select *from empleados where idempleado='{0}'", idEmpleado);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    //verificando si no esta empleado en otro servicio
                    Boolean disponible;
                    String consular = String.Format("select estado from detalle_emp_serv where estado = 1 and idempleado='{0}'", idEmpleado);
                    disponible = Utilidades.Existe(consular);

                    if (disponible == false)
                    {
                        try
                        {
                            String idDetallerSer = txtIdServicio.Text.Trim();

                            int estado = 1;
                            String consulta = String.Format("EXEC insertarAsignarMecanico '{0}','{1}','{2}'", idDetallerSer, idEmpleado, estado);
                            Utilidades.Ejecutar(consulta);
                            MessageBox.Show("Se han guardado los datos");
                            cargarTablas();

                            edtEmpleado.Text = "";

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Ha ocurrido un error" + er.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este empleado no está disponible");
                    }
                }
                else//si existe
                {
                    MessageBox.Show("Este empleado no existe");
                }

            }
        }

        public void cargarTablas()
        {
            dataGridMecanicoAsignado.DataSource = Utilidades.datasetConsultarProcedure("listarMecanicosAsignados", Convert.ToInt16(txtIdServicio.Text)).Tables[0];
            dataGridMecSinAsignar.DataSource = Utilidades.datasetLista("listarEmpleadosQuePuedeDisponerse").Tables[0];

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarTablas();
        }
    }//fin clase
}//fin proyecto
