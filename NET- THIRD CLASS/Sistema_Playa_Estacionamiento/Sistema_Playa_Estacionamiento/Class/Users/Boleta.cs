using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Playa_Estacionamiento.Class.Users
{
     class Boleta
    {
        public string numero_boleta { get; set; }
        public DateTime fecha_emision { get; set; }
        public string dni_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio_unitario { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}
