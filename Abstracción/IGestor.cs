﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracción
{
    public interface IGestor<T> where T: IEntidad
    {
        bool Guardat(T Objeto);
        bool Baja(T Objeto);
        List<T> ListarTodo();
        T ListarObjeto(T Objeto);

    }
}
