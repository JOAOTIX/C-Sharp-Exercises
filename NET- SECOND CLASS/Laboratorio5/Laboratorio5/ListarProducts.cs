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
    public partial class ListarProducts : Form
    {
        ConectarBD conectarbd = new ConectarBD();

        public ListarProducts()
        {
            InitializeComponent();
        }

        private void ListarProducts_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listarProductoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AlmacenView almacenView = new AlmacenView();
            almacenView.ShowDialog();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProduct registrarProduct = new RegistrarProduct();
            registrarProduct.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
