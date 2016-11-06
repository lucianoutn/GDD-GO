using ClinicaFrba.Conexion;
using ClinicaFrba.DataBase.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Conexion
{
    class Clientes_DAO : GDD_GO_DAO
    {
        public Clientes_DAO()
        {
            this.iniciar();    
        }

        public List<Afiliado> getAfiliados()
        {
            List<Afiliado> lista = new List<Afiliado>();
            SqlDataReader r = null;
            try
            {
                r = GD2C2016.ejecutarSentenciaConRetorno("select * from " + ConstantesBD.tabla_afiliados);
            }
            catch (Exception e)
            {
                throw new Exception("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
            try
            {
                while (r.Read())
                {
                    Afiliado afiliado = null;
                    afiliado = new Afiliado(
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

    }
}
