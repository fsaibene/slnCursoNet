using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        List<object> entitiesList;
        public Form1()
        {
            InitializeComponent();
            entitiesList = new List<object>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ShowEntities();
        }

        private void ShowEntity(object entity)
        {
            MessageBox.Show(entity.ToString());
        }

        private void LoadEntities()
        {
            entitiesList.Add(new Empresa("P1", GeneratePersona("Aaa"), "22-22226665-1", GenerateDatosContacto("BB")));
            entitiesList.Add(new ClienteIndividuo("Ccc", "asdsa", "22-2323233-1", GenerateDatosContacto("fff")));
            /*entitiesList.Add(new Vendedor("Pepe", "Argento", "112233", "Vendedor@Vendedor.com", "555554444", "Calle D 123"));
            entitiesList.Add(new Producto("Botella", "cosas", 10, 10, "P1", "Algo", "AlgoAlgo"));
            entitiesList.Add(new Factura("A", "1112321", DateTime.Now, "Alguien", "Mitre 750", "asfasf", "fdfdf", "compra de cosas", 100));
            entitiesList.Add(new Remito("2255", DateTime.Now, "AlguienMas", "Cerrito 1186", "ajjgd", "asdlasd", "detaillll", DateTime.Now, 55000));*/
        }

        private Persona GeneratePersona(string param)
        {
            return new Persona("Nombre" + param, "Apellido" + param, GenerateDatosContacto(param));
        }

        private DatosContacto GenerateDatosContacto(string param)
        {
            return new DatosContacto("Email" + param, "Direccion" + param, "Telefono" + param);
        }

        private void ShowEntities()
        {
            foreach (object item in entitiesList)
            {
                ShowEntity(item);
            }
        }

    }
}
