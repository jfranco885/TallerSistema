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
    public partial class ServiciosEjecutandose : ContenedorVentanas
    {
        public ServiciosEjecutandose()
        {
            InitializeComponent();
            dataGridServEjecutandose.DataSource = Utilidades.datasetLista("listarServiciosEjecutandose").Tables[0];
        }

        private void ServiciosEjecutandose_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtIdServicio) == true)
            {

            }
            else
            {
                Boolean existe;
                String idServicio = edtIdServicio.Text.Trim();
                String consul = String.Format("select *from detalle_servicios where iddetalle_servicio='{0}'", idServicio);
                existe = Utilidades.Existe(consul);

                if (existe == true)
                {
                    try
                    {
                        txtIdServicio servicioEnProceso = new txtIdServicio();
                        //enviando datos al otro formulario
                        servicioEnProceso.txtServicio.Text = edtIdServicio.Text.Trim();
                        servicioEnProceso.dataGridRepuesto.DataSource = Utilidades.datasetConsultarProcedure("listarCambioPiezaPorIdServicio", Convert.ToInt16(edtIdServicio.Text.Trim())).Tables[0];


                        DataSet dt;
                        dt = Utilidades.datasetConsultarProcedure("listarServiciosEnProceso", Convert.ToInt16(edtIdServicio.Text.Trim()));
                        // String consulax = String.Format("select ds.idencabezado_servicio as IdEncabezadoServicio,ds.iddetalle_servicio as IdServicio,est.estado as Estado,cli.nombres_cliente + ' ' + cli.apellidos_cliente as Cliente,tiposerv.nombre_servicio as TipoServicio,tiposerv.tiempo_hr_establecido as TiempoEstablecidoPorHoras,dnavetipo.idnave as Nave,CAST(ds.fecha_creacion as varchar) as TiempoInicio,ds.tiempo_hr_real as TiempoDiagnosticado,detemplserv.estado as Activo,ds.diagnostico as Diagnostico,ds.detalle_actividad_realizada as Actividad from detalle_servicios as ds inner join estado as est on ds.idestado = est.idestado inner join encabezado_servicio as encas on ds.idencabezado_servicio = encas.idencabezado_servicio inner join detalle_vehiculo as dvehi on encas.iddetalle_vehiculo = dvehi.iddetalle_vehiculo inner join clientes as cli on dvehi.idcliente = cli.idcliente inner join detalle_nave_tiposervicio as dnavetipo on ds.iddetalle_nave_tiposervicio = dnavetipo.iddetalle_nave_tiposervicio inner join tipo_servicios as tiposerv on dnavetipo.idtipo_servicio = tiposerv.idtipo_servicio inner join detalle_emp_serv as detemplserv on detemplserv.iddetalle_servicio = ds.iddetalle_servicio where ds.iddetalle_servicio = '{0}'", edtIdServicio.Text.Trim());

                        //  dt = Utilidades.Ejecutar(consulax);
                        servicioEnProceso.edtTipoServicio.Text = (dt.Tables[0].Rows[0]["TipoServicio"].ToString().Trim());
                        servicioEnProceso.edtCliente.Text = (dt.Tables[0].Rows[0]["Cliente"].ToString().Trim());

                        servicioEnProceso.edtActividad.Text = (dt.Tables[0].Rows[0]["Actividad"].ToString().Trim());
                        servicioEnProceso.edtDiagnostico.Text = (dt.Tables[0].Rows[0]["Diagnostico"].ToString().Trim());
                        servicioEnProceso.edtEstadoActual.Text = (dt.Tables[0].Rows[0]["Estado"].ToString().Trim());
                        servicioEnProceso.edtNave.Text = (dt.Tables[0].Rows[0]["Nave"].ToString().Trim());
                        servicioEnProceso.edtTiempoEstablecido.Text = (dt.Tables[0].Rows[0]["TiempoEstablecidoPorHoras"].ToString().Trim());
                        servicioEnProceso.edtTiempoReal.Text = (dt.Tables[0].Rows[0]["TiempoDiagnosticado"].ToString().Trim());
                        servicioEnProceso.txtServicio.Text = (dt.Tables[0].Rows[0]["IdServicio"].ToString().Trim());
                        servicioEnProceso.edtIdTipoServNave.Text = (dt.Tables[0].Rows[0]["idAsignacionNaveTipoServicio"].ToString().Trim());
                        servicioEnProceso.edtDescripcion.Text = (dt.Tables[0].Rows[0]["Descripcion"].ToString().Trim());

                        servicioEnProceso.txtEncabezado.Text = (dt.Tables[0].Rows[0]["IdEncabezadoServicio"].ToString().Trim());
                        servicioEnProceso.edtCantidad.Text = (dt.Tables[0].Rows[0]["Cantidad"].ToString().Trim());



                        servicioEnProceso.ShowDialog();
                    }catch(Exception err)
                    {
                        MessageBox.Show("Error "+err.Message);
                    }
                }
                else//si existe
                {
                    MessageBox.Show("Este servicio no se ha creado");
                }
            }
        }
        private void edtIdServicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dataGridServEjecutandose.DataSource = Utilidades.datasetLista("listarServiciosEjecutandose").Tables[0];

        }

        private void rdbMisServicios_CheckedChanged(object sender, EventArgs e)
        {
           // Form1 form = new Form1();
            int idempleado =Form1.idempleado;
            dataGridServEjecutandose.DataSource = Utilidades.datasetConsultarProcedure("listarServEjecutandoseIdEmpleado",idempleado).Tables[0];

        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridServEjecutandose.DataSource = Utilidades.datasetLista("listarServiciosEjecutandose").Tables[0];
        }
    }
}
