using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Hamburguesa
    {
        public string Nombre { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }

        public int Topp { get; set; }

        public string Factura { get; set; }

        public string CalNom()
        {

            string calulo = System.Convert.ToString((Precio + Topp) * Cantidad);
            return Nombre + "\r\n" + "Total $ " + calulo;

        }

      
    }
}
