namespace Entidades
{
    public class Proveedor
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public Persona Contacto { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public Proveedor(string nombre, Persona contacto, string cuit, DatosContacto datosContacto)
        {
            Nombre = nombre;
            Contacto = contacto;
            Cuit = cuit;
            DatosContacto = datosContacto;
        }

        public override string ToString()
        {
            return "Proveedor:\nNombre: " + Nombre + "\nContacto:" + Contacto;
        }
    }
}
