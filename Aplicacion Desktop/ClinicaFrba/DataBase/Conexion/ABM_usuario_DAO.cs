using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaFrba.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClinicaFrba.ABM_Usuario;

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
            SqlDataReader userExistente = this.GD2C2016.ejecutarSentenciaConRetorno("select id_usuario from GDD_GO.usuario where desc_username='" + DNI + "';");

            int cantidad = 0;

            if (userExistente.Read())
                int.TryParse(userExistente["id_usuario"].ToString(), out cantidad);
           
            if (userExistente.HasRows)
            {
                userExistente.Close();
                return cantidad;
            }
            else
            {
                userExistente.Close();
                return 1;
            }
        }

        public void altaAfiliado(String id_nro_familiar, String desc_Nombre, String desc_Apellido, int desc_sexo, String tipo_doc, String desc_Dni, String desc_Mail, String desc_Dom, String desc_Telefono, int desc_Estado_Civil, String desc_fecha_nac, String plan_medico, String id_usuario)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.afiliado(  desc_nombre ,desc_apellido,desc_sexo,desc_tipo_doc,desc_dni,desc_mail,desc_direccion,desc_telefono,desc_estado_civil,desc_fecha_nac,id_familiar_principal,id_plan_medico, id_usuario) Values ('" +
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
                                                        id_nro_familiar + "," +
                                                        plan_medico +","+
                                                        id_usuario+")");
        }


        public void bajaAfiliado(int id_usuario, int id_afiliado)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Delete GDD_GO.usuario where id_usuario = " + id_usuario);
        }


        public void crearUsuario(String user, String pass)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Insert into GDD_GO.usuario (desc_username, desc_password, desc_estado) Values('"+
                                                       user + "',HASHBYTES('sha2_256','" +
                                                       pass+"'), 1);");
        }

        public void cambiarPlanMedico(String id_afiliado, String id_plan_medico, String motivo)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("EXECUTE GDD_GO.sp_cambiar_plan_medico @afiliado = " + id_afiliado + ", @plan_medico=" + id_plan_medico+", @motivo='"+motivo+"'");
        }

        public void comprarPlanMedico(String id_afiliado, String id_plan_medico)
        {
            this.GD2C2016.ejecutarSentenciaSinRetorno("Update GDD_GO.afiliado set id_plan_medico="+id_plan_medico+" where id_afiliado="+id_afiliado);
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

        public List<string> get_id_afiliado(String id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select id_afiliado from GDD_GO.afiliado where id_afiliado="+id_afiliado);

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
            
            int cantidad = 0;
            
            if (lector.Read())
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
            
            int cantidad=0;
            if (lector.Read())
                int.TryParse(lector["id_usuario"].ToString(), out cantidad);
            
            lector.Close();
            return cantidad;
        }


        public int get_plan_medico(String id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select id_plan_medico from GDD_GO.afiliado where id_afiliado="+id_afiliado);
            lector.Read();
            int cantidad=0;
            int.TryParse(lector["id_plan_medico"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
        }

        public User getUsuarioDe(Int32 _id)
        {
            User user = new User();
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select u.* from " + ConstantesBD.tabla_usuarios+" u where u.id_usuario = " +_id.ToString());
            lector.Read();
                user.setIdUsuario(lector.GetInt32(0).ToString());
                user.setUsername(lector.GetString(1));
            lector.Close();
            return user;
        }

        public int get_id_afiliado(int id_usuario)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_afiliado from " + ConstantesBD.tabla_afiliados + " where id_usuario = " + id_usuario + "");
            lector.Read();
            int cantidad;
            int.TryParse(lector["id_afiliado"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
        }

        public int get_id_profesional(int id_usuario)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_profesional from " + ConstantesBD.tabla_profesional + " where id_usuario = " + id_usuario + "");
            lector.Read();
            int cantidad;
            int.TryParse(lector["id_profesional"].ToString(), out cantidad);
            lector.Close();
            return cantidad;
        }

       public List<int> getIdsHistorial(string id_afiliado)
        {
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("select * from GDD_GO.hist_cambios_plan_afiliado h where h.id_afiliado ='"+ id_afiliado +"' order by h.desc_fecha_modificacion asc");
            List<int> resultado = new List<int>();
            while (lector.Read())
            {
                resultado.Add(Int32.Parse(lector["id_historial"].ToString()));
            }
            lector.Close();
            return resultado;
        }

       public string getFechaModificacion(int id_historial)
       {
           SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_fecha_modificacion from GDD_GO.hist_cambios_plan_afiliado where id_historial ='" + id_historial + "'");
           reader.Read();
           DateTime hora = DateTime.Parse(reader["desc_fecha_modificacion"].ToString());
           reader.Close();
           return hora.ToString("dd'/'MM'/'yyyy");
       }

       public string getMotivo(int id_historial)
       {
           SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_motivo from GDD_GO.hist_cambios_plan_afiliado where id_historial ='" + id_historial + "'");
           reader.Read();
           string motivo = reader["desc_motivo"].ToString();
           reader.Close();
           return motivo;
       }

       public int getPlanAnterior(int id_historial)
       {
           SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select id_plan_medico_anterior as id from GDD_GO.hist_cambios_plan_afiliado where id_historial ='" + id_historial + "'");
           reader.Read();
           int id = Int32.Parse(reader["id"].ToString());
           reader.Close();
           return id;
       }
    }
}
