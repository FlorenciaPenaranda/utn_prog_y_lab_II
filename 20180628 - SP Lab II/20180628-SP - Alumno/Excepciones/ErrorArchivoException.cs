﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(Exception e)
            : base ("ERROR EN ARCHIVOS", e)
        {

        }
    }
}
