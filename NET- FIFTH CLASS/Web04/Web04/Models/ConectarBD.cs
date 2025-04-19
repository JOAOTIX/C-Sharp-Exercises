using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Web04.Models
{
    public class ConectarBD
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;

        public string server = "localhost";
        public string puerto = "3306";
        public string database = "dbempresa";
        public string uid = "root";
        public string password = "usbw";
        // GET: Seguridad
        void ConnectionString()
        {
            string constring;
            constring = "SERVER=" + server + ";" + "PORT=" + puerto + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(constring);
        }

        public Boolean AgregarUsuario(User usu)
        {
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO TBUSUARIOS(USER,PASSWORD) VALUES('"+ usu.user + "','" + usu.password +"')";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                dr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean AgregarProducto(Producto prod)
        {
            ConnectionString();
            con.Open();
            cmd.Connection= con;
            cmd.CommandText = "INSERT INTO TBPRODUCTOS(PRODUCTO,PRECIO,STOCK,ESTADO) VALUES('"+prod.name+"',"+prod.price+","+prod.stock+","+0+")";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                dr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Producto CosultarIdProducto(int code)
        {
                Producto producto = new Producto();
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TBPRODUCTOS WHERE CODIGO="+code;
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {

                producto.code = Convert.ToInt16(dr["CODIGO"]);
                    producto.name = dr["PRODUCTO"].ToString();
                    producto.price = Convert.ToDouble(dr["PRECIO"]);
                    producto.stock = Convert.ToInt16(dr["STOCK"]);
                    producto.state = Convert.ToInt16(dr["ESTADO"]);
   
            }
            con.Close();
            return producto;
        }
        public Boolean ActualizarProducto(Producto prod)
        {
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE TBPRODUCTOS SET PRODUCTO='"+prod.name+"',PRECIO="+prod.price+",STOCK="+prod.stock+",ESTADO="+0+" WHERE CODIGO="+prod.code+"";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                dr.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EliminarProducto(int cod)
        {
            ConnectionString();
            con.Open(); 
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM TBPRODUCTOS WHERE  CODIGO="+cod+"";
            dr = cmd.ExecuteReader();
            if(dr != null)
            {
                dr.Close(); 
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Producto> ListarProducto()
        {
            List<Producto> list = new List<Producto>();
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TBPRODUCTOS";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Producto()
                {
                    code = Convert.ToInt16(dr["CODIGO"]),
                    name = dr["PRODUCTO"].ToString(),
                    price = Convert.ToDouble(dr["PRECIO"]),
                    stock = Convert.ToInt16(dr["STOCK"]),
                    state = Convert.ToInt16(dr["ESTADO"]),
                });
            }
            con.Close();
            return list;
        }
        public List<User> ListarUser()
        {
            List<User> list = new List<User>();
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM TBUSUARIO";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new User()
                {
                    id = Convert.ToInt16(dr["ID"]),
                    user = dr["USER"].ToString(),
                    password = dr["Password"].ToString(),
                });


            }
            con.Close();
            return list;
        }
    }
}