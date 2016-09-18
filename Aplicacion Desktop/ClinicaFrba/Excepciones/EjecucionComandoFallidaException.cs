using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFRBA.Excepciones
{
    /// <summary>
    /// La clase es una excepcion que indica que no se pudo realizar la ejecucion de la sentencia SQL en el servidor SQL
    /// </summary>
    class EjecucionComandoFallidaException : Exception
    {
        public EjecucionComandoFallidaException()
        {
        }

        public EjecucionComandoFallidaException(string message)
            : base(message)
        {
        }

        public EjecucionComandoFallidaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
