using ClinicaFrba.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public bool validarFecha(Profesional prof, DateTime fecha) 
        {
            SqlDataReader r = null;
                r = GD2C2016.ejecutarSentenciaConRetorno
                        ("select ag.id_agenda from " + ConstantesBD.tabla_agenda + " ag " +
                        "where ag.id_profesional = " + prof.getid().ToString() +
                        "and ag.fecha_hasta > " + ConstantesBD.darFormatoFecha(fecha));
                r.Read();
                return r.GetInt32(0) != 0;
        }

        public bool controlHorarios(List<DiaLaboral> lista)
        {
            int flag = 0;
            foreach (DiaLaboral item in lista)
            {
                flag = Int32.Parse(item.getfin()) - Int32.Parse(item.getinicio()); 
            }
            return flag <= 4800;
        }

        public int tryNewCalendar(Profesional prof, Especialidad esp, DateTime inicio, DateTime fin, int franja, List<DiaLaboral> lista)
        {
            try
            {
                if (!validarFecha(prof, inicio))    return 1;
            }
            catch (Exception)
            {
                return 5;
            }
            try
            {
                if (!validarFecha(prof, fin))       return 2;
            }
            catch (Exception)
            {
                return 6;
            }
            if (franja % 5 != 0) return 3;
            if (!controlHorarios(lista)) return 4;
            return 0;
        }

        public Agenda newCalendar(Profesional prof, Especialidad esp, DateTime inicio, DateTime fin, int franja, List<DiaLaboral> lista)
        {
            return null;
        }
    }
}
