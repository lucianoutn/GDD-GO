using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DataBase.Conexion
{
    abstract class ConstantesBD
    {
        public static String fechaSistema;
        public static String Param_Conexion_urlServidor;
        public static String Param_Conexion_usuario;
        public static String Param_Conexion_contraseña;
        public static String Param_Conexion_nombreBD;
        
        //Todas las tablas
        public static String tabla_usuarios = "GDD_GO.usuario";
        public static String tabla_afiliados = "GDD_GO.afiliado";
        public static String tabla_agenda = "GDD_GO.agenda";
        public static String tabla_bono_comprado = "GDD_GO.bono_comprado";
        public static String tabla_consulta = "GDD_GO.consulta";
        public static String tabla_especialidad = "GDD_GO.especialidad";
        public static String tabla_esp_por_profesional = "GDD_GO.especialidades_por_profesional"; 
        public static String tabla_funcion = "GDD_GO.funcion";
        public static String tabla_func_por_rol = "GDD_GO.funciones_por_rol";
        public static String tabla_hist_cambios = "GDD_GO.hist_cambios_plan_afiliado";
        public static String tabla_horario = "GDD_GO.horario";
        public static String tabla_plan_medico = "GDD_GO.plan_medico";
        public static String tabla_profesional = "GDD_GO.profesional";
        public static String tabla_rol = "GDD_GO.rol";
        public static String tabla_roles_por_usuario = "GDD_GO.roles_por_usuario";
        public static String tabla_t_bono = "GDD_GO.tipo_bono";
        public static String tabla_t_cancelacion = "GDD_GO.tipo_cancelacion";
        public static String tabla_t_especialidad = "GDD_GO.tipo_especialidad";
        public static String tabla_turno = "GDD_GO.turno";


        public static bool horarioInicio(Int32 hora, Int32 min, char desc_dia)
        {
            if (desc_dia != 'S')
            {
                return (hora >= 7) && (hora <= 20);
            }else{
                return (hora >= 10) && (hora <= 15);
            }
        }
        public static bool horarioFin(Int32 hora, Int32 min, char desc_dia)
        {
            if (desc_dia != 'S')
            {
                return (hora >= 7) && (hora <= 20);
            }
            else
            {
                return (hora >= 10) && (hora <= 15);
            }
        }
        public static String darFormatoFecha(DateTime fecha)
        {
            return fecha.Date.Day.ToString() + "/" +
                                fecha.Date.Month.ToString() + "/" +
                                fecha.Date.Year.ToString();
        }
        // Recibe una fecha en formato DD/MM/AAAA y devuelve DD si parte==0, MM si parte ==1 y AAAA si parte ==2
        public static Int32 getParteDeFecha(String fecha,Int32 parte)
        {
            char[] delimitadores = { '/' };
            string[] palabras = fecha.Split(delimitadores);
            return Int32.Parse(palabras[parte]);
        }
        // Recibe una fecha en formato DD/MM/AAAA y lo convierte a formato de BD: AAAAMMDD 00:00:00.00
        public static String cambiarFormatoFecha(String fecha)
        {
            String fechaConFormato = "";
            char[] delimitadores = { '/' };

            string[] palabras = fecha.Split(delimitadores);

            foreach (string s in palabras)
            {
                fechaConFormato = s + fechaConFormato;
            }
            return fechaConFormato + " 00:00:00.00";
        }
    }
}
