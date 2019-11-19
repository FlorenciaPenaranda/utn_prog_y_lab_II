﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivo <T>
    {
        bool Guardar(string archivo, T datos);

        T Leer(string archivo);
    }
}
