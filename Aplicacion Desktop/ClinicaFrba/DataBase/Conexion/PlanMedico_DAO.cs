using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.DataBase.Conexion
{
    class PlanMedico_DAO : GDD_GO_DAO
    {
        public PlanMedico_DAO()
        {
            this.iniciar();
        }

        public List<string> get_id_bono_multiple(int id_plan_medico)
        {

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_tipo_bono from GDD_GO.tipo_bono where id_plan_medico ="+id_plan_medico);

            List<string> resultado = new List<string>();


            while (lector.Read())
            {
                resultado.Add(lector["id_tipo_bono"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public List<string> get_id_plan_medico_multiple(String id_plan)
        {

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select id_plan_medico from GDD_GO.plan_medico where id_plan_medico!=" + id_plan);

            List<string> resultado = new List<string>();


            while (lector.Read())
            {
                resultado.Add(lector["id_plan_medico"].ToString());
            }

            lector.Close();
            return resultado;
        }
        
        public void comprarBono(String id_afiliado, int id_plan_medico)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.bono_comprado (id_afiliado, id_plan_medico, id_bono_comprado, desc_estado, desc_fecha_compra, desc_fecha_impresion) Values "+
                                                      "("+id_afiliado+","+id_plan_medico+", (select Max(id_bono_comprado)+1 from GDD_GO.bono_comprado), 1, GETDATE(), GETDATE())");
        }

        public String get_nombre(String id_plan_medico)
        {
            string apellido = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select descripcion from GDD_GO.plan_medico where id_plan_medico = " + id_plan_medico + "");
            List<string> resultado = new List<string>();

            if (lector.Read())
                apellido = (string)lector[0];
            lector.Close();


            return apellido;
        }
    }
}
