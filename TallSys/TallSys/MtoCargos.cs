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
       
         

       

        private void edtCargo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edtCargo.Enabled = true;
            edtCargo.Focus();
            btnGuardar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtBuscar))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                
                String edtbuscar = edtBuscar.Text.Trim();
                DataSet dt;
                String consul = String.Format("select *from cargo where idcargo='{0}'", edtbuscar);
              dt= Utilidades.Ejecutar(consul);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    edtIdCargo.Text=(dt.Tables[0].Rows[0]["idcargo"].ToString().Trim());
                    edtCargo.Text = (dt.Tables[0].Rows[0]["cargo"].ToString().Trim());
                }
                else
                {
                    MessageBox.Show("Este cargo no existe");
                }


            }
        }

        private void edtBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }//final class
}//final tallsys
