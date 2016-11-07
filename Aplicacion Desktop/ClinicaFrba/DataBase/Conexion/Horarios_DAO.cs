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
            while (r.Read())
            {
                DiaAuxiliar aux = new DiaAuxiliar(r.GetInt32(0), r.GetInt32(3),
                            r.GetDateTime(1), r.GetDateTime(2),
                            r.GetDateTime(8), r.GetDateTime(9));
                lista_D.Add(aux);
            }
            r.Close();

            foreach (DiaAuxiliar item in lista_D)
            {
                list.AddRange(armarDia(item));
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
                        "select h.id_horario,a.id_agenda,h.desc_hora_desde,a.duracion_consulta,a.id_profesional,a.id_especialidad "+
                        "from " + ConstantesBD.tabla_agenda + " a " +
                        "join " + ConstantesBD.tabla_horario + " h " +
                        "on h.id_agenda = a.id_agenda "+
                        "where a.id_profesional = " + prof + " " +
                        "and a.id_especialidad = " + esp + " " +
                        "and a.fecha_hasta >= '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "' " +
                        "and h.desc_hora_desde > '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "' " +
                        "and h.id_turno = null");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    Horario item = new Horario(r.GetInt32(0),r.GetInt32(1),r.GetDateTime(2),
                        r.GetInt32(3),r.GetInt32(4),r.GetInt32(5));
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

        private List<Horario> armarDia(DiaAuxiliar dia)
        {
            List<Horario> list = new List<Horario>();
            DateTime aux = dia.fecha;
            while (dia.fechafin.CompareTo(aux) >= 0)
            {
                list.AddRange(armarHorarios(dia.agenda, dia.duracion, aux, dia.inicio, dia.fin));
                aux = aux.AddDays(1);
            }
            return list;
        }

        private List<Horario> armarHorarios(Int32 agenda,Int32 duracion,
                            DateTime fecha, DateTime inicio, DateTime fin)
        {
            List<Horario> list = new List<Horario>();
            DateTime aux = fecha;

            while   (inicio.TimeOfDay.CompareTo(aux.TimeOfDay) <= 0 &&
                    fin.TimeOfDay.CompareTo(aux.TimeOfDay) >= 0)
            {
                if (!existe_Horario_que_Ocupa(agenda, aux))
                {
                    Horario item = new Horario(0, agenda, aux, duracion);
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
                        "select * from " + ConstantesBD.tabla_horario + " h" +
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
                aux = r.GetInt32(0) == 0;
                r.Close();
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
            return aux;
        }
        private String fechaSQL(DateTime f)
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
            return fechaConFormato.Substring(1) + " 00:00:00.00";
        }
    }
}
