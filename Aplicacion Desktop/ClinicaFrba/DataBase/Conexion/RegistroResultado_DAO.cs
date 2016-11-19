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
    class RegistroResultado_DAO : GDD_GO_DAO
    {
        public RegistroResultado_DAO()
        {
            this.iniciar();
        }


        public int afiliadoExistente(String afiliado)
        {
            MessageBox.Show("select 1 from GDD_GO.turno where id_afiliado ='" + afiliado + "';");

            SqlDataReader afiliadoExistente = this.GD2C2016.ejecutarSentenciaConRetorno("select 1 from GDD_GO.turno where id_afiliado ='" + afiliado + "';");
            if (afiliadoExistente.HasRows)
            {
                afiliadoExistente.Close();
                return 0;
            }
            else
            {
                afiliadoExistente.Close();
                return 1;
            }
        }

        public int llegoAlTurno(String afiliado)
        {
            int turno = get_turno(afiliado);
            MessageBox.Show("SELECT 1 FROM GDD_GO.consulta WHERE id_turno = '" + turno + "' AND desc_hora_llegada IS NOT NULL");
            SqlDataReader llegada = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT 1 FROM GDD_GO.consulta WHERE id_turno = '" + turno + "' AND desc_hora_llegada IS NOT NULL");

            if(llegada.HasRows)
            {
                llegada.Close();
                return 0;
            }
            else
            {
                llegada.Close();
                return 1;
            }
        }

       /* No necesito cargar la llegada en el registro de atención del turno, solo se necesita verificar que llegó

        public void cargarLlegadaEnConsulta(String afi, String llegada)
        {
            int turno = get_turno(afi);
            MessageBox.Show("UPDATE GDD_GO.consulta set desc_hora_llegada = '" + llegada +
                                                      "' + DATEADD(dd,0,DATEDIFF(dd,0,desc_hora_consulta)) WHERE id_turno = '" + turno + "';");
            this.GD2C2016.ejecutarSentenciaSinRetorno("UPDATE GDD_GO.consulta set desc_hora_llegada = '" + llegada +
                                                      "' + DATEADD(dd,0,DATEDIFF(dd,0,desc_hora_consulta)) WHERE id_turno = '" + turno + "';");        
        }
        */
        public void cargarDiagnosticoEnConsulta(String unAfi, String unSintoma, String unDiagnostico)
        {
            int turno = get_turno(unAfi);
            MessageBox.Show("UPDATE GDD_GO.consulta set desc_sintomas = '" + unSintoma +
                                                     "', desc_enfermedades = '" + unDiagnostico +
                                                     "' WHERE id_turno = '" + turno + "';");
            this.GD2C2016.ejecutarSentenciaSinRetorno("UPDATE GDD_GO.consulta set desc_sintomas = '" + unSintoma + 
                                                                               "', desc_enfermedades = '" + unDiagnostico + 
                                                                               "' WHERE id_turno = '" + turno + "';");
        
        }

        public int get_turno(String idAfiliado)
        {
            MessageBox.Show("SELECT id_turno FROM GDD_GO.turno WHERE id_afiliado = '" + idAfiliado + "';");
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT id_turno FROM GDD_GO.turno WHERE id_afiliado = '" + idAfiliado + "';");

            lector.Read();
            int turno;
            int.TryParse(lector["id_turno"].ToString(), out turno);          
            lector.Close();

            return turno;
        }

        public DateTime mostrarFechaTurno(String idAfiliado)
        {
            int turno = get_turno(idAfiliado);
            DateTime fechaTurno = new DateTime(1998, 04, 30);

            MessageBox.Show("SELECT DATEADD(dd,0,DATEDIFF(dd,0,desc_hora_consulta)) FROM GDD_GO.consulta WHERE id_turno = '" + turno + "';");

            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT DATEADD(dd,0,DATEDIFF(dd,0,desc_hora_consulta)) FROM GDD_GO.consulta WHERE id_turno = '" + turno + "';");
            List<string> resultado = new List<string>();
            if (lector.Read())
            {
                fechaTurno = (DateTime)lector[0];
            }

            lector.Close();

            return fechaTurno;
        }

        /*  CONVERT(VARCHAR(10), Fecha_Contacto, 108) AS Fecha_Contacto*/
        public String mostrarHoraTurnoLlegada(String idAfiliado)
        {
            int turno = get_turno(idAfiliado);
            String horaTurno = "";

            MessageBox.Show("SELECT CONVERT(VARCHAR(10), desc_hora_llegada,108) from GDD_GO.consulta WHERE id_turno = '" + turno + "'");
            SqlDataReader lector = this.GD2C2016.ejecutarSentenciaConRetorno("SELECT CONVERT(VARCHAR(10), desc_hora_llegada,108) from GDD_GO.consulta WHERE id_turno = '" + turno + "'");
            if (lector.Read())
            {
                horaTurno = (String)lector[0];
            }

            lector.Close();

            return horaTurno;
        }

        public string getHoraTurno(int turno_id)
        {
            SqlDataReader reader = this.GD2C2016.ejecutarSentenciaConRetorno("Select desc_hora_desde from GDD_GO.horario where id_turno =+'" + turno_id + "'");
            reader.Read();
            DateTime hora = DateTime.Parse(reader["desc_hora_desde"].ToString());
            reader.Close();
            return hora.ToString("hh':'mm");
        }


        
        }



    }

