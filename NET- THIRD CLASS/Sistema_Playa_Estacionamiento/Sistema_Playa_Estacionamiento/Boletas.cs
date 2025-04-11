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

namespace Sistema_Playa_Estacionamiento
{
    public partial class Boletas : Form
    {
        ConectarBD conectarBD = new ConectarBD();

        public Boletas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagar pagar = new Pagar();
            pagar.Show();
        }

        private void Boletas_Load(object sender, EventArgs e)
        {
            dtgwBoletas.DataSource = conectarBD.MostrarBoletas();
            dtgwBoletas.Columns["numero_boleta"].HeaderText = "Numero de la boleta";
            dtgwBoletas.Columns["fecha_emision"].HeaderText = "Fecha de emisión";
            dtgwBoletas.Columns["dni_cliente"].HeaderText = "Dni del cliente";
            dtgwBoletas.Columns["nombre"].HeaderText = "Nombre completo";
            dtgwBoletas.Columns["apellido"].HeaderText = "Apellido";
            dtgwBoletas.Columns["descripcion"].HeaderText = "Descripción del servicio";
            dtgwBoletas.Columns["cantidad"].HeaderText = "Cantidad";
            dtgwBoletas.Columns["precio_unitario"].HeaderText = "Precio por minuto";
            dtgwBoletas.Columns["subtotal"].HeaderText = "Subtotal";
            dtgwBoletas.Columns["igv"].HeaderText = "IGV(18%)";
            dtgwBoletas.Columns["total"].HeaderText = "Total a pagar";


        
        }
    }
}
