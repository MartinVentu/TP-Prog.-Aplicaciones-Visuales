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
    public partial class NuevoVendedor : Form
    {
        public NuevoVendedor()
        {
            InitializeComponent();
        }

        private void NuevoVendedor_Load(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNumeroDocVendedor.Text = "";
            txtFechaNacimientoVendedor.Text = "";
            txtTipoDocVendedor.Text = "";
            txtFechaIngresoVendedor.Text = "";
            txtFechaNacimientoVendedor.Text = "";
            txtTelefonoVendedor.Text = "";
            txtNombreVendedor.Text = "";
            txtApellidoVendedor.Text = "";
            txtComisionVendedor.Text = "";

        }

        private void btnLimpiarCamposVendedor_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnCargarVendedor_Click(object sender, EventArgs e)
        {
            string nroDocumentoVend = txtNumeroDocVendedor.Text;
            string tipoDocumentoVend = txtTipoDocVendedor.Text;
            DateTime fechaIngresoVend = DateTime.Today;
            string fechaNacimientoVend = txtFechaNacimientoVendedor.Text;
            string telefonoVend = txtTelefonoVendedor.Text;
            string nombreVend = txtNombreVendedor.Text;
            string apellidoVend = txtApellidoVendedor.Text;
            string comisionVend = txtComisionVendedor.Text;


            //Vendedores vendedor = new Vendedores(nroDocumentoVend, tipoDocumentoVend, fechaIngresoVend, fechaNacimientoVend, telefonoVend, nombreVend, apellidoVend, comisionVend);
            //MessageBox.Show("Datos del vendedor: " + vendedor.NroDocumento + " " + vendedor.TipoDocumento + " " + vendedor.FechaIngreso + " " + vendedor.FechaNacimiento + " " + vendedor.Telefono + " " + vendedor.Nombre + " " + vendedor.Apellido + " " + vendedor.Comision);


        }

    }
}
