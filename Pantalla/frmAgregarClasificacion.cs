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
using TPPAV.Repositorios;

namespace TPPAV.Pantalla
{
    public partial class frmAgregarClasificacion : Form
    {
        public frmAgregarClasificacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            repositorioClasificacionesUso repositorio = new repositorioClasificacionesUso();
            if(txtClasificacion.Text != null)
            {
                ClasificacionesUsos clasificacion = new ClasificacionesUsos();
                clasificacion.Descripcion = txtClasificacion.Text;
                if(repositorio.ConsultarClasificacion(clasificacion).Count == 0)
                {
                    repositorio.RegistrarClasificacion(clasificacion);
                }
                else
                {
                    MessageBox.Show("La clasificacion de uso ya existe");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una descpcion a registrar");
            }
        }
    }
}
