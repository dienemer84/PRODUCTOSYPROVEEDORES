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
    public class MPPFiltro : IGestor<BEFiltro>
    {
        public MPPFiltro()
        {
            oAcceso = new Acceso();
        }

        Acceso oAcceso;


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
