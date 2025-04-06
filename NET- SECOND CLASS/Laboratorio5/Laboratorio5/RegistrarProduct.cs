using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio5.Class;

namespace Laboratorio5
{
    public partial class RegistrarProduct : Form
    {
        ConectarBD conectarbd = new ConectarBD();
        Producto prod = new Producto();
        public RegistrarProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            prod.codigo = Convert.ToInt16(txtCode.Text);
            prod.producto = txtName.Text;
            prod.stock = Convert.ToInt16(txtStock.Text);
            prod.precioC = Convert.ToDecimal(txtPcompra.Text);
            prod.precioV = Convert.ToDecimal(txtPventa.Text);
            prod.categoria = txtCate.Text;
            if (conectarbd.RegistrarProducto(prod)) 
            {
                MessageBox.Show("Producto registrado correctamente");
                txtCode.Clear();
                txtName.Clear();
                txtStock.Clear();
                txtPventa.Clear();
                txtPcompra.Clear();
                txtCate.Clear();
            }
            else
            {
                MessageBox.Show("Error al registrar producto unu");
            }


        }
    }
}
