using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using ClinicaFrba.Excepciones;


namespace ClinicaFrba.Conexion
{
    /// <summary>
    /// La clase se utiliza para manipular la conexion con el servidor SQL
    /// </summary>
    class SQLServerBD
    {
        //La conexion en si
        private SqlConnection conexion;

        /// <summary>
        /// El metodo se utiliza para establecer todos los parametros de la conexion con el servidor SQL
        /// </summary>
        /// <param name="urlServidor">
        /// Ip del servidor SQL
        /// </param>
        /// <param name="usuario">
        /// Nombre de usuario del servidor SQL
        /// </param>
        /// <param name="contraseña">
        /// Contraseña de usuario del servidor SQL
        /// </param>
        /// <param name="nombre">
        /// Nombre de la base de datos SQL con la cual se realizara la conexion
        /// </param>
        /// <param name="conexionSegura">
        /// Indicador del tipo de conexion segura/insegura los valores a adoptar son "true" o "false" respectivamente
        /// </param>
        /// <param name="tiempoLimiteDeEspera">
        /// Tiempo maximo (en segundos y >0) que se mantendra la conexion, en espera por una respuesta de parte del servidor
        /// </param>
        public SQLServerBD
        (
            String urlServidor,
            String usuario,
            String contraseña,
            String nombre,
            String conexionSegura,
            String tiempoLimiteDeEspera
        )
        {
            this.conexion = new SqlConnection( 
                "User ID=" + usuario + ";" +
                "Password=" + contraseña + ";" +
                "Server=" + urlServidor + ";" +
                "Database=" + nombre + ";" +
                "Connection Timeout=" + tiempoLimiteDeEspera);
        }
        /// <summary>
        /// El metodo se utiliza para establecer la conexion con el servidor SQL segun los parametros establecidos
        /// </summary>
        public void abrir()
        {
            try
            {
                this.conexion.Open();
            }
            catch (Exception e)
            {
                throw new ConexionFallidaException("No se logro abrir la conexion con el servidor SQL", e);
            }
        }

        /// <summary>
        /// El metodo se utiliza para cerrar la conexion abierta con el servidor SQL
        /// </summary>
        public void cerrar()
        {
            try
            {
                this.conexion.Close();
            }
            catch (Exception e)
            {
                throw new CierreConexionFallidaException("No se logro cerrar la conexion con el servidor SQL", e);
            }
        }

        /// <summary>
        /// El metodo se utiliza para ejecutar una sentencia SQL de la cual no se espera retorno alguno.Un ejemplo seria INSERT
        /// </summary>
        /// <param name="sentenciaSQL">
        /// La sentencia SQL sin retorno, a ejecutar (en texto)
        /// </param>
        public void ejecutarSentenciaSinRetorno(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = new SqlCommand(sentenciaSQL, this.conexion);

                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new EjecucionComandoFallidaException("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
        }

        /// <summary>
        /// El metodo se utiliza para ejecutar una sentencia SQL de la cual se espera retorno de datos. Un ejemplo seria SELECT
        /// </summary>
        /// <param name="sentenciaSQL">
        /// La sentencia SQL con retorno, a ejecutar (en texto)
        /// </param>
        /// <returns>
        /// Una instancia de SqlDataReader la cual mediante el metodo Read() permite ser iterada para extraer los datos recibidos del servidor SQL
        /// </returns>
        /// <remarks>
        /// Recordar que una vez utilizada la instancia de SqlDataReader se debe cerrar con el metodo Close() de lo contrario no se podran ejecutar mas sentencias SQL luego de esta
        /// </remarks>
        public SqlDataReader ejecutarSentenciaConRetorno(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = new SqlCommand(sentenciaSQL, this.conexion);
                
                comando.CommandType = CommandType.Text;
                return comando.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new EjecucionComandoFallidaException("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
        }

        /// <summary>
        /// El metodo se utiliza para ejecutar un procedimiento almacenado en el servidor SQL del cual se espera retorno de datos
        /// </summary>
        /// <param name="identificadorDeProcedimiento">
        /// El nombre identificador del procedimiento almacenado en el servidor SQL
        /// </param>
        /// <param name="coleccionDeParametros">
        /// Una coleccion de instancias de SqlParameter, que representan los parametros que recibira el procedimiento almacenado en el servidor SQL
        /// </param>
        /// <returns>
        /// Una instancia de SqlDataReader la cual mediante el metodo Read() permite ser iterada para extraer los datos recibidos del procedimiento almacenado en el servidor SQL
        /// </returns>
        /// <remarks>
        /// Recordar que una vez utilizada la instancia de SqlDataReader se debe cerrar con el metodo Close() de lo contrario no se podran ejecutar mas sentencias SQL luego de esta
        /// </remarks>
        public SqlDataReader ejecutarProcedimiento(String identificadorDeProcedimiento, List<SqlParameter> coleccionDeParametros)
        {
            try
            {
                SqlCommand comando = new SqlCommand(identificadorDeProcedimiento, this.conexion);

                comando.CommandType = CommandType.StoredProcedure;
                IEnumerator enumerador = coleccionDeParametros.GetEnumerator();
                while (enumerador.MoveNext())
                {
                    comando.Parameters.Add(enumerador.Current);
                }
                return comando.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new EjecucionComandoFallidaException("El comando solicitado no pudo ser ejecutado en el servidor SQL", e);
            }
        }
    }
}