namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DatosContacto DatosContacto { get; set; }

        public Persona(string nombre, string apellido, DatosContacto datosContacto)
        {
            Nombre = nombre;
            Apellido = apellido;
            DatosContacto = datosContacto;
        }
    }
}
