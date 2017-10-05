namespace Entidades
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public Persona Contacto { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public Empresa(string nombre, Persona contacto, string cuit, DatosContacto datos)
        {
            Nombre = nombre;
            Contacto = contacto;
            Cuit = cuit;
            DatosContacto = datos;
        }

        public override string ToString()
        {
            return "Empresa:\nNombre: " + Nombre + "\nContacto:" + Contacto;
        }
    }
}
