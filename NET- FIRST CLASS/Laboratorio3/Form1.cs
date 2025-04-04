using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection() ;
        SqlCommand cmd = new SqlCommand() ;
        SqlDataReader dr=null;

        public Form1()
        {
            InitializeComponent();


        }
        void ConnectionString()
        {
            con.ConnectionString = "Server=Q08LB1104PCINS;Database=BDEMPRESA;Integrated Security=true";
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usu, clav;
            usu=txtUsuario.Text;
            clav=txtClave.Text;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TBUSUARIOS "+" " +
                "WHERE USUARIO='"+usu+"' AND CLAVE='"+clav+"'";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                if (dr.Read())
                {
                    MessageBox.Show("Bienvenido al Sistema");
                }
                else MessageBox.Show("Error al ingresar");
            }
            con.Close();
        }
    }
}
