
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class Horario
    {
        public Int32 orden;
        private Int32 id;
        private Int32 id_Agenda;
        private DateTime fecha;
        private Int32 duracion;

        public Horario(Int32 _id, Int32 _id_agenda, DateTime date, Int32 t_consulta)
        {
            id = _id;
            id_Agenda = _id_agenda;
            fecha = date;
            duracion = t_consulta;
        }


        public DateTime getFecha()
        {
            return fecha;
        }
        public String getDate()
        {
            return fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString();
        }
        public String getTime()
        {
            return fecha.Hour.ToString() + ":" + fecha.Minute.ToString();
        }
        public String getDay()
        {
            return fecha.DayOfWeek.ToString();
        }

        public String getDuracion()
        {
            return duracion.ToString();
        }
        public Int32 getAgenda()
        {
            return id_Agenda;
        }
    }
}
