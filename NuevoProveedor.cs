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

namespace TPPAV
{
    public partial class NuevoProveedor : Form
    {
        public NuevoProveedor()
        {
            InitializeComponent();        
        }

        private void NuevoProveedor_Load(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void btnLimpiarCamposProveedor_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {

            txtCuilProveedor.Text = "";
            txtApellidoProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtBarrioProveedor.Text = "";
            txtCalleProveedor.Text = "";
            txtNumeroCalleProveedor.Text = ""; 
            txtTelefonoProveedor.Text = ""; 

        }

        public void btnCargarProveedor_Click(object sender, EventArgs e)
        {

            string cuil = txtCuilProveedor.Text;
            string apellidoProv = txtApellidoProveedor.Text;
            string nombreProv = txtNombreProveedor.Text;
            string barrioProv = txtBarrioProveedor.Text;
            string calleProv = txtCalleProveedor.Text;
            string nroCalleProv = txtNumeroCalleProveedor.Text;
            string telefonoProv = txtTelefonoProveedor.Text;

            //Proveedores proveedor = new Proveedores(cuil, apellidoProv, nombreProv, barrioProv, calleProv, nroCalleProv, telefonoProv);
            //MessageBox.Show("Datos del nuevo proveedor: " + proveedor.Cuil + " " + proveedor.Apellido + " " + proveedor.Nombre + " " + proveedor.Barrio + " " + proveedor.Calle + " " + proveedor.NroCalle + " " + proveedor.Telefono);


        }
    }
}
