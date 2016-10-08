using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.Excepciones
{
    class ValidacionErroneaUsuarioException : Exception
    {
        public ValidacionErroneaUsuarioException()
        {
        }

        public ValidacionErroneaUsuarioException(string message)
            : base(message)
        {
        }

        public ValidacionErroneaUsuarioException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}