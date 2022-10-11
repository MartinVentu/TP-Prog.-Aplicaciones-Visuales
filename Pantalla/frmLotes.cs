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
    public partial class frmLotes : Form
    {
        private servicioLotes servicioLotes;
        public frmLotes()
        {
            InitializeComponent();
        }

        private void frmLotes_Load(object sender, EventArgs e)
        {
           servicioLotes = new servicioLotes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if(dtgLote.SelectedRows.Count != 0)
            {
                if(Convert.ToBoolean(MessageBox.Show($"Desea eliminar el lote '{dtgLote.SelectedColumns[0] }","Confirmacion",MessageBoxButtons.YesNo)))
                {
                    Lotes lote = new Lotes();
                    lote.Id_Lote = Convert.ToInt32(dtgLote.CurrentRow.Cells[0].Value);
                    servicioLotes.EliminarLote(lote);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un lote a eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgLote.SelectedRows.Count != 0)
            {
                if (Convert.ToBoolean(MessageBox.Show($"Desea Modificar el lote '{dtgLote.SelectedColumns[0]}", "Confirmacion", MessageBoxButtons.YesNo)))
                {
                    Lotes lote = new Lotes();
                    lote.Id_Lote = Convert.ToInt32(dtgLote.CurrentRow.Cells[0].Value);
                    servicioLotes.ActualizarLote(lote);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un lote a eliminar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
