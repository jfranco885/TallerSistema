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
    public partial class AgregarVehiculos : ContenedorVentanas
    {
        public AgregarVehiculos()
        {
            InitializeComponent();
            dataGridVehiculos.DataSource = Utilidades.datasetLista("listarVehiculo").Tables[0];
        }

        private void AgregarVehiculos_Load(object sender, EventArgs e)
        {
            llenarCombox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampo(edtPlaca)|validarCombox(cboxMarca)|validarCombox(cboxModelo))
            {
                //solo mandara el error provider si está vacío
            }
            else
            {
                Boolean existe;
                String placa = edtPlaca.Text.Trim();

                String consul = String.Format("select *from vehiculo where placa='{0}'", placa);
                existe = Utilidades.Existe(consul);

                if (existe == false)
                {
                    try
                    {
                        int marca = Convert.ToInt16(cboxMarca.SelectedValue);
                        int modelo = Convert.ToInt16(cboxModelo.SelectedValue);

                        String consulta = String.Format("EXEC insertarVehiculo '{0}','{1}','{2}'", marca, modelo, placa);
                        Utilidades.Ejecutar(consulta);
                        MessageBox.Show("Se han guardado los datos");
                        
                       // desactivarControles();
                       // btnGuardar.Enabled = false;
                       // limpiarCampos();
                        dataGridVehiculos.DataSource = Utilidades.datasetLista("listarVehiculo").Tables[0];
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Ha ocurrido un error" + er.Message);
                    }

                }
                else//si existe
                {
                    MessageBox.Show("Este vehiculo ya existe");
                }
            }

        }

        private void edtPlaca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void EventoMarca(object sender, EventArgs e)
        {
            if (tieneItems(cboxMarca) == false)
            {
                MessageBox.Show("No hay opciones de marca");
            }
        }

        private void eventoModelo(object sender, EventArgs e)
        {
            if (tieneItems(cboxModelo) == false)
            {
                MessageBox.Show("No hay opciones de Modelo");
            }
        }

        private void btnCrearMarca_Click(object sender, EventArgs e)
        {
            MtoMarcas mtoMarcas = new MtoMarcas();
            mtoMarcas.btnBuscar.Visible = false;
            mtoMarcas.btnEliminar.Visible = false;
            mtoMarcas.btnEditar.Visible = false;
            mtoMarcas.btnNuevo.Visible = true;
            mtoMarcas.edtBuscar.Visible = false;
            mtoMarcas.txtBuscar.Visible = false;
            mtoMarcas.label1.Visible = false;

                      
   
            mtoMarcas.ShowDialog();
            llenarCombox();
        }
        private void btnCrearModelo_Click(object sender, EventArgs e)
        {
            MtoModelos mtoModelos = new MtoModelos();
            mtoModelos.btnBuscar.Visible = false;
            mtoModelos.btnEliminar.Visible = false;
            mtoModelos.btnEditar.Visible = false;
            mtoModelos.btnNuevo.Visible = true;
            mtoModelos.edtBuscar.Visible = false;

            mtoModelos.txtBuscarModel.Visible = false;
            mtoModelos.label1.Visible = false;

            
            

            mtoModelos.ShowDialog();
            llenarCombox();
        }

        //lenar conbox
        private void llenarCombox()
        {
            cboxMarca.DataSource = Utilidades.llenarComboBox("select idmarca,marca from marca");
            cboxMarca.DisplayMember = "marca";
            cboxMarca.ValueMember = "idmarca";

            cboxModelo.DataSource = Utilidades.llenarComboBox("select idmodelo,modelo from modelo");
            cboxModelo.DisplayMember = "modelo";
            cboxModelo.ValueMember = "idmodelo";
        }

       
    }
    }

