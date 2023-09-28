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
    public class MPPProveedor : IGestor<BEProveedor>
    {
        public MPPProveedor()
        {
            oAcceso = new Acceso();
        }

        Acceso oAcceso;

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
