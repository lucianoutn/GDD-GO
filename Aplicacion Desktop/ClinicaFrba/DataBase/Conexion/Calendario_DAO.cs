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
                    " and ag.fecha_hasta > " + fechaSQL(fecha));
            r.Read();
            Boolean aux = r.GetInt32(0) == 0;
            r.Close();
            return aux;
        }
        public Int32 controlHorarios(List<DiaLaboral> lista)
        {
            Int32 flag = 0;
            foreach (DiaLaboral item in lista)
            {
                flag = flag + Int32.Parse(item.getfin()) - Int32.Parse(item.getinicio()); 
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
                if (!validarFecha(prof, fin))       return 2;
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
            GD2C2016.ejecutarSentenciaSinRetorno("Begin Transaction");
            SqlDataReader resultado;
            try
            {
                resultado = this.GD2C2016.ejecutarSentenciaConRetorno(
                        "Execute GDD_GO.sp_Agregar_Agenda   " +
                        "@profesional = " + prof.getid().ToString() + " , " +
                        "@especialidad = " + esp.getID().ToString() + " , " +
                        "@fecha_desde = " + fechaSQL(inicio) + " , " +
                        "@fecha_hasta = " + fechaSQL(fin) + " , " +
                        "@consulta = " + franja.ToString());

            }catch (Exception)
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
                foreach (DiaLaboral item in lista)
                {
                    this.GD2C2016.ejecutarSentenciaSinRetorno(
                        "INSERT INTO "+ConstantesBD.tabla_dia_laboral+" ( "+
                        "id_dia_laboral"+
                        ",horario_desde"+
                        ",horario_hasta"+
                        ",estado"+
                        ",id_agenda) VALUES ("+
                        "'"+item.getdia()+"',"+
                        horaSQL(item.getinicio())+","+
                        horaSQL(item.getfin())+",0,"+
                        aux.ToString()+")");                        
                }
            }
            catch (Exception)
            {
                GD2C2016.ejecutarSentenciaSinRetorno("ROLLBACK");
                throw new Exception("imposible gregar un Dia Laboral");
            }
            GD2C2016.ejecutarSentenciaSinRetorno("COMMIT");
        }

        public String stringAgenda(List<DiaLaboral> lista_dias)
        {
            String texto = "";

            foreach (DiaLaboral item in lista_dias)
            {
                texto = texto + item.getdia() +
                        "   ->  " + item.getinicio() + "    -   " + item.getfin() + "\n";
            }
            return texto;
        }

        private String fechaSQL(DateTime f)
        {
            return "'" + f.Year.ToString() + "-" + f.Month.ToString() + "-" + f.Day.ToString() +
                    " " + f.Hour.ToString() + ":" + f.Minute.ToString() + ":00.000'";
        }
        
        private String horaSQL(String f)
        {
            return "'" + Int32.Parse(f) / 100 + ":" + Int32.Parse(f)%100 + ":00.000'";
        }
    }
}
