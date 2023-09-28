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
    public class BLLAceite : IGestor<BEAceite>
    {
        public BLLAceite()
        {
            oMPPAceite = new MPPAceite();
        }

        MPPAceite oMPPAceite;


        public bool Baja(BEAceite Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardat(BEAceite Objeto)
        {
            throw new NotImplementedException();
        }

        public BEAceite ListarObjeto(BEAceite Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEAceite> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
