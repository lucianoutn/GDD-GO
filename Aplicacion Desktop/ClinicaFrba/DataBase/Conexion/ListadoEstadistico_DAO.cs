using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            MessageBox.Show("SELECT distinct YEAR(desc_hora_desde) as ANIOS FROM " + ConstantesBD.tabla_horario);
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT distinct YEAR(desc_hora_desde) as ANIOS FROM " + ConstantesBD.tabla_horario);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["ANIOS"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public SqlDataReader getCancelaciones(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("");
            return resultado;
        }

        public SqlDataReader getProfMasConsultaPorEspecialidad(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT TOP 5  pro.desc_apellido, pro.desc_nombre, es.descripcion as Especialidad, COUNT(co.id_turno) as Cantidad FROM "                                                                    + ConstantesBD.tabla_consulta + " as co INNER JOIN "                                                                    + ConstantesBD.tabla_turno + " as t ON as t ON co.id_turno = t.id_turno INNER JOIN "                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE "                                                                    + condicion                                                                    + " GROUP BY pro.desc_apellido, pro.desc_nombre, es.descripcion"                                                                    + " ORDER BY COUNT(co.id_turno) desc");         
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
