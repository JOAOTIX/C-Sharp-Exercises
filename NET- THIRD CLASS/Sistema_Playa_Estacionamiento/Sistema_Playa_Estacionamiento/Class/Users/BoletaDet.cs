using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Playa_Estacionamiento.Class.Users
{
     class BoletaDet
    {
        public int id_detalle { get; set; }
        public String desc { get; set; } = "Estacionamiento";
        public double precio { get; set; } = 0.10;
        public int cantidad { get; set; } = 1;
        public double igv { get; set; }
    }
}
