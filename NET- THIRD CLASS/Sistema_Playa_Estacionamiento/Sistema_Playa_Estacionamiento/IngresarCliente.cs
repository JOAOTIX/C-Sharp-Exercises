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
    public partial class IngresarCliente : Form
    {
        ConectarBD conectarBD = new ConectarBD();
        Ticket ticket = new Ticket();
        Cliente cliente = new Cliente();    

        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            cliente.dni = txtDni.Text;
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            ticket.dni = txtDni.Text;
            ticket.placa = txtPlaca.Text;
            ticket.pagado = 0;
            if(conectarBD.RegistrarCliente(cliente) && conectarBD.RegistrarTicket(ticket))
            {
                MessageBox.Show("Cliente registrado correctamente");
                txtDni.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtPlaca.Text = "";
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caja caja = new Caja();
            caja.Show();
        }
    }
}
