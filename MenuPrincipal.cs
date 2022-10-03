using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPAV
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoProveedor ventanaproveedor = new NuevoProveedor();
            ventanaproveedor.Show();
        }

        private void nuevoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoVendedor ventanavendedor = new NuevoVendedor();
            ventanavendedor.Show();
        }


    }
}
