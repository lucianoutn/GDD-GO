using ClinicaFrba.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Conexion
{
    class Calendario_DAO : GDD_GO_DAO
    {
        public Calendario_DAO()
        {
            iniciar();
        }

        public bool validarFecha(Profesional prof, Especialidad esp, DateTime fecha)
        {

            return true;
        }

        public bool validarFecha(Profesional prof, Especialidad esp, String dia, String mes, String year)
        {
            return true;
        }

        public bool validarHorario(Profesional prof, Especialidad esp, DateTime fecha, String hora, String minuto)
        {
            return true;
        }

        public bool validarHorario(Profesional prof, Especialidad esp, DateTime fecha)
        {
            return true;
        }

        public int tryNewCalendar(Profesional prof, Especialidad esp, DateTime inicio, DateTime fin, int franja)
        {
            return 0;
        }

        public Agenda newCalendar(Profesional prof, Especialidad esp, DateTime inicio, DateTime fin, int franja)
        {

            return null; 
        }
        public String getSHorarioMinimo()
        {
            return "";
        }
        public String getSHorarioMaximo()
        {
            return "";
        }
    
    }
}
