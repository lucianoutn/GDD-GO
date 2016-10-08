using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.DataBase.Entidades
{
    public class Empresa
    {
        private String desc_id_username;
        private String desc_id_empresa;
        private String desc_razon_social;
        private String desc_mail;
        private String desc_telefono;
        private String desc_fecha_creacion;
        private String desc_dom_calle;
        private String desc_nro_calle;
        private String desc_piso;
        private String desc_depto;
        private String desc_localidad;
        private String desc_codigo_postal;
        private String desc_ciudad;
        private String desc_cuit;
        private String desc_nombre_contacto;
        private String desc_rubro;
        private String desc_estado;

        /* GETTERS Y SETTERS */
        public String getIdUsername()
        {
            return this.desc_id_username;
        }

        public void setIdUsername(String id_username)
        {
            this.desc_id_username = id_username;
        }

        public String getIdEmpresa()
        {
            return this.desc_id_empresa;
        }

        public void setIdEmpresa(String id_empresa)
        {
            this.desc_id_empresa = id_empresa;
        }

        public String getRazSoc()
        {
            return this.desc_razon_social;
        }

        public void setRazSoc(String raz_soc)
        {
            this.desc_razon_social = raz_soc;
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

        public void setTelefono(String tel)
        {
            this.desc_telefono = tel;
        }

        public String getFechaCreacion()
        {
            return this.desc_fecha_creacion;
        }

        public void setFechaCreacion(String fecha)
        {
            this.desc_fecha_creacion = fecha;
        }

        public String getDomCalle()
        {
            return this.desc_dom_calle;
        }

        public void setDomCalle(String dom)
        {
            this.desc_dom_calle = dom;
        }

        public String getNroCalle()
        {
            return this.desc_nro_calle;
        }

        public void setNroCalle(String nro_calle)
        {
            this.desc_nro_calle = nro_calle;
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

        public String getCodPos()
        {
            return this.desc_codigo_postal;
        }

        public void setCodPos(String cod_pos)
        {
            this.desc_codigo_postal = cod_pos;
        }

        public String getCiudad()
        {
            return this.desc_ciudad;
        }

        public void setCiudad(String ciudad)
        {
            this.desc_ciudad = ciudad;
        }

        public String getCuit()
        {
            return this.desc_cuit;
        }

        public void setCuit(String desc_cuit)
        {
            this.desc_cuit = desc_cuit;
        }

        public String getNombreContacto()
        {
            return this.desc_nombre_contacto;
        }

        public void setNombreContacto(String nombre_contacto)
        {
            this.desc_nombre_contacto = nombre_contacto;
        }

        public String getRubro()
        {
            return this.desc_rubro;
        }

        public void setRubro(String rubro)
        {
            this.desc_rubro = rubro;
        }

        public String getEstado()
        {
            return this.desc_estado;
        }

        public void setEstado(String estado)
        {
            this.desc_estado = estado;
        }
    }

}
