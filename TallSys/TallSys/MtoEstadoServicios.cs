﻿using System;
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
    public partial class MtoEstadoServicios : ContenedorMantenimientos
    {
        public MtoEstadoServicios()
        {
            InitializeComponent();
            edtId.Enabled = false;
            edtEstado.Enabled = false;

            tabla.DataSource = Utilidades.datasetLista("listarEstado").Tables[0];
        }

        private void MtoEstadoServicios_Load(object sender, EventArgs e)
        {

        }


        public override void guardar()
        {
            if (validarCampo(edtEstado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String edtestado = edtEstado.Text.Trim();
                String consul = String.Format("select *from estado where estado='{0}'", edtestado);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        String consulta = String.Format("EXEC insertarEstado '{0}'", edtestado);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        edtEstado.Enabled = false;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarEstado").Tables[0];
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" + e.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este Estado ya existe");
                }
            }
        }
        public override void eliminar()
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    Utilidades.eliminarRegistro("Estado", edtId.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    edtEstado.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("listarEstado").Tables[0];

                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }
            }

        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            edtEstado.Enabled = true;
            edtEstado.Focus();
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                try
                {
                    String edtbuscar = edtBuscar.Text.Trim();
                    DataSet dt;
                    String consul = String.Format("select *from estado where estado='{0}'", edtbuscar);
                    dt = Utilidades.Ejecutar(consul);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        edtId.Text = (dt.Tables[0].Rows[0]["idestado"].ToString().Trim());
                        edtEstado.Text = (dt.Tables[0].Rows[0]["estado"].ToString().Trim());

                        edtEstado.Enabled = true;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este estado no existe");
                        limpiarCampos();
                        edtEstado.Enabled = false;
                    }
                }
                catch (Exception errr)
                {
                    MessageBox.Show("Ha ocurrido un error" + errr.Message);
                }

            }
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (validarCampo(edtEstado))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere Modificar el Registro?", "Modificar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    try
                    {

                        String consulta = String.Format("EXEC actualizarEstado '{0}','{1}'", edtId.Text, edtEstado.Text);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        edtEstado.Enabled = false;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("listarEstado").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }
                    limpiarCampos();
                }
            }
        }
        private void limpiarCampos()
        {
            edtBuscar.Text = (""); 
            edtId.Text = ("");
            edtEstado.Text = ("");
        }

        private void edtEstado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }//fin clase
}//fin proyecto
