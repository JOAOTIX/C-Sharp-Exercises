using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Laboratorio5.Class
{
     class ConectarBD
    {

        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr = null;
        public void ConnectionString()
        {
            string server = "localhost";
            string puerto = "3306";
            string basededatos = "dbempresa";
            string user = "root";
            string clave = "usbw";
            string cadena;
            cadena = "SERVER=" + server + ";" + "PORT=" + puerto + ";" + "DATABASE=" + basededatos +
                ";" + "UID=" + user + ";" + "PASSWORD=" + clave + ";";
            con = new MySqlConnection(cadena);
        }
        public List<Producto> ListarProductos()
        {
            List<Producto> lstproductos = new List<Producto>();
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbproductos ";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    lstproductos.Add(new Producto
                    {
                        codigo = Convert.ToInt16(dr["ID"]),
                        producto = dr["NOMBRE"].ToString(),
                        stock = Convert.ToInt16(dr["STOCK"]),
                        precioC = Convert.ToDecimal(dr["PCOMPRA"]),
                        precioV = Convert.ToDecimal(dr["PVENTA"]),
                        categoria = (dr["CATEGORIA"].ToString())
                    });
                }
            }
            con.Close();
            return lstproductos;
        }
        public Boolean ValidarUsuario(string usu, string clav)
        {
            Boolean resultado = false;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tbusuarios WHERE " + "" +
                "USUARIO='" + usu + "' AND CLAVE='" + clav + "'";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                if (dr.Read())
                {
                    resultado = true;
                }
                else resultado = false;
            }
            con.Close();
            return resultado;
        }
        public Boolean RegistrarUsuario(string usu, string clav, string state)
        {
            Boolean resultado = false;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tbusuarios(USUARIO,CLAVE,ESTADO) VALUES('" + usu + "','" + clav + "','" + state + "')";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            con.Close();
            return resultado;
        }
        public Boolean RegistrarProducto(Producto prod)
        {
            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tbproductos(ID,NOMBRE,STOCK,PCOMPRA,PVENTA,CATEGORIA)" +
                " VALUES("+prod.codigo+",'"+prod.producto+"',"+prod.stock+","+prod.precioC+","+prod.precioV+",'"+prod.categoria+"')";
            res = cmd.ExecuteNonQuery();
            if (res >0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            con.Close();
            return resultado;
        }
    }
}
