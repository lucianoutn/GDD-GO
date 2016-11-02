using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class DiaLaboral
    {
        private char dia;
        private String inicio;
        private String fin;

        public DiaLaboral(char a, String b, String c, String d, String e)
        {
            dia = a;
            inicio = b + c;
            fin = d + e;
        }

        public char getdia()
        {
            return dia;
        }
        public String getinicio()
        {
            return inicio;
        }
        public String getfin()
        {
            return fin;
        }
    }
}
