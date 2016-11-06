using ClinicaFrba.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.DataBase.Entidades;
using System.Data.SqlClient;


namespace ClinicaFrba.DataBase.Conexion
{
    class Especialidades_DAO : GDD_GO_DAO
    {
        public Especialidades_DAO()
        {
            this.iniciar();
        }

        public List<Especialidad> get_especialidadesDe(Int32 id_prof)
        {
            List<Especialidad> lista = new List<Especialidad>();
            SqlDataReader r = GD2C2016.ejecutarSentenciaConRetorno("select e.id_especialidad,e.descripcion,t.descripcion from " +
                        ConstantesBD.tabla_especialidad+" e" +
                        " join " + ConstantesBD.tabla_esp_por_profesional + " e_p on e_p.id_especialidad = e.id_especialidad" +
                        " join " + ConstantesBD.tabla_t_especialidad + " t on t.id_tipo_especialidad = e.id_tipo_especialidad" +
                        " where e_p.id_profesional = " + id_prof.ToString());

                while (r.Read())
                {
                    Especialidad especialidad = null;
                    especialidad = new Especialidad(
                                    r.GetInt32(0),
                                    r.GetString(1),
                                    r.GetString(2));
                    lista.Add(especialidad);
                }
                r.Close();
            return lista;
        }

/*        public List<Especialidad> get_especialidadesDe(int id_prof)
        {
            List<Especialidad> lista = new List<Especialidad>();

              Especialidad especialidad = null;
                especialidad = new Especialidad(
                                10,"Neurologo","Especialista");
                lista.Add(especialidad);

              Especialidad especialidad2 = null;
                especialidad2 = new Especialidad(
                                15,"Diagnosta","especialista");
                lista.Add(especialidad2);
            return lista;
        }*/
        public List<Especialidad> get_especialidades()
        {
            List<Especialidad> lista = new List<Especialidad>();
            SqlDataReader r = GD2C2016.ejecutarSentenciaConRetorno("select e.id_especialidad,e.descripcion,t.descripcion	from GDD_GO.especialidad e join GDD_GO.tipo_especialidad t on t.id_tipo_especialidad = e.id_tipo_especialidad");
            while (r.Read())
            {
                Especialidad especialidad = null;
                especialidad = new Especialidad(
                                r.GetInt32(0),
                                r.GetString(1),
                                r.GetString(2));
                lista.Add(especialidad);
            }
            r.Close();
            
            return lista;
        }



        public String get_descripcion_segun_turno(int id_afiliado)
        {
            string descripcion = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select es.descripcion " +
                                                                             "from GDD_GO.turno tu " +
                                                                             "Join GDD_GO.horario ho " +
                                                                             "on ho.id_turno = tu.id_turno " +
                                                                             "Join GDD_GO.agenda ag " +
                                                                             "on ho.id_agenda=ag.id_agenda " +
                                                                             "Join GDD_GO.especialidad es " +
                                                                             "on ag.id_especialidad = es.id_especialidad " +
                                                                             "where tu.id_turno=" + id_afiliado);
            List<string> resultado = new List<string>();

            if (lector.Read())
                descripcion = (string)lector[0];
            lector.Close();


            return descripcion;
        }

    }
}
