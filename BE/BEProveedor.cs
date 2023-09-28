using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;


namespace BE
{
    public class BEProveedor : Entidad
    {
        public string CUIT { get; set; }
        public string Nombre { get; set; }

        public BEProveedor()
        {
        }

        public BEProveedor(string cUIT, string nombre)
        {
            CUIT = cUIT;
            Nombre = nombre;
        }

    }
}
