
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class Horario
    {
        private Int32 id;
        private Int32 id_Agenda;
        private DateTime fecha;
        private Int32 duracion;
        private Int32 id_prof;
        private Int32 id_esp;


        public Horario(Int32 _id, Int32 _id_agenda, DateTime date, Int32 t_consulta, Int32 profID, Int32 espID)
        {
            id = _id;
            id_Agenda = _id_agenda;
            fecha = date;
            duracion = t_consulta;
            id_prof = profID;
            id_esp = espID;
        }
        public Horario(Int32 _id, Int32 _id_agenda, DateTime date, Int32 t_consulta)
        {
            id = _id;
            id_Agenda = _id_agenda;
            fecha = date;
            duracion = t_consulta;
        }


        public String getDate()
        {
            return "";
        }
        public String getTime()
        {
            return "";
        }
        public String getDuracion()
        {
            return duracion.ToString();
        }
        public Int32 getProf()
        {
            return 0;
        }
        public Int32 getEsp()
        {
            return 0;
        }

    
    }
}
