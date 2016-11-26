using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.DataBase.Conexion
{
    class RegistroLlegada_DAO : GDD_GO_DAO
    {
        public RegistroLlegada_DAO()
        {
       
            this.iniciar();
        }

        /* OBTENGO TODOS LOS NOMBRES DE ESPECIALIDADES QUE EXISTEN*/
        public List<string> obtenerEspecialidades()        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select [descripcion] from [GDD_GO].[especialidad]");
            List<string> especialidades = new List<string>();
            while (reader.Read())
            {
                especialidades.Add(reader["descripcion"].ToString());
            }
            reader.Close();

            return especialidades;
        }

        /* OBTENGO TODOS LOS NOMBRES DE PROFESIONALES QUE EXISTEN*/
        public List<string> obtenerProfesionales()
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select (desc_apellido +' '+ desc_nombre)as c from [GDD_GO].[profesional]");
            List<string> profesionales = new List<string>();
            while (reader.Read())
            {
                profesionales.Add(reader["c"].ToString());
            }
            reader.Close();

            return profesionales;
        }
       
        /* OBTENGO LOS NOMBRES DE PROFESIONALES SEGUN ESPECIALIDAD */
        public List<string> obtenerProfesionalesPorEspecialidad(string especialidadElegida)
        {
            //CREAR UNA VISTA//CREAR UNA VISTA//CREAR UNA VISTA//CREAR UNA VISTA//CREAR UNA VISTA
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select nombre from [GDD_GO].[vista_especialidad_profesional] where descripcion = '"+especialidadElegida+"'");
            List<string> profesionales = new List<string>();
            while (reader.Read())
            {
                profesionales.Add(reader["nombre"].ToString());
            }
            reader.Close();

            return profesionales;
        }
       
        /* obtengo id del turno para el dia de la fecha */
        public List<int> turnosHoy(string profElegido)
        {
            MessageBox.Show(cambiarFormatoFecha(ConstantesBD.fechaSistema));
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_profesional from GDD_GO.profesional where desc_apellido +' '+ desc_nombre = '"+profElegido+"'");
            reader.Read();
            int idprofElegido = Int32.Parse(reader["id_profesional"].ToString());
            reader.Close();
            
            //tiene hardcodeada una fecha para testing !!SACAR ANTES DE ENTREGA!!
            //tambien checkea por turnos cancelados
            //SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select * from GDD_GO.turno t, GDD_GO.horario h where t.id_turno = h.id_turno and convert(date, h.desc_hora_desde) = '2015-3-31' /* convert(date, GETDATE()) */ and t.id_profesional = '" + idprofElegido + "' and t.desc_estado = 0 order by desc_hora_desde asc");
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select * from GDD_GO.turno t, GDD_GO.horario h where t.id_turno = h.id_turno and convert(date, h.desc_hora_desde) = convert(date, '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "',120) and t.id_profesional = '" + idprofElegido + "' and t.desc_estado = 0 order by desc_hora_desde asc");
 
           List<int> resultado = new List<int>();
           while (lector.Read())
             {
               resultado.Add(Int32.Parse(lector["id_turno"].ToString()));
             }
           lector.Close();
           return resultado;
           
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
        public string getHoraTurno(int turno_id)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_hora_desde from GDD_GO.horario where id_turno ='"+turno_id+"'");
            reader.Read();
            DateTime hora = DateTime.Parse(reader["desc_hora_desde"].ToString());
            reader.Close();
            return hora.ToString();
        }

        public string getAfTurno(int id_turno)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_afiliado from GDD_GO.turno where id_turno ='" + id_turno + "'");
            reader.Read();
            int id_afiliado = Int32.Parse(reader["id_afiliado"].ToString());
            reader.Close();
            reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select (desc_apellido +' '+ desc_nombre)as nombre from GDD_GO.afiliado where id_afiliado ='" + id_afiliado + "'");
            reader.Read();
            string nombre = reader["nombre"].ToString();
            reader.Close();
            return nombre;
        }

        public int getIdAfSegunTurno(int id_turno)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_afiliado from GDD_GO.turno where id_turno ='" + id_turno + "'");
            reader.Read();
            int id_afiliado = Int32.Parse(reader["id_afiliado"].ToString());
            reader.Close();
            return id_afiliado;
        }

        public int getCantBonosDisponibles(int id_afiliado) /*verifica tambien que los bonos sean del mismo plan actual del afiliado */
        {   //estado bono =1: "Disponible" estado =0:"utilizado"
            int id_planMedico = this.getIdPlanMedico(id_afiliado);
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select count(*) as cant from GDD_GO.bono_comprado where id_afiliado ="+ id_afiliado +" and desc_estado = 1 and id_plan_medico ="+ id_planMedico +" group by id_afiliado");
            reader.Read();
            int cant = Int32.Parse(reader["cant"].ToString());
            reader.Close();
            return cant;
        }

        public int getIdPlanMedico(int id_afiliado)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_plan_medico as id from GDD_GO.afiliado where id_afiliado =" + id_afiliado);
            reader.Read();
            int id = Int32.Parse(reader["id"].ToString());
            reader.Close();
            return id;
        }

        public int getUnBonoDisponible(int id_afiliado) /*verifica tambien que los bonos sean del mismo plan actual del afiliado */
        {   //estado bono =1: "Disponible" estado =0:"utilizado"
        
            int id_planMedico = this.getIdPlanMedico(id_afiliado);
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select top 1 id_bono_comprado as id from GDD_GO.bono_comprado where id_afiliado =" + id_afiliado + " and desc_estado = 1and id_plan_medico =" + id_planMedico);
            reader.Read();
            int id_bono = Int32.Parse(reader["id"].ToString());
            reader.Close();
            return id_bono;
        }

        public void marcarBonoUtilizado(int id_bono)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Update GDD_GO.bono_comprado set desc_estado = 0 where id_bono_comprado=" + id_bono);
        
        }
        /*
         public void registrarHoraLlegada(int id_turno)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Update GDD_GO.consulta set desc_hora_llegada = GETDATE() where id_turno=" + id_turno);
        
        }
        */


        public void insertarConsulta(int id_turno, int id_bono, string desc_hora_consulta)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.consulta(desc_hora_llegada, desc_hora_consulta, id_turno, id_bono) values( convert(date, '" + cambiarFormatoFecha(ConstantesBD.fechaSistema) + "',120)),'" + desc_hora_consulta + "'," + id_turno + "," + id_bono + ")");
         
        }
    }
}
