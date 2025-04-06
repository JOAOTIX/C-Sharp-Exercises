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
    public partial class AlmacenView : Form
    {
        ConectarBD conectarbd = new ConectarBD();

        public AlmacenView()
        {
            InitializeComponent();
        }

        private void dtgwProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AlmacenView_Load(object sender, EventArgs e)
        {
            List<Producto> listado = new List<Producto>();
            listado = conectarbd.ListarProductos();
            dtgwProductos.DataSource = listado;
        }
    }
}
