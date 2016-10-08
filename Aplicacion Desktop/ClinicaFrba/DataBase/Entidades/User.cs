using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.ABM_Usuario
{
    class User
    {
        private String id_usuario;


        /* GETTERS Y SETTERS */
        public String getIdUsuario()
        {
            return this.id_usuario;
        }

        public void setIdUsuario(String id)
        {
            this.id_usuario = id;
        }
    }
}
