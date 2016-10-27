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
        
        public void comprarBono(String id_tipo_bono, String id_afiliado)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.bono_comprado (id_tipo_bono, id_afiliado, desc_estado, desc_fecha_compra, desc_fecha_impresion) Values "+
                                                      "("+id_tipo_bono+", "+ id_afiliado+", 0, GETDATE(), GETDATE())");
        }
    }
}
