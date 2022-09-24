using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPAV.Entidades;
using TPPAV.Servicios;

namespace TPPAV.Pantalla
{
    public partial class frmBarrios : Form
    {
        private servicioBarrio servicio;
        public frmBarrios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Barrios barrio = new Barrios();
                barrio.Nombre = txtBarrio.Text;
                var servicio = new servicioBarrio();
                if(servicio.registrarBarrio(barrio))
                {
                    MessageBox.Show("Barrio registardo con exito");
                }
                else
                {
                    MessageBox.Show("Barrio no se pudo registar");
                }

            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
