using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Models
{
    public class Producto
    {
        public int IdProductos { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria {get; set;}
        public decimal Precio { get; set; }
    }
}
