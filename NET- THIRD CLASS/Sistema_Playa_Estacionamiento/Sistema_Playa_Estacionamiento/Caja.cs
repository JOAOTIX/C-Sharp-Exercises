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
    public partial class Caja : Form
    {
        ConectarBD conectarBD = new ConectarBD();
        public Caja()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarCliente ingresarCliente = new IngresarCliente();
            ingresarCliente.Show();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            dtgwTicket.DataSource= conectarBD.MostrarTicket();
            dtgwTicket.Columns["dni"].HeaderText = "Dni del cliente";
            dtgwTicket.Columns["nombre"].HeaderText = "Nombre Completo";
            dtgwTicket.Columns["apellido"].HeaderText = "Apellido";
            dtgwTicket.Columns["placa"].HeaderText = "Placa del vehiculo";
            dtgwTicket.Columns["fecha_ingreso"].HeaderText = "Fecha de ingreso";
            dtgwTicket.Columns["hora_ingreso"].HeaderText = "Hora de ingreso";


        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.placa = txtPlaca.Text;

            conectarBD.ObtenerTicket(ticket);

            if (conectarBD.RegistrarSalida(ticket))
            {
                MessageBox.Show("Salida registrada correctamente");
                txtPlaca.Text = "";
                dtgwTicket.DataSource = conectarBD.MostrarTicket();
            }
            else
            {
                MessageBox.Show("Error al registrar la salida");
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagar pagar = new Pagar();
            pagar.Show();
        }
    }
}
