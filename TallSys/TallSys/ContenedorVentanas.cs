﻿using System;
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
    public partial class ContenedorVentanas : Form
    {
        public ContenedorVentanas()
        {
            InitializeComponent();
        }

        private void ContenedorVentanas_Load(object sender, EventArgs e)
        {

        }

        public virtual void editar()
        {

        }
        public virtual void eliminar()
        {

        }
        public virtual void nuevo()
        {

        }
        public virtual void buscar()
        {

        }
        public virtual void listar()
        {

        }
        public virtual void guardar()
        {
            
        }
        //VALIDAR CAMPO VACÍO

        public Boolean validarCampo(TextBox campo)
        {
            Boolean vacio = false;
            if (campo.Text == "")
            {
                vacio = true;
                errorProvider1.SetError(campo, "Debe ingresar datos");
            }
            return vacio;
        }//fin validar campo vacío
    }//fin class
}//fin tallsys
