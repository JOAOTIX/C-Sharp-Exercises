using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Playa_Estacionamiento.Class.Users
{
     class BoletaCab
    {
        public int id_boleta { get; set; }
        public DateTime fecha_emision { get; set; } = DateTime.Now;
        public Double total { get; set; }
        public String numero_boleta { get; set; }
    }
}
