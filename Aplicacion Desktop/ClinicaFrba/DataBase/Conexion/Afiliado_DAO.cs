using ClinicaFrba.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Conexion
{
    class Afiliado_DAO : GDD_GO_DAO
    {
        public Afiliado_DAO()
        {
            this.iniciar();    
        }

        public List<Afiliado> getAfiliados()
        {
            List<Afiliado> lista = new List<Afiliado>();
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno("select * from " + ConstantesBD.tabla_afiliados + " Order by desc_apellido,desc_nombre");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    Afiliado afiliado = new Afiliado(
                                    r.GetInt32(0),
                                    r.GetString(2),
                                    r.GetString(1),
                                    r.GetString(3),
                                    r.GetInt32(4),
                                    r.GetInt32(13));
                    lista.Add(afiliado);
                }
                r.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }
        public Int32 getIDAfiliado(String username)
        {
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno("select * from " + ConstantesBD.tabla_afiliados +
                    " a join "+ConstantesBD.tabla_usuarios+" u on a.id_usuario = u.id_usuario where "+
                    "u.desc_username = '"+username+"'");
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                r.Read();
                Int32 aux = r.GetInt32(0); 
                    r.Close();
                return aux;
            }
            catch (Exception e)
            {
                throw new Exception("El READ del comando se encuentra vacio", e);
            }
        }

    }
}
