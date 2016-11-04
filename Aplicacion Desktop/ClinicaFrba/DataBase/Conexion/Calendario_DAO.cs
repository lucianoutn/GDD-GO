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
                    ("select count(*) from " + ConstantesBD.tabla_agenda + " ag " +
                    " where ag.id_profesional = " + prof.getid().ToString() +
                    " and ag.fecha_hasta > " + stringSQL(fecha));
            r.Read();
            return r.GetInt32(0) == 0;
        }

        public bool validarFecha2(Profesional prof, DateTime fecha)
        {
            SqlDataReader r = null;
            r = GD2C2016.ejecutarSentenciaConRetorno
                    ("select count(*) from " + ConstantesBD.tabla_agenda + " ag " +
                    " where ag.id_profesional = " + prof.getid().ToString() +
                    " and ag.fecha_hasta > " + stringSQL2(fecha));
            r.Read();
            return r.GetInt32(0) == 0;
        }

        public Int32 controlHorarios(List<DiaLaboral> lista)
        {
            Int32 flag = 0;
            foreach (DiaLaboral item in lista)
            {
                flag = Int32.Parse(item.getfin()) - Int32.Parse(item.getinicio()); 
            }
            return flag;
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
                if (!validarFecha2(prof, fin))       return 2;
            }
            catch (Exception)
            {
                return 6;
            }
            if (franja % 5 != 0) return 3;
            if (controlHorarios(lista) > 4800) return 4;
            return 0;
        }

        public void newCalendar(Profesional prof, Especialidad esp, DateTime inicio, DateTime fin, int franja, List<DiaLaboral> lista)
        {
//            SqlDataReader r = null;
//            GD2C2016.ejecutarSentenciaSinRetorno
//                    ("INSERT INTO "+ ConstantesBD.tabla_agenda + "("+
//                	" id_profesional, id_especialidad,"+
//                    " fecha_desde, fecha_hasta,	duracion_consulta, estado)"+
//                    "VALUES ("+
//                    prof.getid().ToString()+" , "+
//                    esp.getID().ToString()+" , "+
//		            stringSQL(inicio)+" , "+
//                    stringSQL(fin)+" , "+
//                    franja.ToString()+" , 0)");
        }

        public String stringAgenda(List<DiaLaboral> lista_dias)
        {
            String texto = "";

            foreach (DiaLaboral item in lista_dias)
            {
                texto = texto + item.getdia() +
                        ": " + item.getinicio() + " - " + item.getinicio() + "\n";
            }
            return texto;
        }
        private String stringSQL(DateTime f)
        {
            return "'" + f.Year.ToString() + "-" + f.Month.ToString() + "-" + f.Day.ToString() +
                    " " + f.Hour.ToString() + ":" + f.Minute.ToString() + ":00.000'";
        }
        private String stringSQL2(DateTime f)
        {
            return "'" + f.Year.ToString() + "-" + f.Day.ToString() + "-" + f.Month.ToString() +
                    " " + f.Hour.ToString() + ":" + f.Minute.ToString() + ":00.000'";
        }
    }
}
