using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio4
{
    public partial class FrmLogin : Form
    {

        ConectarBD conectarbd = new ConectarBD();

        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usu, clav;
            usu=txtUsuario.Text;
            clav=txtClave.Text;          
            if (conectarbd.ValidarUsuario(usu,clav))
                {
                    MessageBox.Show("Bienvenido al Sistema"+" "+usu );
                    FrmAlmacen frmAlmacen = new FrmAlmacen();

                    frmAlmacen.ShowDialog();
                }
            else MessageBox.Show("Error al ingresar");
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String usu, clav, estado;

            usu = txtUsuario.Text;
            clav = txtClave.Text;
            estado = "0";

            if (conectarbd.RegistrarUsuario(usu, clav, estado))
            {
                MessageBox.Show("Usuario registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
