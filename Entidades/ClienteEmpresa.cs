using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEmpresa
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public ClienteEmpresa(string nombre, string cuit, string contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Cuit = cuit;
            Contacto = contacto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return "ClienteEmpresa:\nNombre: " + Nombre + "\nContacto:" + Contacto;
        }
    }
}
