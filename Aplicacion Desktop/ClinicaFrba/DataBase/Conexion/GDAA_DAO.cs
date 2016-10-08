using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClinicaFrba.Conexion
{
    abstract class GDAA_DAO
    {
        protected SQLServerBD GD2C2016;

        protected void iniciar()
        {
            this.GD2C2016 = new SQLServerBD(ClinicaFrba.DataBase.Conexion.ConstantesBD.Param_Conexion_urlServidor,
                ClinicaFrba.DataBase.Conexion.ConstantesBD.Param_Conexion_usuario,
                ClinicaFrba.DataBase.Conexion.ConstantesBD.Param_Conexion_contraseña,
                ClinicaFrba.DataBase.Conexion.ConstantesBD.Param_Conexion_nombreBD, "true", "1000");
            this.GD2C2016.abrir();
        }

        public void finalizar()
        {
            this.GD2C2016.cerrar();
        }
    }
}