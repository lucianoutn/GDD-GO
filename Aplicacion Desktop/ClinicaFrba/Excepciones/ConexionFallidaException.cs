using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.Excepciones
{
    /// <summary>
    /// La clase es una excepcion que indica que no se pudo establecer una conexion con el servidor SQL
    /// </summary>
    class ConexionFallidaException : Exception
    {
        public ConexionFallidaException()
        {
        }

        public ConexionFallidaException(string message)
            : base(message)
        {
        }

        public ConexionFallidaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
