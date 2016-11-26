using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClinicaFrba.ABM_Usuario;

namespace ClinicaFrba.DataBase.Conexion
{
    class Turno_DAO : GDD_GO_DAO
    {
        public Turno_DAO()
        {
            this.iniciar();
        }
        
        public List<string> get_turnos(int id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select h.id_turno From GDD_GO.horario h Join GDD_GO.turno t On t.id_turno = h.id_turno Where t.id_afiliado = "+id_afiliado+ " AND t.desc_estado!=1 order by h.desc_hora_desde asc");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_turno"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public List<string> get_turnos(int id_afiliado, String fechaActual)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select h.id_turno From GDD_GO.horario h "+
                "Join GDD_GO.turno t On t.id_turno = h.id_turno "+
                "Where t.id_afiliado = " + id_afiliado + " AND t.desc_estado!=1 "+
                "AND h.desc_hora_desde >= '"+ConstantesBD.cambiarFormatoFecha(fechaActual)+"' order by h.desc_hora_desde asc");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_turno"].ToString());
            }

            lector.Close();
            return resultado;
        }


        public List<string> get_turnos_profesional_por_fecha(String id_profesional, DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("  select tu.id_turno from GDD_GO.turno tu "+
                                                                             "  join GDD_GO.horario ho " +
	                                                                         "  on ho.id_turno = tu.id_turno And " +
		                                                                     "  ho.desc_hora_desde >= " +fechaSQL(fechaInicio)+" and " +
		                                                                     "  ho.desc_hora_desde <= "+fechaSQL(fechaFinal)+
                                                                             "  where tu.id_profesional = "+id_profesional);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_turno"].ToString());
            }

            lector.Close();
            return resultado;
        }


        public void cancelarTurno(int id_turno, string motivo, int desc__cancelacion_usuario, int desc_usuario)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("insert into GDD_GO.tipo_cancelacion (descripcion, id_turno, id_usuario, desc_usuario) values ('" + motivo + "', " + id_turno + ", " + desc__cancelacion_usuario + ","+desc_usuario+")");
            new Horarios_DAO().liberarHorarioDelTurno(id_turno);
        }

        public void cancelarTurnoProfesional(string motivo, string desc__cancelacion_usuario, String id_turno)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno
                ("insert into GDD_GO.tipo_cancelacion (descripcion, id_turno, id_usuario, desc_usuario) "+
                 "select '" + motivo + "',	tu.id_turno,		" + desc__cancelacion_usuario + ",		2" +
                 " from GDD_GO.turno tu where tu.id_turno ="+id_turno);
        }

        public int get_profesional(int id_turno)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_profesional from GDD_GO.turno where id_turno=" + id_turno);
            lector.Read();
            int cantidad;
            int.TryParse(lector["id_profesional"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
        }


        public string get_afiliado(int id_turno)
        {
            string apellido = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_afiliado from GDD_GO.turno where id_turno=" + id_turno);

            if (lector.Read())
                apellido = (string)lector[0];
            lector.Close();


            return apellido;
        }


        public DateTime get_hora_desde(int id_turno)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select desc_hora_desde from GDD_GO.horario where id_turno = " + id_turno);
            lector.Read();
            DateTime cantidad;
            cantidad = DateTime.Parse(lector["desc_hora_desde"].ToString());
            lector.Close();
            return cantidad;
        }




        public void agendar_Turno(Int32 agenda, Int32 afiliado, Int32 prof, Int32 esp, DateTime hora)
        {
            GD2C2016.ejecutarSentenciaSinRetorno("Begin Transaction");
            SqlDataReader resultado;
            try
            {
                this.GD2C2016.ejecutarSentenciaSinRetorno(
                        "insert into "+ConstantesBD.tabla_turno+
                        " (id_turno, id_afiliado, id_profesional,desc_estado,id_especialidad)"+
                        " values ("+
                        "((select TOP(1) id_turno from "+ConstantesBD.tabla_turno+
                        " order by id_turno desc) + 1),"+
                        afiliado.ToString()+","+prof.ToString()+", 0, "+esp.ToString()+") ");

                resultado = this.GD2C2016.ejecutarSentenciaConRetorno(
                        "select TOP(1) id_turno from "+ConstantesBD.tabla_turno+
                        " order by id_turno desc");
            }
            catch (Exception)
            {
                GD2C2016.ejecutarSentenciaSinRetorno("ROLLBACK");
                throw new Exception("Imposible Agregar Agenda");
            }
            if (!resultado.Read())
            {
                throw new Exception("No Retorno");
            }
            Int32 aux = resultado.GetInt32(0);
            resultado.Close();
            try
            {
                    this.GD2C2016.ejecutarSentenciaSinRetorno(
                        "insert into GDD_GO.horario (id_agenda,id_turno,desc_hora_desde)"+
                        "values(" + agenda.ToString() + "," +aux.ToString() +"," + fechaSQL(hora) + ")");
            }
            catch (Exception)
            {
                GD2C2016.ejecutarSentenciaSinRetorno("ROLLBACK");
                throw new Exception("imposible gregar Horario");
            }
            GD2C2016.ejecutarSentenciaSinRetorno("COMMIT");
        }

        private String fechaSQL(DateTime f)
        {
            string fechaSQL = "'" + f.Year.ToString() + "-" + f.Month.ToString() + "-" + f.Day.ToString() +
                    " " + f.Hour.ToString() + ":" + f.Minute.ToString() + ":00.000'";

            return "CONVERT(Datetime, " + fechaSQL + ", 120)";
        }

    }
}
