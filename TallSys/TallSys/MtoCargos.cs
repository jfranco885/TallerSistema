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
    public partial class MtoCargos : ContenedorMantenimientos
    {
        public MtoCargos()
        {
            
            InitializeComponent();

            edtIdCargo.Enabled = false;
            edtCargo.Enabled = false;
            
            tabla.DataSource = Utilidades.datasetLista("listarCargos").Tables[0];

        }

        private void MtoCargos_Load(object sender, EventArgs e)
        {

        }

       public override void guardar()
        {
            if (validarCampo(edtCargo))
            {
                //solo mandara el error provider si está vacío
            }
            else { 
            Boolean existe;
            String edtcargo = edtCargo.Text.Trim();
            String consul =String.Format("select *from cargo where cargo='{0}'", edtcargo);
            existe =  Utilidades.Existe(consul);

            if (existe == false)
            {
                try
                {
                    String consulta = String.Format("EXEC insertarCargo '{0}'", edtcargo);
                    Utilidades.Ejecutar(consulta);
                    MessageBox.Show("Se han guardado los datos");
                        edtCargo.Enabled = false;
                        btnGuardar.Enabled = false;
                        limpiarCampos();
                        tabla.DataSource = Utilidades.datasetLista("listarCargos").Tables[0];
                    }
                catch (Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error" + e.Message);
                }

            }
            else//si existe
            {
                MessageBox.Show("Este cargo ya existe");
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
                    Utilidades.eliminarRegistro("Cargo", edtIdCargo.Text);//envio el complemento del nombre del proc almacenado y el id del que quiero eliminar
                    limpiarCampos();
                    edtCargo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabla.DataSource = Utilidades.datasetLista("listarCargos").Tables[0];

                }catch (Exception errr)
            {
                MessageBox.Show("Ha ocurrido un error" + errr.Message);
            }
        }
           
        }


       

        private new void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            edtCargo.Enabled = true;
            edtCargo.Focus();
           
        }

        private new void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!validarSoloNumeros(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                try { 
                String edtbuscar = edtBuscar.Text.Trim();
                DataSet dt;
                String consul = String.Format("select *from cargo where idcargo='{0}'", edtbuscar);
              dt= Utilidades.Ejecutar(consul);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    edtIdCargo.Text=(dt.Tables[0].Rows[0]["idcargo"].ToString().Trim());
                    edtCargo.Text = (dt.Tables[0].Rows[0]["cargo"].ToString().Trim());

                    edtCargo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Este cargo no existe");
                        limpiarCampos();
                        edtCargo.Enabled = false;
                   
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
            if (validarCampo(edtCargo))
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

                        String consulta = String.Format("EXEC actualizarCargo '{0}','{1}'", edtIdCargo.Text, edtCargo.Text);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se actualizaron los datos");
                        edtCargo.Enabled = false;
                        btnEditar.Enabled = false;
                        btnEliminar.Enabled = false;
                        tabla.DataSource = Utilidades.datasetLista("listarCargos").Tables[0];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Ha ocurrido un error" + error.Message);
                    }
                    limpiarCampos();
                }
            }
        }
        private void edtCargo_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void limpiarCampos()
        {
            edtBuscar.Text = ("");
            edtIdCargo.Text = ("");
            edtCargo.Text = ("");
        }

       
    }//final class
}//final tallsys
