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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBarrios frmBarrios = new frmBarrios();
            frmBarrios.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var servicio = new servicioBarrio();
                var barrios = servicio.consultarBArrios();
                if (barrios.Count !=0)
                {
                    foreach (Barrios barrio in barrios)
                    {
                        var fila = new string[]
                        {
                            barrio.Id_barrio.ToString(),
                            barrio.Nombre
                        };
                        dataGridView1.Rows.Add(fila);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ningun barrio");
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD3K3G10_2022DataSet.Vendedores' table. You can move, or remove it, as needed.
            this.vendedoresTableAdapter.Fill(this.bD3K3G10_2022DataSet.Vendedores);

        }
    }
    }

