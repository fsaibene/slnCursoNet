namespace Entidades
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Empresa(string nombre, string contacto, string cuit, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Contacto = contacto;
            Cuit = cuit;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return "Empresa:\nNombre: " + Nombre + "\nContacto:" + Contacto;
        }
    }
}
