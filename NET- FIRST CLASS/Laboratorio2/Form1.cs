using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        double num1, num2,resultado, memoria;
        String ope;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text+"1";
        }

        

        private void button16_Click(object sender, EventArgs e)
        {
            num1=Convert.ToDouble(txtPantalla.Text);
            resultado = num1 * -1;
            txtPantalla.Text=resultado.ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text=txtPantalla.Text+"2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text= txtPantalla.Text+"3";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
            ope = "division";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text=txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
            ope = "resta";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
            ope = "suma";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtPantalla.Text);
            if (ope == "suma")
            {
                resultado = num1 + num2;
            }
            else if (ope == "resta")
            {
                resultado = num1 - num2;
            }
            else if (ope== "multiplicar")
                {
                resultado = num1 * num2;
            }
            else if (ope == "division")
            {
                resultado = num1 / num2;
            }
            txtPantalla.Text = resultado.ToString();
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = memoria.ToString();
        }

        private void btnMresta_Click(object sender, EventArgs e)
        {
            memoria -= Convert.ToDouble(txtPantalla.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btnMsuma_Click(object sender, EventArgs e)
        {
            memoria += Convert.ToDouble(txtPantalla.Text);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "";
            ope = "multiplicar";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }
    }
}
