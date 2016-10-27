using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;

namespace ClinicaFrba.DataBase.Conexion
{
    class ListadoEstadistico_DAO : GDD_GO_DAO
    {
        
        public ListadoEstadistico_DAO()
        {
            this.iniciar();
        }

        
        public List<string> get_anios()
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT distinct YEAR(desc_hora_desde) as ANIOS FROM " + ConstantesBD.tabla_horario);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["ANIOS"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public SqlDataReader getCancelacionesAfiliados(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

        public SqlDataReader getCancelacionesProfesional(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

        public SqlDataReader getProfMasConsultaPorEspecialidad(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

        public SqlDataReader getProfConMenosHorasTrabajadas(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

        public SqlDataReader getAfiliadosConMasBonosComprados(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

        public SqlDataReader getProfConMasBonosConsultUtilizados(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

    }
}
