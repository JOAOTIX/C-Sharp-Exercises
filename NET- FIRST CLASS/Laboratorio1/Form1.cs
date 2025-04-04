using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int altura, area, baset;
            baset=Convert.ToInt16( txtBase.Text);
            altura= Convert.ToInt16(txtAltura.Text);
            area = baset * altura / 2;
            txtArea.Text =area+"";
        }
    }
}
