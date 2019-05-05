using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_tercer_trimestre
{
    class Clientes
    {
        private String nombre;
        private String direccion;
        private String telefono;
        private String email;

        public Clientes()
        {
            nombre = "";
            direccion = "";
            telefono = "";
            email = "";
        }

        public Clientes(string nombre, string direccion, string telefono, string email)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
        }

        public Clientes setNombre(String nombre)
        {
            this.nombre = nombre;
            return this;
        }
        public String getNombre()
        {
      
            return this.nombre;
        }
        public Clientes setDireccion(String direccion)
        {
            this.direccion = direccion;
            return this;
        }
        public String getDireccion()
        {

            return this.direccion;
        }
        public Clientes setTelefono(String telefono)
        {
            this.telefono = telefono;
            return this;
        }
        public String getTelefono()
        {

            return this.telefono;
        }
        public Clientes setEmail(String email)
        {
            this.email = email;
            return this;
        }
        public String getEmail()
        {

            return this.email;
        }


    }
}
