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
    public partial class Registrar : Form
    {
        ConectarBD conectarBD = new ConectarBD();
        Personal per = new Personal();
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            per.user = txtUser.Text;
            per.password = txtPassword.Text;

            if(conectarBD.RegistrarPersonal(per))
            {
                MessageBox.Show("Usuario registrado correctamente");
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
