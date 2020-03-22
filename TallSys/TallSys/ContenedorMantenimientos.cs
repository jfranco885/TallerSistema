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
    public partial class ContenedorMantenimientos : ContenedorVentanas
    {
        public ContenedorMantenimientos()
        {
            InitializeComponent();
        }

        private void ContenedorMantenimientos_Load(object sender, EventArgs e)
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
        public virtual Boolean guardar()
        {
            return false;
        }
    }//fin class
}//fin Tallsys
