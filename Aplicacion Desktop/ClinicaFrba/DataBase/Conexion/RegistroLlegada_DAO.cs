using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;

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

            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_profesional from GDD_GO.profesional where desc_apellido +' '+ desc_nombre = '"+profElegido+"'");
            reader.Read();
            int idprofElegido = Int32.Parse(reader["id_profesional"].ToString());
            reader.Close();
           
           SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select * from GDD_GO.turno t, GDD_GO.horario h where t.id_turno = h.id_turno and convert(date, h.desc_hora_desde) = '2015-3-31' /* convert(date, GETDATE()) */ and t.id_profesional = '" + idprofElegido + "' and t.desc_estado = 0 order by desc_hora_desde asc");
 
           List<int> resultado = new List<int>();
           while (lector.Read())
             {
               resultado.Add(Int32.Parse(lector["id_turno"].ToString()));
             }
           lector.Close();
           return resultado;
           
        }

        public string getHoraTurno(int turno_id)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_hora_desde from GDD_GO.horario where id_turno =+'"+turno_id+"'");
            reader.Read();
            DateTime hora = DateTime.Parse(reader["desc_hora_desde"].ToString());
            reader.Close();
            return hora.ToString("hh':'mm");
        }

        public string getAfTurno(int id_turno)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_afiliado from GDD_GO.turno where id_turno =+'" + id_turno + "'");
            reader.Read();
            int id_afiliado = Int32.Parse(reader["id_afiliado"].ToString());
            reader.Close();
            reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select (desc_apellido +' '+ desc_nombre)as nombre from GDD_GO.afiliado where id_afiliado =+'" + id_afiliado + "'");
            reader.Read();
            string nombre = reader["nombre"].ToString();
            reader.Close();
            return nombre;
        }
    }
}
