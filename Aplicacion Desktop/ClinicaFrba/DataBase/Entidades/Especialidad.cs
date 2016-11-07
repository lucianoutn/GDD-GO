using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class Especialidad
    {
        int _id;
        String descripcion;
        String descripcion_Tipo;

        public Especialidad(int id, String descrip, String tipo)
        {
            _id = id;
            descripcion = descrip;
            descripcion_Tipo = tipo;
        }
    
        public int getID(){ return _id;}
        public String getDescripcion(){return descripcion;}
        public String getTipo() { return descripcion_Tipo; }
        public String toString() { return getDescripcion(); }
    }
}
