using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaPrueba
{
    internal class extra
    {
        public string nombre { get; set; }
        public int precio { get; set; }

        public extra(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public override string ToString()
        {
            return nombre + ": " + precio + "€";
        }
    }
}
