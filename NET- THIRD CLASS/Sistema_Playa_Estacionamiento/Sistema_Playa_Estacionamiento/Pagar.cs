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
    public partial class Pagar : Form
    {
        ConectarBD conectarBD = new ConectarBD();

        public Pagar()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
           
            if (!rbBoleta.Checked && !rbFactura.Checked)
            {
                MessageBox.Show("Seleccione un tipo de comprobante");
                return;
            }

            BoletaCab boletaCab = new BoletaCab();
            BoletaDet boletaDet = new BoletaDet();
            BoletaSerie boletaSerie = new BoletaSerie();

            Ticket ticket = new Ticket();

            ticket.placa = txtPlaca.Text;

            if (conectarBD.RegistrarPago(ticket))
            {
                conectarBD.ObtenerTicket(ticket);
                

                if (rbBoleta.Checked)
                {
                    boletaSerie = conectarBD.ObtenerSerie(1); 
                    int siguienteNumero = boletaSerie.cantidad_emitida + 1;
                    boletaCab.numero_boleta = boletaSerie.serie + "-" + siguienteNumero;

                    conectarBD.RegistrarBoletaCab(boletaCab, ticket,boletaSerie);
                    boletaCab.id_boleta = conectarBD.ObtenerIdBoletaCab(ticket);
                    conectarBD.RegistrarBoletaDet(boletaDet, ticket, boletaCab);

                    conectarBD.ActualizarSerie(boletaSerie);
                    conectarBD.ActualizarPagado(ticket);
                    conectarBD.MostrarTicketPagar();
                    MessageBox.Show("Pago registrado correctamente y Boleta emitida");
                }
                else if (rbFactura.Checked)
                {
                    boletaSerie = conectarBD.ObtenerSerie(2);
                    int siguienteNumero = boletaSerie.cantidad_emitida + 1;
                    boletaCab.numero_boleta = boletaSerie.serie + "-" + siguienteNumero;

                    conectarBD.RegistrarBoletaCab(boletaCab, ticket,boletaSerie);
                    boletaCab.id_boleta = conectarBD.ObtenerIdBoletaCab(ticket);
                    conectarBD.RegistrarBoletaDet(boletaDet, ticket, boletaCab);

                    conectarBD.ActualizarSerie(boletaSerie);
                    conectarBD.ActualizarPagado(ticket);
                    conectarBD.MostrarTicketPagar();
                    MessageBox.Show("Pago registrado correctamente y Factura emitida");
                }
               
            }
            else
            {
                MessageBox.Show("Error al registrar el pago");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caja caja = new Caja();
            caja.Show();
        }

        private void Pagar_Load(object sender, EventArgs e)
        {
            dtgwPagar.DataSource = conectarBD.MostrarTicketPagar();
            dtgwPagar.Columns["id"].Visible=false;
            dtgwPagar.Columns["pagado"].Visible = false;
            dtgwPagar.Columns["dni"].HeaderText = "Dni del cliente";
            dtgwPagar.Columns["nombre"].HeaderText = "Nombre completo";
            dtgwPagar.Columns["apellido"].HeaderText = "Apellido";
            dtgwPagar.Columns["placa"].HeaderText = "Placa del vehiculo";
            dtgwPagar.Columns["fecha_ingreso"].HeaderText = "Fecha de ingreso";
            dtgwPagar.Columns["fecha_salida"].HeaderText = "Fecha de salida";
            dtgwPagar.Columns["hora_ingreso"].HeaderText = "Hora de ingreso";
            dtgwPagar.Columns["hora_salida"].HeaderText = "Hora de salida";
            dtgwPagar.Columns["minutos"].HeaderText = "Tiempo de estacionamiento";
            dtgwPagar.Columns["total"].HeaderText = "Monto total a pagar";
        }

        private void btnBoletas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boletas boletas = new Boletas();
            boletas.Show();
        }
    }
}
