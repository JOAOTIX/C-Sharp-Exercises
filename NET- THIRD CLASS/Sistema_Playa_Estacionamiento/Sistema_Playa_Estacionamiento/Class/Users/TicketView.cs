using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Playa_Estacionamiento.Class.Users
{
     class TicketView
    {
        public String dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String placa { get; set; }
        public DateTime fecha_ingreso { get; set; } = DateTime.Now;
        public TimeSpan hora_ingreso { get; set; } = DateTime.Now.TimeOfDay;


    }
}
