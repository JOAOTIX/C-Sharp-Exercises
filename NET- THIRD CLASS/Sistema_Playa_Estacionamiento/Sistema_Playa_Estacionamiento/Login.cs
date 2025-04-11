using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Playa_Estacionamiento.Class.DataBase;
using Sistema_Playa_Estacionamiento.Class.Users;



namespace Sistema_Playa_Estacionamiento
{
    public partial class Login : Form
    {
        ConectarBD conectarBD = new ConectarBD();
        Personal per = new Personal();

        public Login()
        {
            InitializeComponent();
        }



        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            per.user = txtUser.Text;
            per.password = txtPassword.Text;
            if (conectarBD.ValidarPersonal(per))
            {
                MessageBox.Show("Bienvenido al sistema " +per.user);
                this.Hide();
                IngresarCliente ingresarCliente = new IngresarCliente();
                ingresarCliente.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

            Registrar registrar = new Registrar();
            this.Hide();
            registrar.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
