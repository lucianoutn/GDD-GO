using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class TurnoProfesional
    {
        private Int32 _id;
        private String hora_llegada;
        private String apellido;
        private String nombre;
        private Int32 dni;

        public TurnoProfesional(Int32 id, String lastName, String name, Int32 DNI, String arrive)
        {
            _id = id;
            nombre = name;
            apellido = lastName;
            dni = DNI;
            hora_llegada = arrive;
        }

        public Int32 setid(Int32 id)
        {
            _id = id;
            return _id;
        }
        public String setnombre(String name)
        {
            nombre = name;
            return nombre;
        }
        public String setapellido(String lastName)
        {
            apellido = lastName;
            return apellido;
        }
        public Int32 setdni(Int32 DNI)
        {
            dni = DNI;
            return dni;
        }
        public String sethora_llegada(String address)
        {
            hora_llegada = address;
            return hora_llegada;
        }

        public Int32 getid() { return _id; }
        public String getnombre() { return nombre; }
        public String getapellido() { return apellido; }
        public Int32 getdni() { return dni; }
        public String gethora_llegada() { return hora_llegada; }
        public String toString() { return "" + this.getapellido() + " " + this.getnombre(); }
    }
}
