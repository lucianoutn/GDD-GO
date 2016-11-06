using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClinicaFrba.ABM_Usuario;

namespace ClinicaFrba.DataBase.Conexion
{
    class RegistroResultado_DAO : GDD_GO_DAO
    {
        public RegistroResultado_DAO()
        {
            this.iniciar();
        }


        public int afiliadoExistente(String afiliado)
        {
            MessageBox.Show("select 1 from GDD_GO.turno where id_afiliado ='" + afiliado + "';");

            SqlDataReader afiliadoExistente = this.GD2C2016.ejecutarSentenciaConRetorno("select 1 from GDD_GO.turno where id_afiliado ='" + afiliado + "';");
            if (afiliadoExistente.HasRows)
            {
                afiliadoExistente.Close();
                return 0;
            }
            else
            {
                afiliadoExistente.Close();
                return 1;
            }
        }


        public void cargarLlegadaEnConsulta(String afi, String llegada)
        {
            int turno = get_turno(afi);
            MessageBox.Show("UPDATE GDD_GO.consulta set desc_hora_llegada = '" + llegada +
                                                      "' + DATEADD(dd,0,DATEDIFF(dd,0,desc_hora_consulta)) WHERE id_turno = '" + turno + "';");
            this.GD2C2016.ejecutarSentenciaSinRetorno("UPDATE GDD_GO.consulta set desc_hora_llegada = '" + llegada +
                                                      "' + DATEADD(dd,0,DATEDIFF(dd,0,desc_hora_consulta)) WHERE id_turno = '" + turno + "';");

            
        }

        public int get_turno(String idAfiliado)
        {
            MessageBox.Show("SELECT id_turno FROM GDD_GO.turno WHERE id_afiliado = '" + idAfiliado + "';");
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT id_turno FROM GDD_GO.turno WHERE id_afiliado = '" + idAfiliado + "';");

            lector.Read();
            int turno;
            int.TryParse(lector["id_turno"].ToString(), out turno);          
            lector.Close();

            return turno;
        }
    }
}
