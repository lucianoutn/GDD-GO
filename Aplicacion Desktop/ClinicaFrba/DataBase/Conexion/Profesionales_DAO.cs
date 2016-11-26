using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System.Data.SqlClient;

namespace ClinicaFrba.DataBase.Conexion
{
    class ProfesionalesDAO: GDD_GO_DAO
    {
        public ProfesionalesDAO()
        {
             this.iniciar();    
        }

        public List<Profesional> getProfesionales()
        {
            List<Profesional> lista = new List<Profesional>();
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno("select * from " + ConstantesBD.tabla_profesional+" Order by desc_apellido,desc_nombre");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    Profesional profesional = null;
                    profesional = new Profesional(
                                    r.GetInt32(0),
                                    r.GetString(1),
                                    r.GetString(2),
                                    r.GetString(3),
                                    r.GetInt32(4),
                                    r.GetString(5),
                                    r.GetInt32(6),
                                    r.GetString(7),
                                    r.GetDateTime(8),
                                    r.GetDateTime(9),
                                    r.GetString(10),
                                    r.GetString(11),
                                    r.GetInt32(12));
                    lista.Add(profesional);
                }
                r.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }

        public Profesional getProfesionalDeNombre(String username)
        {
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno("select p.* from " + ConstantesBD.tabla_profesional +
                    " p join " + ConstantesBD.tabla_usuarios + " u on u.id_usuario = p.id_usuario where u.desc_username = '" + username + "'");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
            r.Read();
            Profesional profesional = new Profesional(
                            r.GetInt32(0),
                            r.GetString(1),
                            r.GetString(2),
                            r.GetString(3),
                            r.GetInt32(4),
                            r.GetString(5),
                            r.GetInt32(6),
                            r.GetString(7),
                            r.GetDateTime(8),
                            r.GetDateTime(9),
                            r.GetString(10),
                            r.GetString(11),
                            r.GetInt32(12));
            r.Close();
            return profesional;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }

        public Profesional getProfesionalDeId(String username)
        {
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno("select p.* from " + ConstantesBD.tabla_profesional +" p where p.id_usuario =" +username);
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                r.Read();
                Profesional profesional = new Profesional(
                                r.GetInt32(0),
                                r.GetString(1),
                                r.GetString(2),
                                r.GetString(3),
                                r.GetInt32(4),
                                r.GetString(5),
                                r.GetInt32(6),
                                r.GetString(7),
                                r.GetDateTime(8),
                                r.GetDateTime(9),
                                r.GetString(10),
                                r.GetString(11),
                                r.GetInt32(12));
                r.Close();
                return profesional;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }



        public List<Profesional> getProfesionalesConEspecialidad(Int32 ID_esp)
        {
            List<Profesional> lista = new List<Profesional>();
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno(
                    "select p.* from " + ConstantesBD.tabla_profesional+
                    " p join " + ConstantesBD.tabla_esp_por_profesional +" t on "+
                    " p.id_profesional = t.id_profesional where "+
                    ID_esp.ToString() +" = t.id_especialidad");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    Profesional profesional = null;
                    profesional = new Profesional(
                                    r.GetInt32(0),
                                    r.GetString(1),
                                    r.GetString(2),
                                    r.GetString(3),
                                    r.GetInt32(4),
                                    r.GetString(5),
                                    r.GetInt32(6),
                                    r.GetString(7),
                                    r.GetDateTime(8),
                                    r.GetDateTime(9),
                                    r.GetString(10),
                                    r.GetString(11),
                                    r.GetInt32(12));
                    lista.Add(profesional);
                }
                r.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }

        public List<Profesional> get_profesional_multiple(String desc_nombre, String desc_apellido, String desc_dni)
        {
            List<Profesional> lista = new List<Profesional>();

            if (desc_nombre != "" || desc_nombre != " ")
            {
                desc_nombre = "desc_nombre LIKE '%" + desc_nombre + "%' AND ";
            }
            if (desc_apellido != "" || desc_apellido != " ")
            {
                desc_apellido = "desc_apellido LIKE '%" + desc_apellido + "%' AND ";
            }
            if (desc_dni != "" || desc_dni != " ")
            {
                desc_dni = " desc_dni LIKE '%" + desc_dni + "%'";
            }

            SqlDataReader r = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT * FROM " + ConstantesBD.tabla_profesional + " af JOIN GDD_GO.usuario us on af.id_usuario = us.id_usuario And us.desc_estado != 2" +
                                                                             " AND " + desc_nombre + desc_apellido + desc_dni +
                                                                             " ORDER BY id_profesional asc");

            try
            {
                while (r.Read())
                {
                    Profesional profesional = null;
                    profesional = new Profesional(
                                    r.GetInt32(0),
                                    r.GetString(1),
                                    r.GetString(2),
                                    r.GetString(3),
                                    r.GetInt32(4),
                                    r.GetString(5),
                                    r.GetInt32(6),
                                    r.GetString(7),
                                    r.GetDateTime(8),
                                    r.GetDateTime(9),
                                    r.GetString(10),
                                    r.GetString(11),
                                    r.GetInt32(12));
                    lista.Add(profesional);
                }
                r.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }

        public List<Profesional> get_profesional_multiple(String id_profesional)
        {
            List<Profesional> lista = new List<Profesional>();

            SqlDataReader r = this.GD2C2016.ejecutarSentenciaConRetorno("select * from GDD_GO.profesional where id_profesional=" + id_profesional);

            try
            {
                while (r.Read())
                {
                    Profesional profesional = null;
                    profesional = new Profesional(
                                    r.GetInt32(0),
                                    r.GetString(1),
                                    r.GetString(2),
                                    r.GetString(3),
                                    r.GetInt32(4),
                                    r.GetString(5),
                                    r.GetInt32(6),
                                    r.GetString(7),
                                    r.GetDateTime(8),
                                    r.GetDateTime(9),
                                    r.GetString(10),
                                    r.GetString(11),
                                    r.GetInt32(12));
                    lista.Add(profesional);
                }
                r.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }

        public String get_nombre(int id_afiliado)
        {
            string apellido = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_nombre+' '+desc_apellido from GDD_GO.profesional where id_profesional = " + id_afiliado + "");
            List<string> resultado = new List<string>();

            if (lector.Read())
                apellido = (string)lector[0];
            lector.Close();


            return apellido;
        }

    }
}
