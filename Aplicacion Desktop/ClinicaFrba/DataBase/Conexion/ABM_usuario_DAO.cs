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

        public void altaAfiliado(String desc_Nombre, String desc_Apellido, int desc_sexo, String tipo_doc, String desc_Dni, String desc_Mail, String desc_Dom, String desc_Telefono, int desc_Estado_Civil, String desc_fecha_nac, String desc_fecha_creacion)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("exec GDD_GO.alta_afiliado @nombre = '"+desc_Nombre+"' ,@apellido = '"+desc_Apellido+"',@sexo = "+desc_sexo+" ,@tipo_doc = '"+tipo_doc+"' ,@dni = "+desc_Dni+" ,@mail = '"+desc_Mail+"' ,@direccion = '"+desc_Dom+"', @telefono = "+desc_Telefono+", @estado_civil = "+desc_Estado_Civil+", @fecha_nac = '"+desc_fecha_nac+"', @fecha_creacion = '"+desc_fecha_creacion+"'");
        }
    }
}
