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
    public class BLLFiltro : IGestor<BEFiltro>
    {
        public BLLFiltro()
        {
            oMPPFiltro = new MPPFiltro();
        }

        MPPFiltro oMPPFiltro;



        public bool Baja(BEFiltro Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardat(BEFiltro Objeto)
        {
            throw new NotImplementedException();
        }

        public BEFiltro ListarObjeto(BEFiltro Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEFiltro> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
