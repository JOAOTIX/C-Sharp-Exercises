using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web04.Models
{
    public class Producto
    {
       
            public int code { get; set; }
            public string name { get; set; }
            public double price { get; set; }
            public int stock { get; set; }
            public int state { get; set; }
 
    }
}