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

namespace TPPAV.Pantalla
{
    public partial class frmAgregarLote : Form
    {
        public frmAgregarLote()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarLote_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G10_2022DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bD3K3G10_2022DataSet.Productos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
