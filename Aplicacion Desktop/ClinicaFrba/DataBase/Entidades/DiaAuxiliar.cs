using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class DiaAuxiliar
    {
        public Int32 agenda;
        public Int32 duracion;
        public DateTime fecha;
        public DateTime fechafin;
        public DateTime inicio;
        public DateTime fin;

        public DiaAuxiliar(Int32 a, Int32 b,
                        DateTime c, DateTime d,
                        DateTime e, DateTime f)
        {
            agenda = a;
            duracion = b;
            fecha = c;
            fechafin = d;
            inicio = e;
            fin = f;
        }

    }
}
