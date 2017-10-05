namespace Entidades
{
    public class Vendedor : Persona
    {
        public string Dni { get; set; }
        public Vendedor(string nombre, string apellido, string dni, DatosContacto datosContacto): base(nombre, apellido, datosContacto)
        {
            Dni = dni;
        }

        public override string ToString()
        {
            return "Vendedor:\nNombre: " + Nombre + "\nApellido:" + Apellido;
        }
    }
}
