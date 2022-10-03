using System;
using System.Windows.Forms;
using TPPAV.Entidades;

namespace TPPAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Text, txtContraseña.Text);
            //MessageBox.Show("Hola" + " " + usu.NombreDeUsuario + " " + usu.Password);

            string usuarioCorrecto = "Martin";
            string contraCorrecta = "1234";

            if (txtUsuario.Text.Equals(usuarioCorrecto) && txtContraseña.Text.Equals(contraCorrecta))
            {
                //Usuario y pwd correctos
                //MessageBox.Show("Datos correctos!");

                MenuPrincipal ventana = new MenuPrincipal();
                ventana.Show();
                this.Hide();

            }
            else
            {
                //Usuario o pwd no correctos
                MessageBox.Show("Ingrese valores correctos");
            }
        }
    }
}