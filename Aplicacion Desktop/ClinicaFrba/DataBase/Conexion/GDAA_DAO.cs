using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClinicaFRBA.Conexion
{
    abstract class GDAA_DAO
    {
        protected SQLServerBD GD2C2016;

        protected void iniciar()
        {
            this.GD2C2016 = new SQLServerBD(ClinicaFRBA.DataBase.Conexion.ConstantesBD.Param_Conexion_urlServidor,
                ClinicaFRBA.DataBase.Conexion.ConstantesBD.Param_Conexion_usuario,
                ClinicaFRBA.DataBase.Conexion.ConstantesBD.Param_Conexion_contraseña,
                ClinicaFRBA.DataBase.Conexion.ConstantesBD.Param_Conexion_nombreBD, "true", "1000");
            this.GD2C2016.abrir();
        }

        public void finalizar()
        {
            this.GD2C2016.cerrar();
        }
    }
}