using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;

namespace ClinicaFrba.DataBase.Conexion
{
    class ABMRoles_DAO : GDAA_DAO
    {
        public ABMRoles_DAO() {
       
            this.iniciar();
        }

        /* OBTENGO TODOS LOS NOMBRES DE ROLES QUE EXISTEN*/
        public List<string> obtenerRoles()        {
            SqlDataReader roles = this.GD2C2016.ejecutarSentenciaConRetorno("Select [desc_nombre_rol] from [GDD_GO].[rol]");
            List<string> nombresRoles = new List<string>();
            while (roles.Read())
            {
                nombresRoles.Add(roles["desc_nombre_rol"].ToString());
            }
            roles.Close();

            return nombresRoles;
        }
    }
}
