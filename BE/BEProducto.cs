using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;


namespace BE
{
    public abstract class BEProducto : Entidad
    {
        public int Cantidad { get; set; }
        public double PrecioUn { get; set; }
        public string Tipo { get; set; }
        public BEProveedor Proveedor { get; set; }

        public BEProducto()
        {
        }

        public BEProducto(int cantidad, double precioUn, string tipo, BEProveedor proveedor)
        {
            Cantidad = cantidad;
            PrecioUn = precioUn;
            Tipo = tipo;
            Proveedor = proveedor;
        }


    }
}
