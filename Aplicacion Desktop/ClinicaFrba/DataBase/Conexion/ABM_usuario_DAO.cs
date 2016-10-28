using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.DataBase.Conexion
{
    class ABM_usuario_DAO : GDD_GO_DAO
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

        public int validarUsuarioExistente(String DNI)
        {
            SqlDataReader userExistente = this.GD2C2016.ejecutarSentenciaConRetorno("select 1 from GDD_GO.usuario where desc_username='" + DNI + "';");
            if (userExistente.HasRows)
            {
                userExistente.Close();
                return 0;
            }
            else
            {
                userExistente.Close();
                return 1;
            }
        }

        public void altaAfiliado(String id_nro_familiar, String desc_Nombre, String desc_Apellido, int desc_sexo, String tipo_doc, String desc_Dni, String desc_Mail, String desc_Dom, String desc_Telefono, int desc_Estado_Civil, String desc_fecha_nac)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.afiliado(  desc_nombre ,desc_apellido,desc_sexo,desc_tipo_doc,desc_dni,desc_mail,desc_direccion,desc_telefono,desc_estado_civil,desc_fecha_nac,id_familiar_principal) Values ('" +
                                                        desc_Nombre + "','" +
                                                        desc_Apellido + "'," +
                                                        desc_sexo + ",'" +
                                                        tipo_doc + "'," +
                                                        desc_Dni + ",'" +
                                                        desc_Mail + "','" +
                                                        desc_Dom + "'," +
                                                        desc_Telefono + "," +
                                                        desc_Estado_Civil + "," +
                                                        desc_fecha_nac + "," +
                                                        id_nro_familiar + ")");
        }

        public void bajaAfiliado(int id_usuario)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Delete GDD_GO.usuario where id_usuario = " + id_usuario);
        }


        public void crearUsuario(String user, String pass)
        {
            MessageBox.Show("Insert into GDD_GO.usuario (desc_username, desc_password, desc_estado) Values('" +
                                                       user + "','" +
                                                       pass + "', 1);");
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.usuario (desc_username, desc_password, desc_estado) Values('"+
                                                       user + "',HASHBYTES('sha2_256','" +
                                                       pass+"'), 1);");
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

        public List<string> get_id_afiliado_multiple(String desc_nombre, String desc_apellido, String desc_dni)
        {
            if (desc_nombre != "" || desc_nombre != " ")
            {
                desc_nombre = "desc_nombre LIKE '%" + desc_nombre + "%' AND ";
            }
            if (desc_apellido != "" || desc_apellido != " ")
            {
                desc_apellido = "desc_apellido LIKE '%" + desc_apellido + "%' AND ";
            }
            if (desc_dni != "" || desc_dni != " ")
            {
                desc_dni = " desc_dni LIKE '%" + desc_dni + "%'";
            }
            
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT id_afiliado FROM " + ConstantesBD.tabla_afiliados + " af JOIN GDD_GO.usuario us on af.id_usuario = us.id_usuario And us.desc_estado != 2"+
                                                                             " AND " + desc_nombre + desc_apellido + desc_dni +
                                                                             " ORDER BY id_afiliado asc");

            List<string> resultado = new List<string>();


            while (lector.Read())
            {
                resultado.Add(lector["id_afiliado"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public void actualizarAfiliado(String desc_direccion, String descMail, String descTelefono, String sexo, String estado_civil,int idAfiliado)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Update GDD_GO.afiliado set desc_direccion='"+desc_direccion+
                                                                              "', desc_mail='"+descMail+
                                                                              "', desc_telefono="+descTelefono+
                                                                              ", desc_sexo="+sexo+
                                                                              ", desc_estado_civil="+estado_civil+
                                                                              " where id_afiliado="+idAfiliado+";");
            MessageBox.Show("El afiliado ha sido modificada Satisfactoriamente");
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

        public int get_dni(String id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_dni from GDD_GO.afiliado where id_afiliado = " + id_afiliado + "");
            lector.Read();
            int cantidad;
            int.TryParse(lector["desc_dni"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
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

        public int get_id_usuario(String id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_usuario from " + ConstantesBD.tabla_afiliados +" where id_afiliado = " + id_afiliado + "");
            lector.Read();
            int cantidad;
            int.TryParse(lector["id_usuario"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
        }


        public int get_plan_medico(String id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select id_plan_medico from GDD_GO.afiliado where id_afiliado="+id_afiliado);
            lector.Read();
            int cantidad;
            int.TryParse(lector["id_plan_medico"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
        }
    }
}
