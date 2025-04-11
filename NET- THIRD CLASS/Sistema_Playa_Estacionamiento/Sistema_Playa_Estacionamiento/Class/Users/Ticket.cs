using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Playa_Estacionamiento.Class.Users
{
    class Ticket
    {
        public int id { get; set; }
        public String dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String placa { get; set; }
        public DateTime fecha_ingreso { get; set; } = DateTime.Now;
        public DateTime fecha_salida { get; set; } = DateTime.Now;

        public TimeSpan hora_ingreso { get; set; } = DateTime.Now.TimeOfDay;

        public TimeSpan hora_salida { get; set; } = DateTime.Now.TimeOfDay;
        public TimeSpan minutos
        {
            get
            {
                return (hora_salida-hora_ingreso);
            }
        }
        public int pagado { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}
