using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio4
{
    public partial class FrmAlmacen : Form
    {
        ConectarBD conectarbd=new ConectarBD();
        
        public FrmAlmacen()
        {
            InitializeComponent();

        }

        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            List<Producto> listado = new List<Producto>();
            listado = conectarbd.ListarProductos();
            dtgwProductos.DataSource = listado;
        }
    }
}
