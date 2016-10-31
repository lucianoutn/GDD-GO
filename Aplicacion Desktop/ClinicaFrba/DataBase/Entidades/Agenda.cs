using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class Agenda
    {
        private DateTime Inicio;
        private DateTime Fin;
        private Int32 prof_id;
        private Int32 esp_id;
        private Int32 duracion_consulta;

        public Agenda(DateTime i, DateTime f, Int32 _id_user, Int32 _id_esp, Int32 duracion)
        {
            Inicio = i;
            Fin = f;
            prof_id = _id_user;
            esp_id = _id_esp;
            duracion_consulta = duracion;
        }

        public DateTime getInicio()
        {
            return Inicio;
        }
        public DateTime getFin()
        {
            return Fin;
        }
        public Int32 getprof()
        {
            return prof_id;
        }
        public Int32 getesp()
        {
            return esp_id;
        }
        public Int32 getduracion()
        {
            return duracion_consulta;
        }
    }
}
