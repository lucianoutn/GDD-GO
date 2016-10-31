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
                r = GD2C2016.ejecutarSentenciaConRetorno("select * from " + ConstantesBD.tabla_profesional);
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
    }
}
