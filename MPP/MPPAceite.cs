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
    public class MPPAceite : IGestor<BEAceite>
    {
        public MPPAceite()
        {
            oAcceso = new Acceso();

        }

        Acceso oAcceso;


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
