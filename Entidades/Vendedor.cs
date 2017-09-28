namespace Entidades
{
    public class Vendedor : Persona
    {
        public string Dni { get; set; }
        public Vendedor(string nombre, string apellido, string dni, string email, string telefono, string direccion)
      {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return "Vendedor:\nNombre: " + Nombre + "\nApellido:" + Apellido;
        }
    }
}
