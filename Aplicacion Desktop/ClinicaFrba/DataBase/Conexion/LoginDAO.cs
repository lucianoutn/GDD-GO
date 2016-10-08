using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Excepciones;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.DataBase.Conexion
{
    class LoginDAO : GDAA_DAO
    {
        public LoginDAO()
        {
            this.iniciar();
        }

        public string validar_login(string username, string password)
        {
            SqlDataReader resultado = this.GD2C2016.ejecutarSentenciaConRetorno("Execute GDD_GO.logearse @user = '" + username + 
                                                                                                     "', @pass = '" + password + "'");
            resultado.Read();
            string aux = resultado["mensaje"].ToString();
            resultado.Close();
            return aux;
        }

        public void iniciar_aplicacion()
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Execute GDD_GO.inicializar_modelo @fechasys = '" + ConstantesBD.fechaSistema + "';");
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }
    }
}
