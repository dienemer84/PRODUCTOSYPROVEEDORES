using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Abstracción;
using System.Data;

namespace MPP
{
    public class MPPProducto : IGestor<BEProducto>
    {
        public MPPProducto()
        {
            oAcceso = new Acceso();

        }

        Acceso oAcceso;


        public bool Baja(BEProducto Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardat(BEProducto Objeto)
        {
            throw new NotImplementedException();
        }

        public BEProducto ListarObjeto(BEProducto Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEProducto> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
