using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Producto
    {
        public int codigo { get; set; }
        public string producto { get; set; }
        public decimal precioV { get; set; }
        public decimal precioC { get; set; }
        public int stock { get; set; }
        public int categoria { get; set; }
    }
}
