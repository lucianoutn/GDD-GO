using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DataBase.Entidades
{
    public class Cliente
    {
        private String desc_apellido;
        private String desc_nombre;
        private String desc_tipo_doc;
        private String desc_dni;
        private String desc_mail;
        private String desc_direccion;
        private String desc_numero_calle;
        private String desc_piso;
        private String desc_depto;
        private String desc_codigo_postal;
        private String desc_localidad;
        private String desc_telefono;
        private String fecha_nacimiento;
        private String fecha_creacion;
        private String desc_id_login;
        private String desc_id_cliente;
        private String username;
        private String rol;


        /* GETTERS Y SETTERS */
            public String getIdLogin()
            {
                return this.desc_id_login;
            }

            public void setIdLogin(String id_login)
            {
                this.desc_id_login = id_login;
            }

            public String getIdCliente()
            {
                return this.desc_id_cliente;
            }

            public void setIdCliente(String id_cliente)
            {
                this.desc_id_cliente = id_cliente;
            }

            public String getDni()
            {
                return this.desc_dni;
            }

            public void setDni(String dni)
            {
                this.desc_dni = dni;
            }

            public String getNombre()
            {
                return this.desc_nombre;
            }

            public void setNombre(String nombre)
            {
                this.desc_nombre = nombre;
            }

            public String getApellido()
            {
                return this.desc_apellido;
            }

            public void setApellido(String apellido)
            {
                this.desc_apellido = apellido;
            }

            public String getFecha_nacimiento()
            {
                return this.fecha_nacimiento;
            }

            public void setFecha_nacimiento(String fecha_nacimiento)
            {
                this.fecha_nacimiento = fecha_nacimiento;
            }

            public String getMail()
            {
                return this.desc_mail;
            }

            public void setMail(String mail)
            {
                this.desc_mail = mail;
            }

            public String getTelefono()
            {
                return this.desc_telefono;
            }

            public void setTelefono(String telefono)
            {
                this.desc_telefono = telefono;
            }

            public String getDireccion()
            {
                return this.desc_direccion;
            }

            public void setDireccion(String direccion)
            {
                this.desc_direccion = direccion;
            }

            public String getCodigo_postal()
            {
                return this.desc_codigo_postal;
            }

            public void setCodigo_postal(String codigo_postal)
            {
                this.desc_codigo_postal = codigo_postal;
            }

            public String getNroCalle()
            {
                return this.desc_numero_calle;
            }

            public void setNroCalle(String numero_calle)
            {
                this.desc_numero_calle = numero_calle;
            }

            public String getPiso()
            {
                return this.desc_piso;
            }

            public void setPiso(String piso)
            {
                this.desc_piso = piso;
            }

            public String getDepto()
            {
                return this.desc_depto;
            }

            public void setDepto(String depto)
            {
                this.desc_depto = depto;
            }

            public String getLocalidad()
            {
                return this.desc_localidad;
            }

            public void setLocalidad(String localidad)
            {
                this.desc_localidad = localidad;
            }

            public String getTipoDoc()
            {
                return this.desc_tipo_doc;
            }

            public void setTipoDoc(String tipo_doc)
            {
                this.desc_tipo_doc = tipo_doc;
            }

            public String getUsername()
            {
                return this.username;
            }

            public void setUsername(string username)
            {
 	            this.username = username;
            }


            public String getRol()
            {
                return this.rol;
            }

            public void setRol(string rol)
            {
                this.rol = rol;
            }

            public String getFechaCreacion()
            {
                return this.fecha_creacion;
            }

            public void setFechaCreacion(string fecha_creacion)
            {
                this.fecha_creacion = fecha_creacion;
            }
    
    
    }
}
