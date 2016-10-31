using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaFrba.DataBase.Entidades
{
    class Profesional
    {
        private Int32 _id;
        private String nombre;
        private String apellido;
        private String tipoDNI;
        private Int32 dni;
        private String direccion;
        private Int32 telefono;
        private String mail;
        private DateTime nacimiento;
        private DateTime creacion;
        private String sexo;
        private String matricula;
        private Int32 usuario;

        public Profesional(Int32 id, String lastName, String name,
            String t_dni, Int32 DNI, String address, Int32 phone, String email,
            DateTime log, DateTime birth,String gender,String mat,Int32 userID)
        {
            _id = id;
            nombre = name;
            apellido = lastName;
            tipoDNI = t_dni;
            dni = DNI;
            direccion = address;
            telefono = phone;
            mail = email;
            creacion = log;
            nacimiento = birth;
            sexo = gender;
            matricula = mat;
            usuario = userID;
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
        public String settipoDNI(String tipo)
        {
            tipoDNI = tipo;
            return tipoDNI;
        }
        public Int32 setdni(Int32 DNI)
        {
            dni = DNI;
            return dni;
        }
        public String setdireccion(String address)
        {
            direccion = address;
            return direccion;
        }
        public Int32 settelefono(Int32 phone)
        {
            telefono = phone;
            return telefono;
        }
        public String setmail(String email)
        {
            mail = email;
            return mail;
        }
        public DateTime setnacimiento(DateTime birth)
        {
            nacimiento = birth;
            return nacimiento;
        }
        public DateTime setcreacion(DateTime log)
        {
            creacion = log;
            return creacion;
        }
        public String setsexo(String gender)
        {
            sexo = gender;
            return sexo;
        }
        public String setmatricula(String matric)
        { 
            matricula = matric;
            return matricula;
        }

        public Int32 getid() { return _id; }
        public String getnombre() { return nombre; }
        public String getapellido() { return apellido; }
        public String gettipoDNI() { return tipoDNI; }
        public Int32 getdni() { return dni; }
        public String getdireccion() { return direccion; }
        public Int32 gettelefono() { return telefono; }
        public String getmail() { return mail; }
        public DateTime getnacimiento() { return nacimiento; }
        public DateTime getcreacion() { return creacion; }
        public String getsexo() { return sexo; }
        public String getmatricula() { return matricula; }
        public Int32 getusuario() { return usuario; }
        public String toString() { return "Dr./Dra. " + this.getapellido() + " " + this.getnombre(); }
    }
}
