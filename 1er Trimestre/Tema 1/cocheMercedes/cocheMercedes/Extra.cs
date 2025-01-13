using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocheMercedes
{
    public class Extra
    {
       public Extra(string nombreExtra, int Precio) {
            this.Precio = Precio;
            this.NombreExtra = nombreExtra;
       }


       public int Precio { get; set; }
       public string NombreExtra { get; set; }
    }
}
