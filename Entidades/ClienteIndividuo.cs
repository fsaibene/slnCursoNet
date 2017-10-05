namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public string Cuit { get; set; }

        public ClienteIndividuo(string nombre, string apellido, string cuit, DatosContacto datosContacto): base(nombre, apellido, datosContacto)
        {
            Cuit = cuit;
        }

        public override string ToString()
        {
            return "ClienteIndividuo:\nNombre: " + Nombre + "\nApellido:" + Apellido;
        }
    }
}
