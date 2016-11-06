using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;

namespace ClinicaFrba.DataBase.Conexion
{
    class RegistroLlegada_DAO : GDD_GO_DAO
    {
        public RegistroLlegada_DAO()
        {
       
            this.iniciar();
        }

        /* OBTENGO TODOS LOS NOMBRES DE ESPECIALIDADES QUE EXISTEN*/
        public List<string> obtenerEspecialidades()        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select [descripcion] from [GDD_GO].[especialidad]");
            List<string> especialidades = new List<string>();
            while (reader.Read())
            {
                especialidades.Add(reader["descripcion"].ToString());
            }
            reader.Close();

            return especialidades;
        }

        /* OBTENGO TODOS LOS NOMBRES DE PROFESIONALES QUE EXISTEN*/
        public List<string> obtenerProfesionales()
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select (desc_apellido +' '+ desc_nombre)as c from [GDD_GO].[profesional]");
            List<string> profesionales = new List<string>();
            while (reader.Read())
            {
                profesionales.Add(reader["c"].ToString());
            }
            reader.Close();

            return profesionales;
        }
       
        /* OBTENGO LOS NOMBRES DE PROFESIONALES SEGUN ESPECIALIDAD */
        public List<string> obtenerProfesionalesPorEspecialidad(string especialidadElegida)
        {
            //CREAR UNA VISTA//CREAR UNA VISTA//CREAR UNA VISTA//CREAR UNA VISTA//CREAR UNA VISTA
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select nombre from [GDD_GO].[vista_especialidad_profesional] where descripcion = '"+especialidadElegida+"'");
            List<string> profesionales = new List<string>();
            while (reader.Read())
            {
                profesionales.Add(reader["nombre"].ToString());
            }
            reader.Close();

            return profesionales;
        }
       
      
         
        /* INSERTO ROL */
        public void altaRol(String desc_nombre_rol)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.rol(  desc_nombre_rol ) Values ('" +
                                                        desc_nombre_rol + "')");
        }

        /* ELIMINO ROL (hay un TR en la DB que hace su baja logica con un instead of delete) */
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
            this.GD2C2016.ejecutarSentenciaSinRetorno("Update GDD_GO.rol Set desc_estado_rol = 1 where desc_nombre_rol = '" + rolSeleccionado + "'");
        }

        /* OBTENGO FUNCINALIDADES X ROL */
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

        public void InsertarFuncionRol(string funcion, string desc_nombre_rol)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_rol from GDD_GO.rol where desc_nombre_rol = '" +
                                                                                                                desc_nombre_rol + "'");
            reader.Read();
            int id_rol = Int32.Parse(reader["id_rol"].ToString());
            reader.Close();
            reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_funcion from GDD_GO.funcion where desc_funcion = '" + funcion + "'");
            reader.Read();
            int id_funcion = Int32.Parse(reader["id_funcion"].ToString());           
            reader.Close();

            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.funciones_por_rol values ("+ id_rol +","+ id_funcion +")");
         
        }
        
        public void EliminarFuncionRol(string funcion, string desc_nombre_rol)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_rol from GDD_GO.rol where desc_nombre_rol = '" +
                                                                                                                desc_nombre_rol + "'");
            reader.Read();
            int id_rol = Int32.Parse(reader["id_rol"].ToString());
            reader.Close();
            reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_funcion from GDD_GO.funcion where desc_funcion = '" + funcion + "'");
            reader.Read();
            int id_funcion = Int32.Parse(reader["id_funcion"].ToString());
            reader.Close();

            this.GD2C2016.ejecutarSentenciaSinRetorno("Delete from GDD_GO.funciones_por_rol where id_rol =" + id_rol + "and id_funcion =" + id_funcion);



        }

        
    }
}
