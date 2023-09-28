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
    public class BLLProveedor : IGestor<BEProveedor>
    {
        public BLLProveedor()
        {
            oMPPProveedor = new MPPProveedor();
        }

        MPPProveedor oMPPProveedor;


        public bool Baja(BEProveedor Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardat(BEProveedor Objeto)
        {
            throw new NotImplementedException();
        }

        public BEProveedor ListarObjeto(BEProveedor Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEProveedor> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
