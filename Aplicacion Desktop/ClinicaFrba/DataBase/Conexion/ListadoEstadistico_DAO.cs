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
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT distinct YEAR(co.desc_hora_desde) as ANIOS FROM " + ConstantesBD.tabla_horario + " as co");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["ANIOS"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public List<string> get_meses()
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT distinct MONTH(co.desc_hora_desde) as MESES FROM " + ConstantesBD.tabla_horario + " as co ORDER BY MESES asc");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["MESES"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public List<string> get_primerSemestre()
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT distinct MONTH(co.desc_hora_consulta) as MESES FROM " + ConstantesBD.tabla_consulta + " as co WHERE MONTH(co.desc_hora_consulta) BETWEEN '1' AND '6' ORDER BY MESES asc");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["MESES"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public List<string> get_segundoSemestre()
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT distinct MONTH(co.desc_hora_consulta) as MESES FROM " + ConstantesBD.tabla_consulta + " as co WHERE MONTH(co.desc_hora_consulta) BETWEEN '7' AND '12' ORDER BY MESES asc");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["MESES"].ToString());
            }
            lector.Close();
            return resultado;
        }

        

        public SqlDataReader getCancelaciones_profesionales(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT TOP 5  pro.desc_apellido, pro.desc_nombre, es.descripcion as Especialidad, COUNT(co.id_turno) as Cantidad FROM "                                                                    + ConstantesBD.tabla_consulta + " as co INNER JOIN "                                                                    + ConstantesBD.tabla_turno + " as t ON co.id_turno = t.id_turno INNER JOIN "                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE t.desc_estado = 1 AND "                                                                    + condicion                                                                    + " GROUP BY pro.desc_apellido, pro.desc_nombre, es.descripcion"                                                                    + " ORDER BY COUNT(co.id_turno) desc");
            return resultado;
        }

        public SqlDataReader getCancelaciones_afiliados(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT TOP 5  a.desc_apellido, a.desc_nombre, es.descripcion as Especialidad, COUNT(co.id_turno) as Cantidad FROM "
                                                                   + ConstantesBD.tabla_afiliados + " as a, "
                                                                   + ConstantesBD.tabla_consulta + " as co INNER JOIN "
                                                                   + ConstantesBD.tabla_turno + " as t ON co.id_turno = t.id_turno INNER JOIN "
                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "
                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "
                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE t.desc_estado = 1 AND t.id_afiliado = a.id_afiliado AND"
                                                                   + condicion
                                                                   + " GROUP BY a.desc_apellido, a.desc_nombre, es.descripcion"
                                                                   + " ORDER BY COUNT(co.id_turno) desc");
            return resultado;
        }

        public SqlDataReader getProfMasConsultaPorEspecialidad(string condicion)
        {
            MessageBox.Show("SELECT TOP 5  pro.desc_apellido, pro.desc_nombre, es.descripcion as Especialidad, COUNT(co.id_turno) as Cantidad FROM "
                                                                   + ConstantesBD.tabla_consulta + " as co INNER JOIN "
                                                                   + ConstantesBD.tabla_turno + " as t ON co.id_turno = t.id_turno INNER JOIN "
                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "
                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "
                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE "
                                                                   + condicion
                                                                   + " GROUP BY pro.desc_apellido, pro.desc_nombre, es.descripcion"
                                                                   + " ORDER BY COUNT(co.id_turno) desc");
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT TOP 5  pro.desc_apellido, pro.desc_nombre, es.descripcion as Especialidad, COUNT(co.id_turno) as Cantidad FROM "                                                                    + ConstantesBD.tabla_consulta + " as co INNER JOIN "                                                                    + ConstantesBD.tabla_turno + " as t ON co.id_turno = t.id_turno INNER JOIN "                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE "                                                                    + condicion                                                                    + " GROUP BY pro.desc_apellido, pro.desc_nombre, es.descripcion"                                                                    + " ORDER BY COUNT(co.id_turno) desc");         
            return resultado;
        }

        public SqlDataReader getProfConMenosHorasTrabajadas(string condicion)
        {
            MessageBox.Show("SELECT TOP 5  pro.desc_apellido, pro.desc_nombre, es.descripcion as Especialidad, (COUNT(co.id_turno)*2) as Cantidad FROM "
                                                                   + ConstantesBD.tabla_consulta + " as co INNER JOIN "
                                                                   + ConstantesBD.tabla_turno + " as t ON co.id_turno = t.id_turno INNER JOIN "
                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "
                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "
                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE t.desc_estado = 0 AND "
                                                                   + condicion
                                                                   + " GROUP BY pro.desc_apellido, pro.desc_nombre, es.descripcion"
                                                                   + " ORDER BY (COUNT(co.id_turno)*2) ASC");
            SqlDataReader resultado;
            resultado = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT TOP 5  pro.desc_apellido, pro.desc_nombre, es.descripcion as Especialidad, (COUNT(co.id_turno)*2) as Cantidad FROM "                                                                    + ConstantesBD.tabla_consulta + " as co INNER JOIN "                                                                    + ConstantesBD.tabla_turno + " as t ON co.id_turno = t.id_turno INNER JOIN "                                                                   + ConstantesBD.tabla_esp_por_profesional + " as esxp ON t.id_profesional = esxp.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_profesional + " as pro ON esxp.id_profesional = pro.id_profesional INNER JOIN "                                                                   + ConstantesBD.tabla_especialidad + " as es ON esxp.id_especialidad = es.id_especialidad WHERE t.desc_estado = 0 AND "                                                                    + condicion                                                                    + " GROUP BY pro.desc_apellido, pro.desc_nombre, es.descripcion"
                                                                   + " ORDER BY (COUNT(co.id_turno)*2) ASC");
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
