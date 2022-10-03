using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPAV.Pantalla
{
    public partial class frmLotes : Form
    {
        public frmLotes()
        {
            InitializeComponent();
        }

        private void frmLotes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3K3G10_2022DataSet.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.bD3K3G10_2022DataSet.Proveedores);
            // TODO: This line of code loads data into the 'bD3K3G10_2022DataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.bD3K3G10_2022DataSet.Productos);
            // TODO: This line of code loads data into the 'bD3K3G10_2022DataSet.Lotes' table. You can move, or remove it, as needed.
            this.lotesTableAdapter.Fill(this.bD3K3G10_2022DataSet.Lotes);


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proveedoresTableAdapter.FillBy(this.bD3K3G10_2022DataSet.Proveedores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      
    }
}
