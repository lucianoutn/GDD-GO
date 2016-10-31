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
    class LoginDAO : GDD_GO_DAO
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


        public int get_id_usuario(string username)
        {
            SqlDataReader usuario = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_usuario from GDD_GO.usuario where desc_username = '" +
                                                                                                                username + "'");
            usuario.Read();
            int id = Int32.Parse(usuario["id_usuario"].ToString());
            usuario.Close();
            return id;
        }

        public string get_rol(int id_usuario)
        {
            SqlDataReader rol = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_nombre_rol from GDD_GO.vista_rol_usuario where id_usuario = '" +
                                                                                                    id_usuario.ToString() + "' and desc_estado_rol = 1");
            rol.Read();
            string desc_nombre_rol = rol["desc_nombre_rol"].ToString();
            rol.Close();
            return desc_nombre_rol;
        }

        public List<string> get_funcionalidades(string rol)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_funcion from GDD_GO.vista_rol_funciones where desc_nombre_rol = '" +
                                                                                rol + "'");
            List<string> resultado = new List<string>();
            while (lector.Read())
            {
                resultado.Add(lector["desc_funcion"].ToString());
            }
            lector.Close();
            return resultado;
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }
    }
}
