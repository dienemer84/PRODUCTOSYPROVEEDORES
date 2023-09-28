using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Abstracción;

namespace Negocio_BLL
{
    public class BLLProducto : IGestor<BEProducto>
    {
        public BLLProducto()
        {
            oMPPProducto = new MPPProducto();
        }

        MPPProducto oMPPProducto;


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
