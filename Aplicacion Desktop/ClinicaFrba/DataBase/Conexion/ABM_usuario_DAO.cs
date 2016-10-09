using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.DataBase.Conexion
{
    class ABM_usuario_DAO : GDAA_DAO
    {
        public ABM_usuario_DAO()
        {
            this.iniciar();
        }

        public int validarDNIExistente(String DNI)
        {
            SqlDataReader dniExistente = this.GD2C2016.ejecutarSentenciaConRetorno("select 1 from GDD_GO.Afiliado where desc_Dni = Convert(numeric(18,0),'" + DNI + "');");
            if (dniExistente.HasRows)
            {
                dniExistente.Close();
                return 0;
            }
            else
            {
                dniExistente.Close();
                return 1;
            }
        }

        public void altaAfiliado(int id_nro_familiar, String desc_Nombre, String desc_Apellido, int desc_sexo, String tipo_doc, String desc_Dni, String desc_Mail, String desc_Dom, String desc_Telefono, int desc_Estado_Civil, String desc_fecha_nac, String desc_fecha_creacion)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("exec GDD_GO.alta_afiliado @nro_familiar = "+id_nro_familiar+" ,@nombre = '"+desc_Nombre+"' ,@apellido = '"+desc_Apellido+"',@sexo = "+desc_sexo+" ,@tipo_doc = '"+tipo_doc+"' ,@dni = "+desc_Dni+" ,@mail = '"+desc_Mail+"' ,@direccion = '"+desc_Dom+"', @telefono = "+desc_Telefono+", @estado_civil = "+desc_Estado_Civil+", @fecha_nac = '"+desc_fecha_nac+"', @fecha_creacion = '"+desc_fecha_creacion+"'");
        }

        public List<string> get_afiliados_con_dni(String dni)
        {

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_afiliado from GDD_GO.afiliado where desc_dni = "+dni+"");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_afiliado"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public String get_apellido(String id_afiliado)
        {
            string apellido = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_apellido from GDD_GO.afiliado where id_afiliado = " + id_afiliado + "");
            List<string> resultado = new List<string>();

            if (lector.Read())
                apellido = (string)lector[0];
            lector.Close();


            return apellido;
        }

        public String get_nombre(String id_afiliado)
        {
            string apellido = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_nombre from GDD_GO.afiliado where id_afiliado = " + id_afiliado + "");
            List<string> resultado = new List<string>();

            if (lector.Read())
                apellido = (string)lector[0];
            lector.Close();


            return apellido;
        }

        public String get_mail(String id_afiliado)
        {
            string apellido = "";

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_mail from GDD_GO.afiliado where id_afiliado = " + id_afiliado + "");
            List<string> resultado = new List<string>();

            if (lector.Read())
                apellido = (string)lector[0];
            lector.Close();


            return apellido;
        }

        public DateTime get_fecha_nac(String id_afiliado)
        {
            DateTime apellido = new DateTime(1998,04,30);

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select CONVERT(date, desc_fecha_nac) from GDD_GO.afiliado where id_afiliado = " + id_afiliado + "");
            List<string> resultado = new List<string>();

            if (lector.Read())
                apellido = (DateTime)lector[0];
            lector.Close();


            return apellido;
        }
    }
}
