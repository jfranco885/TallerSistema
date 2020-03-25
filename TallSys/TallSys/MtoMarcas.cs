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
    public partial class MtoMarcas : ContenedorMantenimientos
    {
        public MtoMarcas()
        {
            InitializeComponent();
            edtIdMarca.Enabled = false;
            edtMarca.Enabled = false;

            tabla.DataSource = Utilidades.datasetLista("Marca").Tables[0];
        }
    }
}
