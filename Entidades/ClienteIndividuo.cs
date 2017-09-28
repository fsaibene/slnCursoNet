namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public string Cuit { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string cuit, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Cuit = cuit;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return "ClienteIndividuo:\nNombre: " + Nombre + "\nApellido:" + Apellido;
        }
    }
}
