using ClinicaFrba.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Conexion
{
    class Horarios_DAO: GDD_GO_DAO
    {

        public Horarios_DAO()
        {
            this.iniciar();
        }

        public List<Horario> getHorariosDe(Profesional prof, Especialidad esp)
        {
            List<Horario> list =  agregarHorariosLibres(prof.getid().ToString(),esp.getID().ToString());
            List<DiaAuxiliar> lista_D = new List<DiaAuxiliar>();
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno(
                        "select * from " + ConstantesBD.tabla_agenda + " a " +
                        "join " + ConstantesBD.tabla_dia_laboral + " d " +
                        "on d.id_agenda = a.id_agenda " +
                        "where a.id_profesional = " + prof.getid() + " " +
                        "and a.id_especialidad = " + esp.getID() + " " +
                        "and a.fecha_hasta >= '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "' ");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    DiaAuxiliar aux = new DiaAuxiliar(r.GetInt32(0), r.GetInt32(3), r.GetString(7)[0],
                                r.GetDateTime(1), r.GetDateTime(2),
                                r.GetDateTime(8), r.GetDateTime(9));
                    lista_D.Add(aux);
                }
                r.Close();
            }
            catch (Exception e)
            {
                throw new Exception("No hay respuestas para armar Dias ", e);
            }
            DateTime hoy = new DateTime(
                 ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 2),
                 ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 1),
                 ConstantesBD.getParteDeFecha(ConstantesBD.fechaSistema, 0));

            foreach (DiaAuxiliar item in lista_D)
            {
                list.AddRange(armarDia(item,hoy));
            }

            return list;
        }

        private List<Horario> agregarHorariosLibres(String prof,String esp)
        {
            List<Horario> list = new List<Horario>();
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno(
                        "select h.id_horario,a.id_agenda,h.desc_hora_desde,a.duracion_consulta "+
                        "from " + ConstantesBD.tabla_agenda + " a " +
                        "join " + ConstantesBD.tabla_horario + " h " +
                        "on h.id_agenda = a.id_agenda "+
                        "where a.id_profesional = " + prof + " " +
                        "and a.id_especialidad = " + esp + " " +
                        "and a.fecha_hasta >= '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "' " +
                        "and h.desc_hora_desde > '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "' " +
                        "and h.id_turno = null  order by h.desc_hora_desde");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    Horario item = new Horario(r.GetInt32(0),r.GetInt32(1),r.GetDateTime(2),r.GetInt32(3));
                    list.Add(item);
                }
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
            r.Close();
            return list;
        }

        private List<Horario> armarDia(DiaAuxiliar dia,DateTime hoy)
        {
            Boolean flagDiaCreado = true;
            List<Horario> list = new List<Horario>();
            DateTime aux;
            if(dia.fecha.CompareTo(hoy)<0)
            {
                aux = hoy;
            }else
            {
                aux = dia.fecha;
            }
            while (dia.fechafin.CompareTo(aux) >= 0 && flagDiaCreado)
            {
                if(es_diaLaboral(aux.DayOfWeek,dia.dia))
                {
                    list.AddRange(armarHorarios(dia.agenda, dia.duracion, aux, dia.inicio, dia.fin));
                    flagDiaCreado = false;
                }
                aux = aux.AddDays(1);
            }
            return list;
        }

        private List<Horario> armarHorarios(Int32 agenda,Int32 duracion,
                            DateTime fecha, DateTime inicio, DateTime fin)
        {
            List<Horario> list = new List<Horario>();
            DateTime aux = fecha;

            while (inicio.TimeOfDay.CompareTo(aux.TimeOfDay) > 0)
            {
                aux = aux.AddMinutes(Double.Parse(duracion.ToString()));
            }

            while ( inicio.TimeOfDay.CompareTo(aux.TimeOfDay) <= 0
                &&  fin.TimeOfDay.CompareTo(aux.TimeOfDay) >= 0)
            {
                if (!existe_Horario_que_Ocupa(agenda, aux))
                {
                    Horario item = new Horario(0, agenda, aux, duracion);
                    list.Add(item);
                }
                aux = aux.AddMinutes(Double.Parse(duracion.ToString()));
            }
            return list;
        }

        private Boolean existe_Horario_que_Ocupa(Int32 agenda, DateTime fecha)
        {
            Boolean aux = true;
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno(
                        "select count(*) from " + ConstantesBD.tabla_horario + " h" +
                        " where h.id_agenda = "+agenda.ToString()+
                        " and h.desc_hora_desde = "+ fechaSQL(fecha));
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                r.Read();
                aux = r.GetInt32(0) != 0;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
            r.Close();
            return aux;
        }

        public String fechaSQL(DateTime f)
        {
            return "'" + f.Year.ToString() + "-" + f.Month.ToString() + "-" + f.Day.ToString() +
                    " " + f.Hour.ToString() + ":" + f.Minute.ToString() + ":00.000'";
        }

        private String cambiarFormatoFecha(String fecha)
        {
            String fechaConFormato = "";
            char[] delimitadores = { '/' };

            string[] palabras = fecha.Split(delimitadores);

            foreach (string s in palabras)
            {
                fechaConFormato = s + fechaConFormato;
                fechaConFormato = "-" + fechaConFormato;
            }
            return fechaConFormato.Substring(1) + " 00:00:00.000";
        }
        private Boolean es_diaLaboral(DayOfWeek a, char b)
        {
            return b.Equals(convertirDia(a)) || b.Equals('Z');
        }
        private char convertirDia(DayOfWeek a)
        {
            if (a.Equals(DayOfWeek.Monday)) return 'L';
            else if (a.Equals(DayOfWeek.Tuesday)) return 'M';
            else if (a.Equals(DayOfWeek.Wednesday)) return 'X';
            else if (a.Equals(DayOfWeek.Thursday)) return 'J';
            else if (a.Equals(DayOfWeek.Friday)) return 'V';
            else if (a.Equals(DayOfWeek.Saturday)) return 'S';
            else return 'D';
        }


        internal void liberarHorarioDelTurno(int id_turno)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Update "+ConstantesBD.tabla_horario+" Set id_turno= null "+
                "where id_turno = "+id_turno.ToString());
        }
    }
}
