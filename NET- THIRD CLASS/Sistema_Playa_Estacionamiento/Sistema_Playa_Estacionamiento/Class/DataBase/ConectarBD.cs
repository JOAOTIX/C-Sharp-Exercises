using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema_Playa_Estacionamiento.Class.Users;

namespace Sistema_Playa_Estacionamiento.Class.DataBase
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
            string basededatos = "bdplaya";
            string user = "root";
            string clave = "usbw";
            string cadena;
            cadena = "SERVER=" + server + ";" + "PORT=" + puerto + ";" + "DATABASE=" + basededatos +
                ";" + "UID=" + user + ";" + "PASSWORD=" + clave + ";";
            con = new MySqlConnection(cadena);
        }
        public Boolean ValidarPersonal(Personal per)
        {
            Boolean resultado = false;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM usuarios WHERE " + "" +
                "user='" + per.user + "'AND password='"+per.password+"'";
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
        public Boolean RegistrarPersonal(Personal per)
        {
            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO usuarios(user,password) VALUES('" + per.user + "','" + per.password  + "')";
            res = cmd.ExecuteNonQuery();
            if (res > 0)
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
        public Boolean RegistrarCliente(Cliente cli)
        {
            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO clientes(dni,nombre,apellido) " +
                "VALUES('" + cli.dni + "','" + cli.nombre + "','"+cli.apellido+"')";
            res = cmd.ExecuteNonQuery();
            if (res > 0)
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
        public Boolean RegistrarTicket(Ticket tic)
        {
            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tickets(placa,fecha_ingreso,hora_ingreso,pagado,dni_clientes) " +
                "VALUES('" + tic.placa + "','" + tic.fecha_ingreso.ToString("yyyy-MM-dd") + "','" + tic.hora_ingreso.ToString() + "',"+tic.pagado+",'"+tic.dni+"')";
            res = cmd.ExecuteNonQuery();
            if (res > 0)
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
        public Boolean ObtenerTicket(Ticket tic)
        {
            Boolean resultado = false;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT fecha_ingreso,hora_ingreso,id_ticket,dni_clientes FROM tickets  WHERE placa= '"+tic.placa+"'  ";
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                if (dr.Read())
                {
                    tic.fecha_ingreso = dr.GetDateTime(0);
                    tic.hora_ingreso = dr.GetTimeSpan(1);
                    tic.id = dr.GetInt32(2);
                    tic.dni = dr.GetString(3);
                }
                else resultado = false;
            }
            con.Close();
            return resultado;
        }
        public Boolean RegistrarSalida(Ticket tic)
        {
          
            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE tickets " +
                "set fecha_salida='"+ tic.fecha_salida.ToString("yyyy-MM-dd")+"', hora_salida='"+tic.hora_salida.ToString()+"', minutos='"+tic.minutos.ToString()+"', pagado="+1+" WHERE placa='"+ tic.placa+"' " ;
            Console.WriteLine(cmd.CommandText);
            res = cmd.ExecuteNonQuery();
            if (res > 0)
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
        public Boolean RegistrarPago(Ticket tic)
        {

            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE tickets SET pagado=" + 2 + " WHERE placa='" + tic.placa + "' ";
            Console.WriteLine(cmd.CommandText);
            res = cmd.ExecuteNonQuery();
            if (res > 0)
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

        public BoletaSerie ObtenerSerie(int idSerie)
        {
            BoletaSerie serie = null;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM boleta_serie WHERE id_serie = " + idSerie;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                serie = new BoletaSerie()
                {
                    id = dr.GetInt32(0),
                    serie = dr.GetString(1),
                    cantidad_emitida = dr.GetInt32(2)
                };
            }

            con.Close();
            return serie;
        }

        public int ObtenerIdBoletaCab(Ticket ticket)
        {
            int idBoleta = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id_boleta FROM boleta_cab WHERE id_ticket="+ticket.id+"";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                idBoleta = dr.GetInt32(0);
            }

            con.Close();
            return idBoleta;
        }

        public bool ActualizarSerie(BoletaSerie serie)
        {
            bool resultado = false;
            int res = -1;

            int nuevoNumero = serie.cantidad_emitida + 1;

            ConnectionString();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE boleta_serie SET cantidad_emitida = " + nuevoNumero + " WHERE id_serie = " + serie.id;
            res = cmd.ExecuteNonQuery();

            con.Close();

            if (res > 0)
            {
                resultado = true;
            }

            return resultado;
        }
        public bool RegistrarBoletaCab(BoletaCab boleta,Ticket ticket,BoletaSerie serie)
        {
            bool resultado = false;
            int res = -1;
            string numeroBoleta = serie.serie + "-" + serie.cantidad_emitida.ToString();
            
            double sub_total = ticket.minutos.TotalMinutes * 0.10;
            double igv = sub_total * 0.18;
            double total = Math.Round(sub_total+igv,2);
            ConnectionString();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO boleta_cab(id_ticket, id_serie, fecha_emision, total, numero_boleta) " +
                              "VALUES(" + ticket.id + "," + serie.id + ",'" + boleta.fecha_emision.ToString("yyyy-MM-dd HH:mm:ss") + "'," + total + ",'" + numeroBoleta + "')";

            res = cmd.ExecuteNonQuery();

            if (res > 0)
            {
                resultado = true;
            }

            con.Close();
            return resultado;
        }
        public bool RegistrarBoletaDet(BoletaDet boleta, Ticket ticket, BoletaCab boletaCab)
        {
            bool resultado = false;
            int res = -1;
            double sub_total = ticket.minutos.TotalMinutes * 0.10;
            boleta.igv = sub_total * 0.18;
            String dni = ticket.dni;
            int id_boleta = boletaCab.id_boleta;
            
            ConnectionString();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO boleta_det(id_boleta, dni_cliente, descripcion,cantidad,precio_unitario, subtotal,igv) " +
                              "VALUES(" + id_boleta + ",'" + dni + "','" + boleta.desc+ "'," + boleta.cantidad + "," + boleta.precio + ","+sub_total+","+boleta.igv+")";

            Console.WriteLine(cmd.CommandText);
            res = cmd.ExecuteNonQuery();

            if (res > 0)
            {
                resultado = true;
            }

            con.Close();
            return resultado;
        }
        public Boolean ActualizarPagado(Ticket tic)
        {

            Boolean resultado = false;
            int res = -1;
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE tickets SET pagado=" + 2 + " WHERE placa='" + tic.placa + "' ";
            Console.WriteLine(cmd.CommandText);
            res = cmd.ExecuteNonQuery();
            if (res > 0)
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

        public List<TicketView> MostrarTicket()
        {
            List<TicketView> lista = new List<TicketView>();
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT t.placa, c.dni,c.nombre,c.apellido, t.fecha_ingreso,t.hora_ingreso " +
                   "FROM tickets t " +
                   "JOIN clientes c ON t.dni_clientes = c.DNI " +
                   "WHERE t.pagado="+0+"";
            Console.WriteLine(cmd.CommandText);
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    lista.Add(new TicketView
                    {
                        placa = dr.GetString(0),
                        dni = dr.GetString(1),
                        nombre = dr.GetString(2),
                        apellido = dr.GetString(3),
                        fecha_ingreso = dr.GetDateTime(4),
                        hora_ingreso = dr.GetTimeSpan(5),
                    });
                }
            }
            con.Close();
            return lista;
        }
        public List<Ticket> MostrarTicketPagar()
        {
            List<Ticket> lista = new List<Ticket>();
            ConnectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT t.placa, c.dni, c.nombre, c.apellido, t.fecha_ingreso, t.hora_ingreso, t.fecha_salida, t.hora_salida, " +
                      "TIMESTAMPDIFF(MINUTE, CONCAT(t.fecha_ingreso, ' ', t.hora_ingreso), CONCAT(t.fecha_salida, ' ', t.hora_salida)) AS total_minutes " +
                      "FROM tickets t " +
                      "JOIN clientes c ON t.dni_clientes = c.DNI " +
                      "WHERE t.pagado = 1";




            Console.WriteLine(cmd.CommandText);
            dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    double totalMinutes = dr.GetDouble(8);

                    double subtotal = totalMinutes * 0.10;
                    double igv = subtotal * 0.18;
                    double total = subtotal + igv;
                    lista.Add(new Ticket
                    {
                        placa = dr.GetString(0),
                        dni = dr.GetString(1),
                        nombre = dr.GetString(2),
                        apellido = dr.GetString(3),
                        fecha_ingreso = dr.GetDateTime(4),
                        hora_ingreso = dr.GetTimeSpan(5),
                        fecha_salida = dr.GetDateTime(6),
                        hora_salida = dr.GetTimeSpan(7),
                        subtotal = subtotal,
                        igv = igv,          
                        total = total       
                    });
                    
                }
            }
            con.Close();
            return lista;
        }
        public List<Boleta> MostrarBoletas()
        {
            List<Boleta> lista = new List<Boleta>();
            ConnectionString();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT bc.numero_boleta, bc.fecha_emision, bd.dni_cliente, c.nombre, c.apellido, " +
                   "bd.descripcion, bd.cantidad, bd.precio_unitario, bd.subtotal,bd.igv, bc.total " +
                   "FROM boleta_cab bc " +
                   "JOIN boleta_det bd ON bc.id_boleta = bd.id_boleta " +
                   "JOIN tickets t ON bc.id_ticket = t.id_ticket " +
                   "JOIN clientes c ON bd.dni_cliente = c.dni WHERE t.pagado="+2+"";


            dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    lista.Add(new Boleta
                    {
                        numero_boleta = dr.GetString(0),
                        fecha_emision = dr.GetDateTime(1),
                        dni_cliente = dr.GetString(2),
                        nombre = dr.GetString(3),
                        apellido = dr.GetString(4),
                        descripcion = dr.GetString(5),
                        cantidad = dr.GetInt32(6),
                        precio_unitario = dr.GetDouble(7),
                        subtotal = dr.GetDouble(8),
                        igv = dr.GetDouble(9),
                        total = dr.GetDouble(10)
                    });
                }
            }

            con.Close();
            return lista;
        }

    }
}
