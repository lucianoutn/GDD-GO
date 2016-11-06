using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class Afiliado
    {
        private String desc_apellido;
        private String desc_nombre;
        private String desc_tipo_doc;
        private Int32 desc_dni;
        private String username;
        private Int32 usuario;
        private Int32 afiliado_id;

        public Afiliado(Int32 id, String name, String lastName,
                        String t_doc, Int32 dni, Int32 userID)
        {
            desc_apellido = lastName;
            desc_nombre = name;
            desc_tipo_doc = t_doc;
            desc_dni = dni;
            usuario = userID;
            afiliado_id = id;
        }

        public String get_apellido()
        {
            return desc_apellido;
        }
        public String get_nombre()
        {
            return desc_nombre;
        }
        public String get_tipo_doc()
        {
            return desc_tipo_doc;
        }
        public Int32 get_dni()
        {
            return desc_dni;
        }
        public String gwtusername()
        {
            return username;
        }
        public Int32 getusuario()
        {
            return usuario;
        }
        public Int32 getafiliado_id()
        {
            return afiliado_id;
        }

        public String toString()
        {
            return get_dni()+" - " + get_nombre() + get_apellido();
        }


    }
}
