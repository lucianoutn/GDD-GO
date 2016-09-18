using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFRBA.Excepciones
{
    /// <summary>
    /// La clase es una excepcion que indica que no se pudo cerrar una conexion abierta con el servidor SQL
    /// </summary>
    class CierreConexionFallidaException : Exception
    {
        public CierreConexionFallidaException()
        {
        }

        public CierreConexionFallidaException(string message)
            : base(message)
        {
        }

        public CierreConexionFallidaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
