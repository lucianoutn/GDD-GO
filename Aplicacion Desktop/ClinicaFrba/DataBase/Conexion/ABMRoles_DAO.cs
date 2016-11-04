using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;

namespace ClinicaFrba.DataBase.Conexion
{
    class ABMRoles_DAO : GDD_GO_DAO
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

        /* OBTENGO TODOS LOS NOMBRES DE ROLES activos*/
        public List<string> obtenerRolesActivos()
        {
            SqlDataReader roles = this.GD2C2016.ejecutarSentenciaConRetorno("Select [desc_nombre_rol] from [GDD_GO].[rol] where [desc_estado_rol] = 1");
            List<string> nombresRoles = new List<string>();
            while (roles.Read())
            {
                nombresRoles.Add(roles["desc_nombre_rol"].ToString());
            }
            roles.Close();

            return nombresRoles;
        }

        /* OBTENGO TODAS LAS FUNCIONES EXISTENTES */
        public List<string> getfunciones()
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_funcion from GDD_GO.funcion");
            List<string> resultado = new List<string>();
            while (lector.Read())
            {
                resultado.Add(lector["desc_funcion"].ToString());
            }
            lector.Close();
            return resultado;
        }
         
        /* INSERTO ROL */
        public void altaRol(String desc_nombre_rol)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.rol(  desc_nombre_rol ) Values ('" +
                                                        desc_nombre_rol + "')");
        }

        /* ELIMINO ROL (hay un TR en la DB que hace su baja logica con un instead of delete */
        public void bajaRol(String desc_nombre_rol)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Delete GDD_GO.rol where desc_nombre_rol = '" + desc_nombre_rol +"'");
        }

       
        /* CONSULTO EL ESTADO DEL ROL PARA MOSTRAR O NO SU REACTIVACION */
        public bool consultaEstadoRol(String rolSeleccionado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select [desc_estado_rol] from GDD_GO.rol where desc_nombre_rol = '" + rolSeleccionado +"'");

            lector.Read();
            bool estado = (bool)lector["desc_estado_rol"];
            lector.Close();
            return estado;
            
            
        }
        
        /* REACTIVO ROL */
        public void reactivarRol(string rolSeleccionado)
        {
            this.GD2C2016.ejecutarSentenciaConRetorno("Update GDD_GO.rol Set desc_estado_rol = 1 where desc_nombre_rol = '" + rolSeleccionado + "'");
        }
    }
}
